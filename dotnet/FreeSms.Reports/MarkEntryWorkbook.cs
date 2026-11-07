using System.Globalization;
using System.IO.Compression;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace FreeSms.Reports;

// Managed replacement of Mark.xls: retain Sheet1, the original six query
// headings and the template's seventh mark field. Identifiers are literal text.
public static class MarkEntryWorkbook
{
    private const string Main="http://schemas.openxmlformats.org/spreadsheetml/2006/main";
    private const string Relations="http://schemas.openxmlformats.org/officeDocument/2006/relationships";
    public static string FileName(string classroom,string grade,int classId)
    {
        if(classId<=0)throw new ArgumentOutOfRangeException(nameof(classId));
        string Clean(string value)=>string.Concat(value.Select(c=>c<32 || "<>:\"/\\|?*".Contains(c)?'-':c)).Trim().TrimEnd('.',' ');
        string name=Clean(classroom)+"-"+Clean(grade);
        if(name.Length>160)name=name[..160];
        // Keep the recovered class-grade name where possible. Reserved device
        // names cannot be created by Windows even with an extension.
        if(name.Length==0)name="class-"+classId;
        string first=name.Split('.')[0].ToUpperInvariant();
        if(new[]{"CON","PRN","AUX","NUL","COM1","COM2","COM3","COM4","COM5","COM6","COM7","COM8","COM9","LPT1","LPT2","LPT3","LPT4","LPT5","LPT6","LPT7","LPT8","LPT9"}.Contains(first))name="_"+name;
        return name+".xlsx";
    }
    public static void Write(string path,IReadOnlyList<IReadOnlyList<string?>> rows)
    {
        if(rows.Count>1_048_575 || rows.Any(row=>row.Count!=6))throw new InvalidDataException("Invalid mark-entry worksheet dimensions.");
        using var stream=new FileStream(path,FileMode.CreateNew,FileAccess.ReadWrite,FileShare.None);
        using var archive=new ZipArchive(stream,ZipArchiveMode.Create);
        ZipArchiveEntry Entry(string name)
        {
            var entry=archive.CreateEntry(name,CompressionLevel.Optimal);
            entry.LastWriteTime=new DateTimeOffset(2000,1,1,0,0,0,TimeSpan.Zero);return entry;
        }
        void Xml(string name,XDocument document)
        {
            using var entry=Entry(name).Open();
            using var writer=XmlWriter.Create(entry,new XmlWriterSettings{Encoding=new UTF8Encoding(false),CheckCharacters=true});document.Save(writer);
        }
        XNamespace ns=Main,rel=Relations,pkg="http://schemas.openxmlformats.org/package/2006/relationships",ct="http://schemas.openxmlformats.org/package/2006/content-types";
        Xml("[Content_Types].xml",new(new XElement(ct+"Types",new XElement(ct+"Default",new XAttribute("Extension","rels"),new XAttribute("ContentType","application/vnd.openxmlformats-package.relationships+xml")),new XElement(ct+"Default",new XAttribute("Extension","xml"),new XAttribute("ContentType","application/xml")),new XElement(ct+"Override",new XAttribute("PartName","/xl/workbook.xml"),new XAttribute("ContentType","application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml")),new XElement(ct+"Override",new XAttribute("PartName","/xl/styles.xml"),new XAttribute("ContentType","application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml")),new XElement(ct+"Override",new XAttribute("PartName","/xl/worksheets/sheet1.xml"),new XAttribute("ContentType","application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml")))));
        Xml("_rels/.rels",new(new XElement(pkg+"Relationships",new XElement(pkg+"Relationship",new XAttribute("Id","rId1"),new XAttribute("Type",Relations+"/officeDocument"),new XAttribute("Target","xl/workbook.xml")))));
        Xml("xl/workbook.xml",new(new XElement(ns+"workbook",new XAttribute(XNamespace.Xmlns+"r",rel),new XElement(ns+"sheets",new XElement(ns+"sheet",new XAttribute("name","Sheet1"),new XAttribute("sheetId",1),new XAttribute(rel+"id","rId1"))))));
        Xml("xl/_rels/workbook.xml.rels",new(new XElement(pkg+"Relationships",new XElement(pkg+"Relationship",new XAttribute("Id","rId1"),new XAttribute("Type",Relations+"/worksheet"),new XAttribute("Target","worksheets/sheet1.xml")),new XElement(pkg+"Relationship",new XAttribute("Id","rId2"),new XAttribute("Type",Relations+"/styles"),new XAttribute("Target","styles.xml")))));
        Xml("xl/styles.xml",XDocument.Parse("<styleSheet xmlns='"+Main+"'><fonts count='1'><font><sz val='11'/><name val='Tahoma'/></font></fonts><fills count='2'><fill><patternFill patternType='none'/></fill><fill><patternFill patternType='gray125'/></fill></fills><borders count='1'><border/></borders><cellStyleXfs count='1'><xf numFmtId='0' fontId='0' fillId='0' borderId='0'/></cellStyleXfs><cellXfs count='3'><xf numFmtId='0' fontId='0' fillId='0' borderId='0' xfId='0'/><xf numFmtId='49' fontId='0' fillId='0' borderId='0' xfId='0' applyNumberFormat='1'/><xf numFmtId='2' fontId='0' fillId='0' borderId='0' xfId='0' applyNumberFormat='1'/></cellXfs></styleSheet>"));
        using var sheet=Entry("xl/worksheets/sheet1.xml").Open();
        using var w=XmlWriter.Create(sheet,new XmlWriterSettings{Encoding=new UTF8Encoding(false),CheckCharacters=true});
        w.WriteStartElement("worksheet",Main);w.WriteStartElement("sheetViews");w.WriteStartElement("sheetView");w.WriteAttributeString("workbookViewId","0");w.WriteAttributeString("rightToLeft","1");w.WriteStartElement("pane");w.WriteAttributeString("ySplit","1");w.WriteAttributeString("topLeftCell","A2");w.WriteAttributeString("state","frozen");w.WriteEndElement();w.WriteEndElement();w.WriteEndElement();
        w.WriteStartElement("cols");double[] widths={8,18,14,24,24,28,12};
        for(int i=0;i<7;i++){w.WriteStartElement("col");w.WriteAttributeString("min",(i+1).ToString(CultureInfo.InvariantCulture));w.WriteAttributeString("max",(i+1).ToString(CultureInfo.InvariantCulture));w.WriteAttributeString("width",widths[i].ToString(CultureInfo.InvariantCulture));w.WriteAttributeString("customWidth","1");w.WriteAttributeString("style",i==6?"2":"1");w.WriteEndElement();}w.WriteEndElement();w.WriteStartElement("sheetData");
        void Row(int number,IReadOnlyList<string?> values)
        {
            w.WriteStartElement("row");w.WriteAttributeString("r",number.ToString(CultureInfo.InvariantCulture));
            for(int i=0;i<values.Count;i++)
            {
                string text=values[i]??"";if(text.Length>32767)throw new InvalidDataException("Excel cell text exceeds its supported length.");
                w.WriteStartElement("c");w.WriteAttributeString("r",((char)('A'+i))+number.ToString(CultureInfo.InvariantCulture));w.WriteAttributeString("t","inlineStr");w.WriteAttributeString("s","1");w.WriteStartElement("is");w.WriteStartElement("t");w.WriteAttributeString("xml","space","http://www.w3.org/XML/1998/namespace","preserve");w.WriteString(text);w.WriteEndElement();w.WriteEndElement();w.WriteEndElement();
            }
            w.WriteEndElement();
        }
        Row(1,new[]{"ترتیب","Code","codeDars","نام","ولد/بنت","مضمون","mark"});
        for(int i=0;i<rows.Count;i++)Row(i+2,rows[i]);
        w.WriteEndElement();w.WriteEndElement();
    }
}
