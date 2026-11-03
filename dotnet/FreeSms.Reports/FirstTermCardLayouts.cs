using System.Xml.Linq;

namespace FreeSms.Reports;

// Adapt only the presentation of these recovered cards. SQL, groups, formulas,
// links, parameters and the recovered XML files remain the source of the data.
internal static class FirstTermCardLayouts
{
    internal static void Apply(XElement report)
    {
        string type=(string?)report.Attribute("type")??"";
        bool landscape=type=="school_Af.Rpt.karname.CR_AF_StdKarnameDorehByChart_term1_land";
        if(!landscape && type!="school_Af.Rpt.karname.CR_AF_StdKarnameDorehByChart_term1")return;
        if(report.Attribute("native-first-term-layout")!=null)return;
        report.SetAttributeValue("native-first-term-layout","1");
        int width=landscape?15900:10800;
        var original=report.Element("sections")??throw new InvalidDataException("First-term card sections are missing.");
        XElement Object(string name)=>new(original.Elements("section").Elements("object").Single(o=>o.Element("Name")?.Value==name));
        var photo=Object("Studentimg1");
        var graph=Object("Graph1");
        var subreports=new[]{"Sub1","Sub2","Sub3"}.ToDictionary(name=>name,name=>Object(name));
        var sections=new XElement("sections");
        var page=Band("NativeCardPageHeader","PageHeader",landscape?1000:1150);
        page.Add(Field("NativeInstitutionHeader","{?heder1}",200,0,width,330,10),Field("NativeCardTitle","{@heder}",200,380,width,400,11));
        page.Add(Field("NativePageStudent","'شاگرد: ' + {spRpt_StdKarnameDoreh1.FName} + '    کد: ' + ToText({spRpt_StdKarnameDoreh1.Code},0,'')",200,800,width,300,9));
        sections.Add(page);

        Formula(report,"nativeCardIdentity","'مکتب: ' + {?sch} + '\nشاگرد: ' + {spRpt_StdKarnameDoreh1.FName} + '\nنام پدر: ' + {spRpt_StdKarnameDoreh1.LName} + '\nولدیت: ' + {spRpt_StdKarnameDoreh1.PName} + '\nکد متعلم: ' + ToText({spRpt_StdKarnameDoreh1.Code},0,'') + '    نمبر اساس: ' + ToText({spRpt_StdKarnameDoreh1.NumberAsas},0,'') + '\nنمبر تذکره: ' + {spRpt_StdKarnameDoreh1.sh_sh}");
        if(landscape)report.Element("formulas")!.Elements("formula").Single(f=>(string?)f.Attribute("name")=="nativeCardIdentity").Value="'مکتب: ' + {?sch} + '    شاگرد: ' + {spRpt_StdKarnameDoreh1.FName} + '\nنام پدر: ' + {spRpt_StdKarnameDoreh1.LName} + '    ولدیت: ' + {spRpt_StdKarnameDoreh1.PName} + '\nکد متعلم: ' + ToText({spRpt_StdKarnameDoreh1.Code},0,'') + '    نمبر اساس: ' + ToText({spRpt_StdKarnameDoreh1.NumberAsas},0,'') + '\nنمبر تذکره: ' + {spRpt_StdKarnameDoreh1.sh_sh}";
        Formula(report,"nativeCardClass","'پایه: ' + {@paye} + '    صنف: ' + {@class} + '\n' + {@DateFrom}");
        if(landscape)report.Element("formulas")!.Elements("formula").Single(f=>(string?)f.Attribute("name")=="nativeCardClass").Value="'پایه: ' + {@paye} + '    صنف: ' + {@class} + '    ' + {@DateFrom}";
        var identity=Band("NativeCardIdentity","GroupHeader",landscape?1200:1850);
        Place(photo,200,80,1100,landscape?1100:1550);identity.Add(photo,Field("NativeStudentIdentity","{@nativeCardIdentity}",1550,0,width-1350,landscape?1150:1800,10));
        sections.Add(identity);
        var position=Band("NativeCardClass","GroupHeader",landscape?420:700);position.Add(Field("NativeClassDates","{@nativeCardClass}",200,0,width,landscape?400:650,10));sections.Add(position);
        var additional=Band("NativeCardAdditionalHeader","GroupHeader",0);additional.Add(Field("NativeAdditionalHeader","{?heder2}",200,0,width,0,9));sections.Add(additional);

        if(landscape)
        {
            // Landscape Sub1 is the course/summary card, not the portrait's
            // optional progress chart. Keep its original dataset and links.
            ReflowCourses(subreports["Sub1"].Element("report")!,width);
            AddSubreport(sections,subreports["Sub1"],"NativeCardCourses",200,0,width);
            var attendance=AttendanceBand(original.Elements("section").Elements("object").ToArray(),width);
            if(attendance!=null)sections.Add(attendance);
        }
        else
        {
            foreach(var section in CourseBands(report,width))sections.Add(section);
        }

        var comparison=Band("NativeCardCourseComparison","GroupFooter",landscape?1900:2450);
        comparison.Add(Field("NativeCourseCaption","'مقایسهٔ نمرهٔ شاگرد و اوسط صنف — ' + {spRpt_StdKarnameDoreh1.Exam}",200,0,width,430,9));
        Place(graph,200,500,width,landscape?1300:1850);
        var chart=graph.Element("chart")!;chart.SetAttributeValue("show-values","true");
        string[] labels={"نمرهٔ شاگرد","اوسط صنف"};int index=0;
        foreach(var series in chart.Elements("series"))series.SetAttributeValue("label",labels[Math.Min(index++,1)]);
        comparison.Add(graph);sections.Add(comparison);
        if(!landscape)AddSubreport(sections,subreports["Sub1"],"NativeCardOptionalProgress",200,0,width);

        ReflowRanking(subreports["Sub2"].Element("report")!,width/2-150,"نفرات برتر صنف");
        ReflowRanking(subreports["Sub3"].Element("report")!,width/2-150,"نفرات برتر پایه");
        var rankings=Band("NativeCardRankings","GroupFooter",0);
        Place(subreports["Sub3"],200,0,width/2-150,0);
        Place(subreports["Sub2"],350+width/2,0,width/2-150,0);
        rankings.Add(subreports["Sub3"],subreports["Sub2"]);sections.Add(rankings);

                var general=Band("NativeCardGeneralComment","GroupFooter",0);general.Add(Field("NativeGeneralComment","{@commentKoll}",200,0,width,0,9));sections.Add(general);
        var signatures=Band("NativeCardSignatures","GroupFooter",landscape?520:650);
        foreach(var item in new[]{("امضاء والدین","{@parent}"),("امضاء مدیر صنف","{@answerable}"),("امضاء مدیر مکتب",landscape?"{spRpt_StdKarnameDoreh1.modir}":"{?foter1}")}.Select((value,i)=>(value,i)))
        {
            int left=200+item.i*width/3;
            signatures.Add(Text("SignatureLabel"+item.i,item.value.Item1,left,0,width/3-100,280,9),Field("SignatureValue"+item.i,item.value.Item2,left,300,width/3-100,300,9));
        }
        sections.Add(signatures);
        var boundary=Band("NativeCardEnd","GroupFooter",0);
        boundary.Add(new XElement("format",new XElement("condition",new XAttribute("name","EnableNewPageAfter"),"not OnLastRecord")));sections.Add(boundary);
        var footer=Band("NativeCardPageFooter","PageFooter",300);footer.Add(Field("NativePageNumber","PageNumber",200,0,1000,260,9));sections.Add(footer);
        original.ReplaceWith(sections);
    }

    private static IEnumerable<XElement> CourseBands(XElement report,int width)
    {
        var originals=report.Element("sections")!.Elements("section").Elements("object").ToArray();
        XElement Copy(string name)=>new(originals.Single(o=>o.Element("Name")?.Value==name));
        bool wide=width>12000;
        var header=Band("NativeCourseHeadings","GroupHeader",wide?520:650);
        var detail=Band("NativeCourseDetail","Detail",wide?330:380);
        string[] captions={"ملاحظات","درجه","رتبه در پایه","رتبه در صنف","نمره","مضمون","ردیف"};
        string?[] fields={null,"tosif1","gschool1","gClass1","mark1","lesson1","radif1"};
        double[] parts={.26,.13,.08,.08,.09,.22,.04};int left=200;
        for(int i=0;i<parts.Length;i++)
        {
            int size=i==parts.Length-1?200+width-left:(int)(parts[i]*width);
            header.Add(Text("CourseHeading"+i,captions[i],left,0,size-40,wide?480:600,9));
            if(fields[i]!=null){var value=Copy(fields[i]!);Place(value,left,0,size-40,wide?300:350);Grow(value,10);detail.Add(value);}
            left+=size;
        }
        yield return header;yield return detail;
        var summary=Band("NativeCourseSummary","GroupFooter",wide?720:850);
        string[] names={"sumMark1","markDoreh1","Acp1","TosifMark51"};
        string[] titles={"مجموع نمرات","اوسط","نتیجه","درجه"};
        for(int i=0;i<names.Length;i++)
        {
            int x=200+i*width/4;summary.Add(Text("SummaryTitle"+i,titles[i],x,0,width/4-80,300,9));
            var value=Copy(names[i]);Place(value,x,350,width/4-80,wide?320:430);Grow(value,10);summary.Add(value);
        }
        yield return summary;
        var comment=Band("NativeCourseComment","GroupFooter",0);var note=Copy("comment51");Place(note,200,0,width,0);Grow(note,10);comment.Add(note);yield return comment;
        var attendance=AttendanceBand(originals,width);
        if(attendance!=null)yield return attendance;
    }
    private static XElement? AttendanceBand(XElement[] originals,int width)
    {
        var attendance=Band("NativeAttendanceAndRank","GroupFooter",width>12000?720:850);
        string[] names={"hazer11","Ghayeb11","Mariz11","rokhsat11","countClass1","countPaye1","gClassKoll1","gPayeKoll1"};
        string[] titles={"حاضر","غیرحاضر","مریض","رخصت","تعداد صنف","تعداد پایه","رتبهٔ صنف","رتبهٔ پایه"};
        for(int i=0;i<names.Length;i++)
        {
            var source=originals.FirstOrDefault(o=>o.Element("Name")?.Value==names[i]);
            if(source==null)continue;
            int x=200+i*width/8;attendance.Add(Text("AttendanceTitle"+i,titles[i],x,0,width/8-40,350,9));
            var value=new XElement(source);Place(value,x,400,width/8-40,300);Grow(value,10);attendance.Add(value);
        }
        return attendance.Elements("object").Any()?attendance:null;
    }

    private static void ReflowCourses(XElement report,int width)
    {
        var bands=CourseBands(report,width).ToArray();
        report.Element("sections")!.ReplaceWith(new XElement("sections",bands));
    }
    private static void ReflowRanking(XElement report,int width,string title)
    {
        var objects=report.Element("sections")!.Elements("section").Elements("object").ToArray();
        string[] names=objects.Any(o=>o.Element("Name")?.Value=="pname1")?new[]{"gClass1","MarkDoreh1","pname1","fullname1"}:new[]{"gClass1","MarkDoreh1","class1","fullname1"};
        var header=Band("NativeRankingHeadings","ReportHeader",800);header.Add(Text("NativeRankingTitle",title,0,0,width,350,10));
        var detail=Band("NativeRankingDetail","Detail",400);
        string[] titles={"رتبه","اوسط",names[2]=="class1"?"صنف":"ولدیت","شاگرد ـ پدر"};
        double[] sizes={.11,.16,.23,.5};int left=0;
        for(int i=0;i<names.Length;i++)
        {
            int size=i==names.Length-1?width-left:(int)(width*sizes[i]);
            header.Add(Text("RankingColumn"+i,titles[i],left,400,size-35,350,9));
            var value=new XElement(objects.Single(o=>o.Element("Name")?.Value==names[i]));Place(value,left,0,size-35,370);Grow(value,9);detail.Add(value);left+=size;
        }
        report.Element("sections")!.ReplaceWith(new XElement("sections",header,detail));
    }
    private static void AddSubreport(XElement sections,XElement obj,string name,int left,int top,int width)
    {
        Place(obj,left,top,width,0);var band=Band(name,"GroupFooter",0);band.Add(obj);sections.Add(band);
    }
    private static XElement Band(string name,string kind,int height)=>new("section",new XAttribute("name",name),new XAttribute("kind",kind),new XAttribute("height",height),new XAttribute("group-level",1));
    private static void Formula(XElement report,string name,string expression)=>report.Element("formulas")!.Add(new XElement("formula",new XAttribute("name",name),expression));
    private static XElement Text(string name,string text,int left,int top,int width,int height,int size)
    {
        var obj=new XElement("object",new XElement("Name",name),new XElement("Kind","TextObject"),new XElement("Text",text));Place(obj,left,top,width,height);Grow(obj,size);return obj;
    }
    private static XElement Field(string name,string formula,int left,int top,int width,int height,int size)
    {
        var obj=Text(name,"",left,top,width,height,size);obj.Element("Kind")!.Value="FieldObject";obj.Element("Text")!.Remove();
        obj.Add(new XElement("source",new XAttribute("name",name),new XAttribute("formula",formula),new XAttribute("kind","FormulaField")));return obj;
    }
    private static void Place(XElement obj,int left,int top,int width,int height)
    {obj.SetElementValue("Left",left);obj.SetElementValue("Top",top);obj.SetElementValue("Width",width);obj.SetElementValue("Height",height);}
    private static void Grow(XElement obj,int size)
    {
        obj.Element("Font")?.Remove();obj.Add(new XElement("Font",new XAttribute("family","Tahoma"),new XAttribute("size",size),new XAttribute("style",0)));
        var format=obj.Element("format");if(format==null){format=new XElement("format");obj.Add(format);}
        format.SetElementValue("EnableCanGrow","true");format.SetElementValue("HorizontalAlignment","RightAlign");
    }
}
