using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text.Json;

internal static class PackageChecks
{
    internal static void Verify(string root, Action<bool, string> check)
    {
        string directory = Path.Combine(root, "dist", "FreeSMS-Net10");
        using var runtime = JsonDocument.Parse(File.ReadAllText(Path.Combine(directory, "FreeSMS.runtimeconfig.json")));
        var options = runtime.RootElement.GetProperty("runtimeOptions");
        check(options.GetProperty("tfm").GetString() == "net10.0" && options.GetProperty("includedFrameworks").EnumerateArray().All(f => f.GetProperty("version").GetString()!.StartsWith("10.0.")), "self-contained package uses only .NET 10 frameworks");
        check(!Directory.EnumerateFiles(directory, "CrystalDecisions*.dll", SearchOption.AllDirectories).Any() && !Directory.EnumerateFiles(directory, "Janus*.dll", SearchOption.AllDirectories).Any() && !Directory.Exists(Path.Combine(directory, "report-host")) && !Directory.Exists(Path.Combine(directory, "legacy-ui")), "release contains no old UI or report runtime");
        var assemblies = new Dictionary<string, object>();
        foreach (string name in new[] { "FreeSMS.dll", "FreeSms.Core.dll", "FreeSms.NativeControls.dll", "FreeSms.Reports.dll" })
        {
            using var stream = File.OpenRead(Path.Combine(directory, name));
            using var pe = new PEReader(stream);
            var native = pe.PEHeaders.CorHeader!.ManagedNativeHeaderDirectory;
            bool ready = native.Size >= 4 && pe.GetSectionData(native.RelativeVirtualAddress).GetContent(0, 4).AsSpan().SequenceEqual(new byte[] { 82, 84, 82, 0 });
            var metadata = pe.GetMetadataReader();
            string? target = null;
            foreach (var handle in metadata.GetAssemblyDefinition().GetCustomAttributes())
            {
                var attribute = metadata.GetCustomAttribute(handle);
                if (attribute.Constructor.Kind != HandleKind.MemberReference) continue;
                var constructor = metadata.GetMemberReference((MemberReferenceHandle)attribute.Constructor);
                if (constructor.Parent.Kind != HandleKind.TypeReference) continue;
                var type = metadata.GetTypeReference((TypeReferenceHandle)constructor.Parent);
                if (metadata.GetString(type.Name) != "TargetFrameworkAttribute") continue;
                var blob = metadata.GetBlobReader(attribute.Value); blob.ReadUInt16(); target = blob.ReadSerializedString();
            }
            check(ready && pe.PEHeaders.CoffHeader.Machine == Machine.I386 && target == ".NETCoreApp,Version=v10.0", ".NET 10 x86 ReadyToRun: " + name);
            assemblies[name] = new { target, ready_to_run = ready, machine = "0x14c" };
        }
        File.WriteAllText(Path.Combine(root, "validation", "dotnet-release.json"), JsonSerializer.Serialize(new { target = "net10.0-windows", rid = "win-x86", self_contained = true, assemblies }, new JsonSerializerOptions { WriteIndented = true }));
    }
}
