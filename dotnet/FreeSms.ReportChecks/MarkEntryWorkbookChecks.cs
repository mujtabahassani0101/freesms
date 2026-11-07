using System.IO.Compression;
using System.Xml.Linq;
using FreeSms.Reports;

internal static class MarkEntryWorkbookChecks
{
    internal static void Verify(Action<bool,string> check)
    {
        string directory=Path.Combine(Path.GetTempPath(),"FreeSms-workbook-"+Guid.NewGuid().ToString("N"));Directory.CreateDirectory(directory);
        try
        {
            string path=Path.Combine(directory,"mark.xlsx");
            MarkEntryWorkbook.Write(path,new IReadOnlyList<string?>[]{new[]{(string?)null,"9223372036854775807","123","نام ' محفوظ","=1+2","مضمون"}});
            using(var zip=ZipFile.OpenRead(path))
            {
                XNamespace ns="http://schemas.openxmlformats.org/spreadsheetml/2006/main";
                using var stream=zip.GetEntry("xl/worksheets/sheet1.xml")!.Open();var sheet=XDocument.Load(stream);
                var rows=sheet.Descendants(ns+"row").ToArray();string[] headers=rows[0].Descendants(ns+"t").Select(n=>n.Value).ToArray();
                check(headers.SequenceEqual(new[]{"ترتیب","Code","codeDars","نام","ولد/بنت","مضمون","mark"}) && rows.Length==2 && rows[1].Elements(ns+"c").Count()==6,"mark-entry XLSX retains seven original headers and empty mark input column");
                check(sheet.Descendants(ns+"t").Any(t=>t.Value=="9223372036854775807") && sheet.Descendants(ns+"t").Any(t=>t.Value=="=1+2") && !sheet.Descendants(ns+"f").Any() && sheet.Descendants(ns+"c").All(c=>(string?)c.Attribute("t")=="inlineStr"),"mark-entry output retains full BigInt, quoted Persian and formula-looking text literally");
                check(sheet.Descendants(ns+"sheetView").Single().Attribute("rightToLeft")!.Value=="1" && sheet.Descendants(ns+"col").Last().Attribute("style")!.Value=="2","mark-entry worksheet uses RTL and the original decimal mark format");
                using var wb=zip.GetEntry("xl/workbook.xml")!.Open();check(XDocument.Load(wb).Descendants(ns+"sheet").Single().Attribute("name")!.Value=="Sheet1","mark-entry workbook retains the original import sheet name");
            }
            string first=Path.Combine(directory,"first.xlsx"),second=Path.Combine(directory,"second.xlsx");File.WriteAllText(first,"old-first");File.WriteAllText(second,"old-second");
            void Reject(Action action){try{action();}catch(IOException){return;}throw new Exception("Expected failed export.");}
            Reject(()=>WorkbookFileBatch.Save(new[]{new WorkbookFile(first,WorkbookFileBatch.Fingerprint(first),p=>File.WriteAllText(p,"new-first")),new WorkbookFile(second,WorkbookFileBatch.Fingerprint(second),p=>{File.WriteAllText(p,"partial");throw new IOException("owned staging failure");})}));
            check(File.ReadAllText(first)=="old-first" && File.ReadAllText(second)=="old-second" && !Directory.GetFiles(directory).Any(f=>f.EndsWith(".tmp")),"failed workbook staging preserves all previous files and removes partial staging files");
            string blocked=Path.Combine(directory,"blocked.xlsx");Directory.CreateDirectory(blocked);
            Reject(()=>WorkbookFileBatch.Save(new[]{new WorkbookFile(first,WorkbookFileBatch.Fingerprint(first),p=>File.WriteAllText(p,"new-first")),new WorkbookFile(blocked,null,p=>File.WriteAllText(p,"new-second"))}));
            check(File.ReadAllText(first)=="old-first" && Directory.Exists(blocked),"late output replacement failure restores an earlier replaced workbook");
            string oldSecondHash=WorkbookFileBatch.Fingerprint(second)!;
            Reject(()=>WorkbookFileBatch.Save(new[]{new WorkbookFile(first,WorkbookFileBatch.Fingerprint(first),p=>File.WriteAllText(p,"new-first")),new WorkbookFile(second,oldSecondHash,p=>{File.WriteAllText(p,"new-second");File.WriteAllText(second,"concurrent change");})}));
            check(File.ReadAllText(first)=="old-first" && File.ReadAllText(second)=="concurrent change","a changed destination rejects the batch, preserves concurrent input and restores earlier output");
            WorkbookFileBatch.Save(new[]{new WorkbookFile(first,WorkbookFileBatch.Fingerprint(first),p=>File.WriteAllText(p,"new-first")),new WorkbookFile(second,WorkbookFileBatch.Fingerprint(second),p=>File.WriteAllText(p,"new-second"))});
            check(File.ReadAllText(first)=="new-first" && File.ReadAllText(second)=="new-second" && !Directory.GetFiles(directory).Any(f=>f.EndsWith(".tmp") || f.EndsWith(".bak")),"successful workbook batch replaces approved destinations and removes staging/safety copies");
            string name=MarkEntryWorkbook.FileName("صنف/\\:*?\"<>|\n","اول",1);
            check(name.EndsWith(".xlsx") && !name.Any(c=>c<32 || "<>:\"/\\|?*".Contains(c)) && MarkEntryWorkbook.FileName("صنف","اول",1)=="صنف-اول.xlsx","Windows mark filenames preserve class-grade names while removing invalid path characters");
        }
        finally{Directory.Delete(directory,true);}
    }
}
