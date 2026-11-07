using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FreeSms.Core;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;

// Called only after OriginalNavigationCheck has validated its disposable database.
internal static class OriginalWorkflowChecks
{
    private static Action<string> diagnostic = message => { };
    private static T Field<T>(Form form, string name)
    {
        var field=form.GetType().GetField(name,BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
            ?? throw new InvalidOperationException("Original workflow field was not found: "+form.GetType().Name+"."+name);
        return field.GetValue(form) is T value ? value
            : throw new InvalidOperationException("Original workflow field has an unexpected type or null value: "+form.GetType().Name+"."+name);
    }
    private static void Click(Form form, string name) => Field<UIButton>(form, name).PerformClick();
    private static void SaveGallery(Form form,string name)
    {
        Require(form.Visible && form.Width>0 && form.Height>0,"Gallery capture requires a visible populated form.");
        string directory=System.IO.Path.Combine(AppContext.BaseDirectory,"navigation-checks","docs-gallery");
        System.IO.Directory.CreateDirectory(directory);form.Refresh();form.Update();
        using var bitmap=new System.Drawing.Bitmap(form.Width,form.Height);
        form.DrawToBitmap(bitmap,new System.Drawing.Rectangle(System.Drawing.Point.Empty,bitmap.Size));
        bitmap.Save(System.IO.Path.Combine(directory,"gallery-"+name+".png"),System.Drawing.Imaging.ImageFormat.Png);
        diagnostic("CAPTURE populated original form: gallery-"+name+".png (disposable fixture data)");
    }
    private static void Require(bool condition, string message) { if (!condition) throw new InvalidOperationException(message); }
    private static void Select(Form form, int id, string field = "m_b", string key = "id")
    {
        var grid = Field<GridEX>(form, field);
        for (int i = 0; i < grid.RowCount; i++)
            if (Convert.ToInt32(grid.GetRow(i).Cells[key].Value) == id) { grid.Row = i; return; }
        throw new InvalidOperationException("Saved row was not reloaded into the original grid.");
    }
    internal static string ReportStudentName => "شاگرد آزمایشی گزارش";
    private static readonly System.Drawing.Color FirstPhotoColor=System.Drawing.Color.FromArgb(31,211,73);
    private static readonly System.Drawing.Color SecondPhotoColor=System.Drawing.Color.FromArgb(211,31,173);
    private static byte[] FixturePhoto(System.Drawing.Color color)
    {
        using var bitmap=new System.Drawing.Bitmap(16,16);
        using(var graphics=System.Drawing.Graphics.FromImage(bitmap))graphics.Clear(color);
        using var stream=new System.IO.MemoryStream();bitmap.Save(stream,System.Drawing.Imaging.ImageFormat.Png);return stream.ToArray();
    }
    internal static void PrepareReportFixture(Database db)
    {
        // The parent creates this database; it never uses OriginalRuntime's user connection.
        var school = new SchoolService(db, new Session(1410));
        school.SetYear(1410);
        school.SaveSchool(new Record { ["sch"]="مکتب آزمایشی گزارش", ["Ost"]="کابل", ["cty"]="آزمون", ["Foter1"]="مدیر آزمایشی" });
        int classroom = school.SaveClass(new Record { ["name"]="صنف آزمایشی گزارش", ["xpaye"]=1, ["fee"]=1000, ["shift"]=1, ["sortRpt"]=30000 });
        var entities = new EntityService(school);
        int book = entities.Save("books", new Record { ["xPaye"]=1, ["Name"]="مضمون آزمایشی", ["vahed"]=1, ["timeWeek"]=1, ["Type"]=1, ["sort"]=30000, ["SortOneEntry"]=30000, ["codedars"]=5991001, ["Vezarat"]=true });
        int teacher = entities.Save("teachers",new Record { ["fNamF"]="استاد", ["fNamL"]="آزمایشی", ["fEmail"]="", ["fPassword"]="" });
        school.AssignTeacher(classroom,book,teacher);
        int customExam=entities.Save("exams",new Record {["Name"]="میان‌دورهٔ آزمایشی",["NumExam"]=100,["DateFrom"]="1410/02/01",["DateTo"]="1410/02/02"});
        school.SaveStudent(new Record { ["Student_img"]=FixturePhoto(FirstPhotoColor), ["FName"]=ReportStudentName, ["LName"]=asdaj.b("پدر آزمایشی"), ["PName"]=asdaj.b("پدرکلان آزمایشی"), ["Code"]=5991001, ["NumberAsas"]=5991001, ["xPaye"]=1, ["xClass"]=classroom, ["Status"]=1, ["Jens"]=0, ["Fee1"]=1000 });
        school.SaveStudent(new Record { ["Student_img"]=FixturePhoto(SecondPhotoColor), ["FName"]="شاگرد محفوظ", ["LName"]="پدر دوم", ["PName"]="پدرکلان دوم", ["Code"]=5991002, ["NumberAsas"]=5991002, ["xPaye"]=1, ["xClass"]=classroom, ["Status"]=1, ["Jens"]=1, ["Fee1"]=700 });
        foreach (var exam in db.Query("SELECT id,term FROM tExam WHERE xYear=1410 AND term IN(0,1,2)"))
            foreach (int code in new[] {5991001,5991002})
            {
                int term = Convert.ToInt32(exam["term"]);
                double mark = code == 5991001 ? term == 0 ? 20 : term == 1 ? 30 : 40 : term == 0 ? 10 : term == 1 ? 10 : 20;
                var result = db.Call("sp_tMark_insertUpdate_FromXls_Af",new Record { ["xuser"]=1, ["code"]=code.ToString(), ["codedars"]=5991001, ["Xtest"]=exam["id"], ["xYear"]=1410, ["Mark"]=mark });
                Require(string.IsNullOrEmpty(Convert.ToString(result.Output["err"])),"Valid fixture marks were rejected by the original import procedure.");
            }
        // Calculate using the original SQL, in term order. Assert independent known totals.
        foreach (var exam in db.Query("SELECT id FROM tExam WHERE xYear=1410 AND term IN(0,1,2,3) ORDER BY term"))
        {
            db.Call("sp_Procc",new Record {["Exam"]=exam["id"]});
            db.Call("sp_CalcMarkDoreh",new Record {["Exam"]=exam["id"]});
        }
        foreach (int code in new[] {5991001,5991002})
        {
            var mark = db.Scalar("SELECT m.Mark FROM tMark m JOIN tStudent s ON s.id=m.xStudent JOIN tExam e ON e.id=m.Xtest WHERE s.Code=@p0 AND e.xYear=1410 AND e.term=3 AND m.xbook=@p1 AND m.typ=1",new object[]{code,book});
            Require(Convert.ToDecimal(mark)==(code==5991001 ? 70m : 30m),"Original final-term calculation did not equal the fixture's known sum.");
        }

        var finalExam = db.Scalar("SELECT id FROM tExam WHERE xYear=1410 AND term=3");
        var averages = db.Call("spRpt_StdListTestMark_AvgClass_AllExam",new Record {["Exam"]=Convert.ToString(finalExam),["Class"]=classroom.ToString(),["xYear"]=1410}).Sets[0];
        var finals = averages.Where(row=>Convert.ToInt32(row["Xtest"])==Convert.ToInt32(finalExam)).ToArray();
        Require(finals.Length==2 && finals.All(row=>Convert.ToDecimal(row["AvgClass"])==50m),"Original progress report did not return the known class mean of 50.");
        var custom=averages.Where(row=>Convert.ToInt32(row["Xtest"])==customExam).ToArray();
        Require(custom.Length==2 && custom.All(row=>Convert.ToDecimal(row["AvgClass"])==15m),"Original progress report did not include the additional exam with mean15.");

    }
    internal static void PreparePaymentFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1411));school.SetYear(1411);
        int classroom=school.SaveClass(new Record{["name"]="صنف آزمایشی پرداخت",["xpaye"]=1,["fee"]=1000,["shift"]=1,["sortRpt"]=30000});
        foreach(int code in new[]{5992001,5992002})
            school.SaveStudent(new Record{["FName"]=code==5992001?"شاگرد پرداخت":"شاگرد محفوظ پرداخت",["LName"]="پدر آزمایشی",["PName"]="پدرکلان آزمایشی",["Code"]=code,["NumberAsas"]=code,["xPaye"]=1,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=1000});
    }
    internal static void PrepareAttendanceFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1412));school.SetYear(1412);
        if(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent WHERE Code=5993001"))==0)
        {
            int classroom=school.SaveClass(new Record{["name"]="صنف آزمایشی حاضری",["xpaye"]=1,["fee"]=0,["shift"]=1,["sortRpt"]=30000});
            foreach(int code in new[]{5993001,5993002})
                school.SaveStudent(new Record{["FName"]=code==5993001?"شاگرد حاضری":"شاگرد محفوظ حاضری",["LName"]="پدر آزمایشی",["PName"]="پدرکلان آزمایشی",["Code"]=code,["NumberAsas"]=code,["xPaye"]=1,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=0});
            new EntityService(school).Save("year_days",new Record{["xMaghta"]=db.Scalar("SELECT xMaghta FROM tPaye WHERE id=1"),["Term1"]=100,["Term2"]=100});
        }
    }
    internal static void PrepareStudentEditFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1413));school.SetYear(1413);
        var usedOrders=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>Convert.ToInt32(row["sortRpt"])));
        int order=30000;
        foreach(var item in new[]{("صنف ثبت نام",1),("صنف انتقال",1),("صنف پایه دوم",2)})
        {
            while(usedOrders.Contains(order))order++;
            Require(order<=32767,"No available fixture class display order.");
            school.SaveClass(new Record{["name"]=item.Item1,["xpaye"]=item.Item2,["fee"]=1000,["shift"]=1,["sortRpt"]=order});
            usedOrders.Add(order++);
        }
    }
    internal static void PrepareClassFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1416));school.SetYear(1416);
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>Convert.ToInt32(row["sortRpt"])));
        int order=30000;while(used.Contains(order))order++;
        Require(order<32767,"No available class fixture display order.");
        int classroom=school.SaveClass(new Record{["name"]=asdaj.b("صنف محفوظ مدیریت"),["xpaye"]=1,["fee"]=100,["shift"]=1,["sortRpt"]=order});
        school.SaveStudent(new Record{["FName"]="شاگرد محفوظ مدیریت",["LName"]="پدر مدیریت",["Code"]=5996001,["NumberAsas"]=5996001,["xPaye"]=1,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=0});
    }
    internal static void PrepareBatchPrintFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1418));school.SetYear(1418);
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>Convert.ToInt32(row["sortRpt"])));
        int order=30000;
        foreach(int grade in new[]{1,2})
        {
            while(used.Contains(order))order++;used.Add(order);
            int classroom=school.SaveClass(new Record{["name"]="صنف چاپ گروهی "+grade,["xpaye"]=grade,["fee"]=0,["sortRpt"]=order});
            foreach(int code in grade==1?new[]{5999001,5999002}:new[]{5999003})
                school.SaveStudent(new Record{["FName"]="شاگرد چاپ گروهی "+code,["LName"]="پدر چاپ",["Code"]=code,["NumberAsas"]=code,["xPaye"]=grade,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=0});
        }
        db.Execute("DELETE FROM tmpStdforPrint WHERE xUser=1");
    }
    internal static void PrepareMarkExportFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1424));school.SetYear(1424);
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>row.Int("sortRpt")));int order=30000;
        int Classroom(string name,int grade)
        {
            while(used.Contains(order))order++;Require(order<=32767,"No free mark-export fixture class order.");used.Add(order);
            return school.SaveClass(new Record{["name"]=name,["xpaye"]=grade,["fee"]=0,["shift"]=1,["sortRpt"]=order++});
        }
        for(int index=1;index<=4;index++)
        {
            int grade=index==4?2:1;
            int classroom=Classroom(index==1?"صنف/اکسل":index==2?"صنف\\اکسل":index==3?"صنف غیرمنتخب اکسل":"صنف پایهٔ دیگر اکسل",grade);
            school.SaveStudent(new Record{["FName"]=index==1?"=1+2":"نام ' اکسل "+index,["LName"]="پدر ' اکسل",["PName"]="پدرکلان",["Code"]=6000400000L+index,["NumberAsas"]=6000400+index,["xPaye"]=grade,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=0,["Sort"]=index});
        }
        var entities=new EntityService(school);
        for(int index=1;index<=3;index++)entities.Save("books",new Record{["xPaye"]=index==3?2:1,["Name"]="مضمون ' خروجی "+index,["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30000+index,["SortOneEntry"]=30000+index,["codedars"]=6000400+index,["Vezarat"]=true});
    }
    internal static void PrepareYearTransitionFixture(Database db)
    {
        var source=new SchoolService(db,new Session(1421));source.SetYear(1421);
        var target=new SchoolService(db,new Session(1422));target.SetYear(1422);
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>row.Int("sortRpt")));int order=30000;
        int Class(SchoolService school,string name,int grade,int fee)
        {
            while(used.Contains(order))order++;Require(order<=32767,"No free transition fixture class order.");used.Add(order);
            return school.SaveClass(new Record{["name"]=name,["xpaye"]=grade,["fee"]=fee,["shift"]=1,["sortRpt"]=order++});
        }
        int from=Class(source,"صنف مبدأ انتقال سال",1,20);
        Class(source,"صنف دیگر مبدأ انتقال سال",1,30);
        Class(target,"صنف مقصد انتقال سال",2,120);
        int protectedClass=Class(target,"صنف محفوظ انتقال سال",2,300);
        new EntityService(target).Save("discounts",new Record{["name"]="تخفیف انتقال سال آزمایشی",["comment"]="دادهٔ آزمایشی"});
        int first=0;
        for(int index=1;index<=4;index++)
        {
            int student=source.SaveStudent(new Record{["FName"]="شاگرد انتقال سال "+index,["LName"]="پدر",["PName"]="پدرکلان",["Code"]=6000300+index,["NumberAsas"]=6000300+index,["xPaye"]=1,["xClass"]=from,["Status"]=index==2?2:1,["Jens"]=index%2,["Fee1"]=20,["transport1"]=5,["shaghe"]=index!=2,["hazer"]=index==2,["mali"]=true,["dakhle"]=true,["uniform"]=true,["komakdarsi"]=true,["ketab"]=true,["transport"]=true,["robotic"]=true,["maghnae"]=true,["codeTakhfif"]=700+index,["Sort"]=10+index});
            if(index==1)first=student;
            if(index==4)InsertTransitionFixtureEnrollment(db,student,protectedClass,300);
        }
        int book=new EntityService(source).Save("books",new Record{["xPaye"]=1,["Name"]="مضمون محفوظ انتقال سال",["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30000,["SortOneEntry"]=30000,["codedars"]=6000301,["Vezarat"]=true});
        int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1421 AND term=1"));
        var mark=db.Call("sp_tMark_insertUpdate_FromXls_Af",new Record{["xuser"]=1,["code"]="6000301",["codedars"]=6000301,["Xtest"]=exam,["xYear"]=1421,["Mark"]=25});
        Require(mark.Output.Text("err")=="","Source transition mark fixture was rejected.");
        db.Call("sp_Procc",new Record{["Exam"]=exam});db.Call("sp_CalcMarkDoreh",new Record{["Exam"]=exam});
        db.Call("sp_tPaymentStudent_insertFromXls",new Record{["xYear"]=1421,["xStudent"]=first,["PaynemtDate"]="1421/01/02",["dayOfWeek"]="روز آزمایشی",["Fee"]=5,["Exam"]=0,["uniform"]=0,["dakhle"]=0,["Date"]="1421/01/02-10:00:00",["xUser"]=1});
    }
    private static void InsertTransitionFixtureEnrollment(Database db,int student,int classroom,int fee)
    {
        db.Call("sp_tYear_Student_Insert",new Record{["xYear"]=1422,["xStudent"]=student,["xPaye"]=2,["xClass"]=classroom,["xTakhfif"]=0,["codeTakhfif"]=null,["Fee1"]=fee,["transport1"]=null,["shaghe"]=true,["hazer"]=true,["mali"]=true,["dakhle"]=false,["uniform"]=false,["komakdarsi"]=false,["ketab"]=false,["transport"]=false,["robotic"]=false,["maghnae"]=false});
    }
    internal static void PrepareWorkbookStudentFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1420));school.SetYear(1420);
        new EntityService(school).Save("discounts",new Record{["name"]="تخفیف آزمون ورود شاگردان اکسل",["comment"]="دادهٔ آزمایشی"});
        db.Execute("INSERT INTO tClass(xYear,xPaye,name,fee) VALUES(1420,1,@p0,777),(1421,2,@p0,888)",new object[]{"صنف ' اکسل"});
    }
    internal static void PrepareWorkbookMarkFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1419));school.SetYear(1419);
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>Convert.ToInt32(row["sortRpt"])));
        int order=30000;while(used.Contains(order))order++;
        Require(order<=32767,"No available workbook fixture class display order.");
        int classroom=school.SaveClass(new Record{["name"]="صنف آزمون ورود اکسل",["xpaye"]=1,["fee"]=0,["shift"]=1,["sortRpt"]=order});
        int book=new EntityService(school).Save("books",new Record{["xPaye"]=1,["Name"]="مضمون آزمون ورود اکسل",["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30000,["SortOneEntry"]=30000,["codedars"]=6000101,["Vezarat"]=true});
        int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1419 AND term=1"));
        foreach(int code in new[]{6000101,6000102,6000103})
        {
            int student=school.SaveStudent(new Record{["FName"]="شاگرد آزمون اکسل "+code,["LName"]="پدر",["PName"]="پدرکلان",["Code"]=code,["NumberAsas"]=code,["xPaye"]=1,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=0});
            foreach(var test in db.Query("SELECT id FROM tExam WHERE xYear=1419 AND term IN(1,2)"))
            {
                var result=db.Call("sp_tMark_insertUpdate_FromXls_Af",new Record{["xuser"]=1,["code"]=code.ToString(),["codedars"]=6000101,["Xtest"]=test["id"],["xYear"]=1419,["Mark"]=code==6000103?20:10});
                Require(string.IsNullOrEmpty(result.Output.Text("err")),"Workbook mark fixture was rejected.");
            }
            db.Execute("UPDATE tMark SET M2=7 WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,exam,book});
        }
        db.Execute("UPDATE tExam SET procc=1 WHERE xYear=1419");
    }
    internal static void PrepareMarkEntryFixture(Database db,bool bulk=false)
    {
        int year=bulk?1417:1414,firstCode=bulk?5998001:5995001;
        var school=new SchoolService(db,new Session(year));school.SetYear(year);
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>Convert.ToInt32(row["sortRpt"])));
        int order=30000;while(used.Contains(order))order++;
        Require(order<=32767,"No available mark fixture class order.");
        int classroom=school.SaveClass(new Record{["name"]=bulk?"صنف ورود گروهی نمره":"صنف ورود نمره",["xpaye"]=1,["fee"]=0,["shift"]=1,["sortRpt"]=order});
        var entities=new EntityService(school);
        int book=entities.Save("books",new Record{["xPaye"]=1,["Name"]=bulk?"مضمون ورود گروهی نمره":"مضمون ورود نمره",["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30001,["SortOneEntry"]=30001,["codedars"]=firstCode,["Vezarat"]=true});
        db.Execute("UPDATE tBook SET showOneEntry=1 WHERE id=@p0",new object[]{book});
        int secondBook=entities.Save("books",new Record{["xPaye"]=1,["Name"]=bulk?"مضمون دوم گروهی نمره":"مضمون دوم ورود نمره",["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30002,["SortOneEntry"]=30002,["codedars"]=firstCode+1,["Vezarat"]=true});
        db.Execute("UPDATE tBook SET showOneEntry=1 WHERE id=@p0",new object[]{secondBook});
        int teacher=entities.Save("teachers",new Record{["fNamF"]="استاد نمره",["fNamL"]="آزمون",["fEmail"]="",["fPassword"]=""});school.AssignTeacher(classroom,book,teacher);
        foreach(int code in new[]{firstCode,firstCode+1})
            school.SaveStudent(new Record{["FName"]=code==firstCode?"شاگرد محفوظ نمره":"شاگرد ورود نمره",["LName"]="پدر نمره",["PName"]="پدرکلان نمره",["Code"]=code,["NumberAsas"]=code,["xPaye"]=1,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=0});
        foreach(var item in new[]{(firstCode,1,10),(firstCode+1,2,15)})
        {
            int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=@p0 AND term=@p1",new object[]{year,item.Item2}));
            var result=db.Call("sp_tMark_insertUpdate_FromXls_Af",new Record{["xuser"]=1,["code"]=item.Item1.ToString(),["codedars"]=firstCode,["Xtest"]=exam,["xYear"]=year,["Mark"]=item.Item3});
            Require(string.IsNullOrEmpty(Convert.ToString(result.Output["err"])),"Mark entry fixture rejected an owned mark.");
        }
    }
    internal static void AssertReportFixture(FreeSms.NativeControls.PortableReportViewer viewer, Database database,string reportId)
    {
        var input = (FreeSms.Reports.ReportInput)typeof(FreeSms.NativeControls.PortableReportViewer).GetField("input",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(viewer);
        var expected = database.Query("SELECT id,FName FROM tStudent WHERE Code=5991001").Single();
        bool found = input != null && input.Data != null && input.Data.Tables.Cast<System.Data.DataTable>().Any(table => table.Columns.Contains("xStudent") && table.Columns.Contains("FName") && table.Rows.Cast<System.Data.DataRow>().Any(row => Convert.ToInt32(row["xStudent"]) == Convert.ToInt32(expected["id"]) && Convert.ToString(row["FName"]) == Convert.ToString(expected["FName"])));
        Require(found,"Report preview did not receive the fixture student's actual database values.");
        var model=(FreeSms.Reports.ReportModel)typeof(FreeSms.NativeControls.PortableReportViewer).GetField("model",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(viewer);
        if(model.Sections.SelectMany(section=>section.Elements("object")).Any(obj=>obj.Element("Kind")?.Value=="BlobFieldObject"))
        {
            var photo=new SchoolService(database,new Session(1410)).StudentImage(Convert.ToInt32(expected["id"]));
            Require(photo!=null && input.Data.Tables.Cast<System.Data.DataTable>().Any(table=>table.Columns.Contains("Student_img") && table.Columns.Contains("xStudent") && table.Rows.Cast<System.Data.DataRow>().Any(row=>Convert.ToInt32(row["xStudent"])==Convert.ToInt32(expected["id"]) && row["Student_img"] is byte[] bytes && bytes.SequenceEqual(photo))),"Actual report input did not preserve the selected student's persisted photo bytes.");
        }
        if(reportId!="105" && input.Subreports.TryGetValue("Sub1",out var progress))
        {
            var actual=progress.Data.Tables[0].Rows.Cast<System.Data.DataRow>().Where(row=>Convert.ToInt32(row["xStudent"])==Convert.ToInt32(expected["id"])).ToArray();
            Require(actual.Length==2 && actual.Select(row=>Convert.ToDecimal(row["MarkDoreh"])).OrderBy(value=>value).SequenceEqual(new[]{20m,70m}),"Actual progress input omitted or changed an eligible exam.");
        }
        if(reportId=="104" || reportId=="105")
        {
            void AssertMarks(FreeSms.Reports.ReportInput data,string location)
            {
                var table=data.Data.Tables.Cast<System.Data.DataTable>().FirstOrDefault(item=>item.Columns.Contains("xStudent") && item.Columns.Contains("Mark") && item.Columns.Contains("AvgClass"));
                Require(table!=null,"First-term report omitted course mark/class average at "+location);
                foreach(var student in database.Query("SELECT id,Code FROM tStudent WHERE Code IN(5991001,5991002)"))
                {
                    var rows=table.Rows.Cast<System.Data.DataRow>().Where(row=>Convert.ToInt32(row["xStudent"])==student.Int("id")).ToArray();
                    decimal mark=Convert.ToInt64(student["Code"])==5991001?30m:10m;
                    Require(rows.Length>0 && rows.All(row=>Convert.ToDecimal(row["Mark"])==mark && Convert.ToDecimal(row["AvgClass"])==20m),"First-term report changed the known student mark or class average at "+location);
                }
            }
            AssertMarks(input,"main report");
            if(reportId=="105")
            {
                Require(input.Subreports.ContainsKey("Sub1"),"Landscape first-term card omitted its configured course subreport.");
                AssertMarks(input.Subreports["Sub1"],"landscape course subreport");
            }
        }
        Require(input.Parameters.Values.Any(value => Convert.ToString(value).Contains("مکتب آزمایشی گزارش")), "Report preview did not receive the fixture school header.");
    }
    internal static void SaveReportPages(FreeSms.NativeControls.PortableReportViewer viewer, string directory, string scenario)
    {
        var document = (FreeSms.NativeControls.PortableReportDocument)typeof(FreeSms.NativeControls.PortableReportViewer).GetField("document",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(viewer);
        Require(document.PageCount>0 && document.PageCount<=20,"Small report fixture produced an invalid page count.");
        var model=(FreeSms.Reports.ReportModel)typeof(FreeSms.NativeControls.PortableReportViewer).GetField("model",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(viewer);
        bool photos=model.Sections.SelectMany(section=>section.Elements("object")).Any(obj=>obj.Element("Kind")?.Value=="BlobFieldObject");
        bool firstTerm=model.Name.Contains("CR_AF_StdKarnameDorehByChart_",StringComparison.Ordinal);
        Action verifyFirstTerm=()=>
        {
            Require(document.PageCount==2,"Two one-course original student cards must render on exactly two separate pages; actual="+document.PageCount);
            Require(document.DefaultPageSettings.Landscape==model.Name.EndsWith("_land",StringComparison.Ordinal),"First-term card changed its configured paper orientation.");
            var pages=(System.Collections.IEnumerable)document.GetType().GetField("pages",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(document);
            var identities=new List<int>();
            foreach(System.Collections.IEnumerable pageBands in pages)
            {
                var ids=new HashSet<int>();
                foreach(object band in pageBands)
                {
                    var row=band.GetType().GetField("Row",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(band) as System.Data.DataRow;
                    if(row!=null && row.Table.Columns.Contains("xStudent"))ids.Add(Convert.ToInt32(row["xStudent"]));
                }
                Require(ids.Count==1,"First-term page mixed parent card bands belonging to different students.");identities.Add(ids.Single());
            }
            Require(identities.Distinct().Count()==2,"First-term pagination omitted a student or repeated the same card.");
        };
        var singlePhotos=new List<bool>();
        int firstPhoto=0,secondPhoto=0;
        for(int page=0;page<document.PageCount;page++)
        {
            string path=System.IO.Path.Combine(directory,scenario+"-page-"+(page+1)+".png");document.SavePageImage(path,page,100);
            if(!photos)continue;
            using var bitmap=new System.Drawing.Bitmap(path);int pageFirst=0,pageSecond=0;
            for(int y=0;y<bitmap.Height;y+=4)for(int x=0;x<bitmap.Width;x+=4)
            {
                int pixel=bitmap.GetPixel(x,y).ToArgb();
                if(pixel==FirstPhotoColor.ToArgb()){firstPhoto++;pageFirst++;}
                if(pixel==SecondPhotoColor.ToArgb()){secondPhoto++;pageSecond++;}
            }
            if(firstTerm)singlePhotos.Add((pageFirst>50) != (pageSecond>50));
        }
        // Keep every rendered page as diagnostic evidence before rejecting its layout.
        if(firstTerm){verifyFirstTerm();Require(singlePhotos.Count==document.PageCount && singlePhotos.All(value=>value),"First-term page must show exactly one student's photo.");}
        if(photos)Require(firstPhoto>50 && secondPhoto>50,"Rendered report pages omitted or mixed the two students' persisted photos.");
    }
    internal static void Run(string scenario, Form form, Database db, Action<string> log)
    {
        diagnostic = log;
        if (scenario == "discount") Discount(form, db, log);
        else if (scenario == "school") School(form, db, log);
        else if (scenario == "class") ClassManagement(form,db,log);
        else if (scenario == "subject") Subject(form,db,log);
        else if (scenario == "authentication") Authentication(db,log);
        else if (scenario == "student-delete") StudentDelete(form, db, log);
        else if (scenario == "student-edit") StudentEdit(form,db,log);
        else if (scenario == "backup") Backup(form,db,log);
        else if (scenario == "teacher" || scenario == "driver") People(scenario,form,db,log);
        else if (scenario == "payment") Payment(form,db,log);
        else if (scenario == "mark-entry") MarkEntry(form,db,log);
        else if (scenario == "bulk-marks") BulkMarkEntry(form,db,log);
        else if (scenario == "batch-print-list") BatchPrintList(form,db,log);
        else if (scenario == "new-year") NewYear(form,db,log);
        else if (scenario == "mark-export") MarkExport(form,db,log);
        else if (scenario == "student-workbook" || scenario == "mark-workbook") WorkbookPreview(form,db,log,scenario=="student-workbook");
        else if (scenario == "attendance1" || scenario == "attendance2") Attendance(form,db,log);
        else throw new ArgumentException("Unknown workflow scenario: " + scenario);
    }
    private static void Discount(Form form, Database db, Action<string> log)
    {
        int before = Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif"));
        Click(form, "m_f");
        Dialog(() => Click(form, "j"), "عنوان تخفیف را وارد کنید", 1);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif")) == before, "Empty title inserted a discount.");
        log("PASS empty title validation leaves database unchanged");
        string name = asdaj.b("تخفیف آزمون " + Guid.NewGuid().ToString("N"));
        string comment = "توضیح ' آزمون ; SELECT 1 --";
        Field<Control>(form,"k").Text = name;
        Field<Control>(form,"n").Text = comment;
        Click(form, "j");
        var saved = db.Query("SELECT id,comment FROM tTakhfif WHERE name=@p0", new object[] { name }).Single();
        int id = Convert.ToInt32(saved["id"]);
        Require(Convert.ToString(saved["comment"]) == comment, "Inserted comment did not round trip exactly.");
        log("PASS actual New/Save buttons persist quoted Persian text as data");
        Select(form,id); Click(form,"m_g");
        Require(Field<Control>(form,"n").Text == comment, "Edit did not reload the saved comment.");
        comment = "اصلاح ' دوم ; --";
        Field<Control>(form,"n").Text = comment;
        Click(form,"j");
        Require(Convert.ToString(db.Scalar("SELECT comment FROM tTakhfif WHERE id=@p0", new object[] {id})) == comment, "Edited comment was not committed.");
        log("PASS actual Edit/Save buttons update the selected record");
        Click(form,"m_f"); Field<Control>(form,"k").Text = "ذخیره نشود"; Click(form,"p");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif")) == before + 1, "Cancel modified the database.");
        log("PASS New/Cancel leaves database unchanged");
        Select(form,id);
        Dialog(() => Click(form,"m_e"), "آيا از حذف تخفیف مطمئن هستيد؟", 7);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif WHERE id=@p0", new object[] {id})) == 1, "Declining deletion removed the row.");
        Dialog(() => Click(form,"m_e"), "آيا از حذف تخفیف مطمئن هستيد؟", 6);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tTakhfif")) == before, "Confirmed deletion did not remove exactly the new record.");
        log("PASS deletion respects No/Yes and removes only the selected record");
    }
    private static void StudentEdit(Form form,Database db,Action<string> log)
    {
        int classroom=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1413 AND name=N'صنف ثبت نام'"));
        int moved=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1413 AND name=N'صنف انتقال'"));
        int nextGrade=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1413 AND name=N'صنف پایه دوم'"));
        int before=Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent"));
        string folder=System.IO.Path.Combine(System.IO.Path.GetTempPath(),"FreeSmsStudentUi_"+Guid.NewGuid().ToString("N"));System.IO.Directory.CreateDirectory(folder);
        string photo=System.IO.Path.Combine(folder,"عکس شاگرد.png");byte[] bytes=FixturePhoto(FirstPhotoColor);System.IO.File.WriteAllBytes(photo,bytes);
        void Fill(Form child,int code,int number)
        {
            Field<Control>(child,"m_w").Text="شاگرد ثبت نام";Field<Control>(child,"m_u").Text="پدر ثبت نام";Field<Control>(child,"m_s").Text="پدرکلان ثبت نام";
            Field<Control>(child,"m_q").Text=code.ToString();Field<Control>(child,"m_ae").Text=number.ToString();
            Field<UIComboBox>(child,"a4").SelectedValue="1";Field<UIComboBox>(child,"m_d").SelectedValue=classroom.ToString();Field<UIComboBox>(child,"m_y").SelectedValue="0";
            Field<Control>(child,"az").Text="1413/01/01";Field<Control>(child,"cd").Text="";
            for(int index=1;index<=9;index++)
            {child.Controls.Find("txtFee"+index,true).Single().Text="0";child.Controls.Find("txttransport"+index,true).Single().Text="0";}
            child.Controls.Find("txtFee1",true).Single().Text="100";child.Controls.Find("txtFee2",true).Single().Text="200";
            child.Controls.Find("txttransport1",true).Single().Text="25";child.Controls.Find("txttransport2",true).Single().Text="30";
        }
        void EditSave(Form child)
        {
            bool next=Field<UIComboBox>(child,"ce").Items.Count>0 && Field<UIButton>(child,"cg").Enabled;
            Dialog(()=>Click(child,"m_e"),next?"اطلاعات اصلاح شد . آیا مایل هستید نفر بعدی نمایش داده شود":"اطلاعات اصلاح شد",next?7:1);
        }
        try
        {
            ChildForm<asdat>(()=>Click(form,"m_h"),child=>
            {
                Dialog(()=>Click(child,"m_e"),"نام را وارد کنید",1);
                Fill(child,5994001,5994001);
                Require(Field<Control>(child,"cd").Text=="","Optional birth date contains mask literals.");
                Field<Control>(child,"b7").Text="-1";
                Dialog(()=>Click(child,"m_e"),"ثبت معلومات شاگرد انجام نشد:\nمقدار عددی خارج از محدودهٔ مجاز است.",1);
                Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent"))==before,"Rejected fee inserted a partial student.");
                Field<Control>(child,"b7").Text="100";
                typeof(asdat).GetField("m_b",BindingFlags.Instance|BindingFlags.NonPublic).SetValue(child,photo);
                using(var connection=db.Open())
                using(var transaction=connection.BeginTransaction())
                {
                    using var command=connection.CreateCommand();command.Transaction=transaction;
                    command.CommandText="UPDATE tClass SET fee=fee+1 WHERE id=@id";command.Parameters.AddWithValue("@id",classroom);command.ExecuteNonQuery();
                    bool heartbeat=false;using var release=new Timer{Interval=350};
                    release.Tick+=(sender,args)=>{release.Stop();transaction.Rollback();heartbeat=true;};release.Start();
                    Dialog(()=>Click(child,"m_e"),"ثبت شد",1);Require(heartbeat,"Student registration blocked the UI while SQL waited.");
                }
            });
            var saved=db.Query("SELECT s.id,s.Jens,s.bDate,y.SumFee,y.Sumtransport,y.xClass FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id WHERE s.Code=5994001 AND y.xYear=1413").Single();
            int id=saved.Int("id");
            Require(saved.Int("Jens")==0 && saved.Int("SumFee")==300 && saved.Int("Sumtransport")==55 && saved.Int("xClass")==classroom && string.IsNullOrEmpty(saved.Text("bDate")),"Original registration did not preserve zero gender, optional date and exact fee totals.");
            Require(new SchoolService(db,new Session(1413)).StudentImage(id)?.SequenceEqual(bytes)==true,"Original registration did not save the selected photo.");
            foreach(bool duplicateCode in new[]{true,false})
                ChildForm<asdat>(()=>Click(form,"m_h"),child=>
                {
                    Fill(child,duplicateCode?5994001:5994002,duplicateCode?5994002:5994001);
                    Dialog(()=>Click(child,"m_e"),duplicateCode?"کد متعلم تکراری است":"نمبر اساس تکراری است",1);
                    Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent"))==before+1,"Duplicate identity inserted a partial student.");
                });
            ChildForm<asdat>(()=>Click(form,"m_h"),child=>{Fill(child,5994002,5994002);Click(child,"m_g");});
            Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent"))==before+1,"Cancel registered a student.");
            Select(form,id,"av");SaveGallery(form,"students");
            ChildForm<asdat>(()=>Click(form,"v"),child=>
            {
                Require(Field<Control>(child,"m_w").Text==asdaj.b("شاگرد ثبت نام"),"Edit did not reload the saved student.");
                SaveGallery(child,"student-edit");
                Field<UIComboBox>(child,"m_d").SelectedValue=moved.ToString();
                // The recovered class selector applies the new class fee template.
                // Enter the intended monthly amounts after that selection.
                for(int month=1;month<=9;month++)child.Controls.Find("txtFee"+month,true).Single().Text="0";
                Field<Control>(child,"b7").Text="100";Field<Control>(child,"b4").Text="250";
                log("EDIT INPUT id="+((asdat)child).__field_a+" class="+Field<UIComboBox>(child,"m_d").SelectedValue+" fee1="+Field<Control>(child,"b7").Text+" fee2="+Field<Control>(child,"b4").Text);
                EditSave(child);
            });
            var edited=db.Query("SELECT xClass,Fee1,Fee2,SumFee FROM tYear_Student WHERE xStudent=@p0 AND xYear=1413",new object[]{id}).Single();
            Require(edited.Int("xClass")==moved && edited.Int("SumFee")==350,"Edit/class move changed the wrong record or totals: class="+edited["xClass"]+" expected="+moved+" fee1="+edited["Fee1"]+" fee2="+edited["Fee2"]+" total="+edited["SumFee"]);
            var school=new SchoolService(db,new Session(1413));var entities=new EntityService(school);
            int book=entities.Save("books",new Record{["xPaye"]=1,["Name"]="مضمون انتقال",["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30000,["SortOneEntry"]=30000,["codedars"]=5994001,["Vezarat"]=true});
            int teacher=entities.Save("teachers",new Record{["fNamF"]="استاد انتقال",["fNamL"]="آزمون",["fEmail"]="",["fPassword"]=""});school.AssignTeacher(moved,book,teacher);
            int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1413 AND term=1"));
            var mark=db.Call("sp_tMark_insertUpdate_FromXls_Af",new Record{["xuser"]=1,["code"]="5994001",["codedars"]=5994001,["Xtest"]=exam,["xYear"]=1413,["Mark"]=25});Require(string.IsNullOrEmpty(Convert.ToString(mark.Output["err"])),"Student grade-change fixture mark was rejected.");
            db.Call("sp_Procc",new Record{["Exam"]=exam});db.Call("sp_CalcMarkDoreh",new Record{["Exam"]=exam});
            int oldTotals=Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMarkDoreh WHERE xStudent=@p0 AND Xtest=@p1",new object[]{id,exam}));Require(oldTotals>0,"Grade-change fixture did not create persisted calculated marks.");
            int peerMarks=Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMark WHERE xStudent<>@p0",new object[]{id}));
            db.Execute("UPDATE tExam SET procc=1 WHERE id=@p0",new object[]{exam});
            db.Execute("CREATE TRIGGER native_reject_student_photo ON tStudentImg AFTER INSERT,UPDATE AS THROW 51000,'native student photo rejection',1");
            try
            {
                Select(form,id,"av");
                ChildForm<asdat>(()=>Click(form,"v"),child=>
                {
                    Field<UIComboBox>(child,"a4").SelectedValue="2";Field<UIComboBox>(child,"m_d").SelectedValue=nextGrade.ToString();
                    typeof(asdat).GetField("m_b",BindingFlags.Instance|BindingFlags.NonPublic).SetValue(child,photo);
                    Dialog(()=>Dialog(()=>Click(child,"m_e"),"با اصلاح پایه شاگرد نمرات قبلی شاگرد در این سال حذف میشود\nآیا مطمئن هستید؟",6),"ثبت معلومات شاگرد انجام نشد:",1,"native student photo rejection");
                });
            }
            finally{db.Execute("DROP TRIGGER native_reject_student_photo");}
            Require(Convert.ToInt32(db.Scalar("SELECT xClass FROM tYear_Student WHERE xStudent=@p0 AND xYear=1413",new object[]{id}))==moved,"Late photo failure committed the grade/class change.");
            Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND Mark=25",new object[]{id,exam}))==1 && Convert.ToInt32(db.Scalar("SELECT procc FROM tExam WHERE id=@p0",new object[]{exam}))==1,"Failed save removed marks or changed calculation flags.");
            Require(school.StudentImage(id)?.SequenceEqual(bytes)==true,"Failed save changed the prior photo.");
            Require(Convert.ToInt32(db.Scalar("SELECT SumFee FROM tYear_Student WHERE xStudent=@p0 AND xYear=1413",new object[]{id}))==350 && Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMarkDoreh WHERE xStudent=@p0 AND Xtest=@p1",new object[]{id,exam}))==oldTotals,"Failed save changed fee totals or calculated marks.");
            Select(form,id,"av");
            ChildForm<asdat>(()=>Click(form,"v"),child=>
            {
                Field<UIComboBox>(child,"a4").SelectedValue="2";Field<UIComboBox>(child,"m_d").SelectedValue=nextGrade.ToString();
                Dialog(()=>EditSave(child),"با اصلاح پایه شاگرد نمرات قبلی شاگرد در این سال حذف میشود\nآیا مطمئن هستید؟",6);
            });
            Require(Convert.ToInt32(db.Scalar("SELECT xClass FROM tYear_Student WHERE xStudent=@p0 AND xYear=1413",new object[]{id}))==nextGrade && Convert.ToInt32(db.Scalar("SELECT xPaye FROM tYear_Student WHERE xStudent=@p0 AND xYear=1413",new object[]{id}))==2,"Confirmed grade change did not commit the selected enrolment.");
            Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMark WHERE xStudent=@p0 AND Xtest=@p1",new object[]{id,exam}))==0 && Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMarkDoreh WHERE xStudent=@p0 AND Xtest=@p1",new object[]{id,exam}))==0,"Confirmed grade change left the old grade's marks behind.");
            Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMark WHERE xStudent<>@p0",new object[]{id}))==peerMarks && school.StudentImage(id)?.SequenceEqual(bytes)==true,"Grade change removed unrelated marks or the saved photo.");
            log("PASS original student registration/edit buttons validate required identity/fees, preserve zero gender and empty dates, commit exact totals/photo, reject duplicates, cancel safely, move classes and roll back grade/mark/photo changes on late SQL rejection");
        }
        finally{System.IO.Directory.Delete(folder,true);}
    }
    private static void EditGridCell(GridEX grid,int row,string key,string value)
    {
        var view=grid.Controls.OfType<DataGridView>().Single();
        view.CurrentCell=view.Rows[row].Cells[key];
        Require(view.BeginEdit(true),"Grid cell did not enter edit mode: "+key);
        Require(view.EditingControl is TextBox,"Grid did not open a text editor.");
        ((TextBox)view.EditingControl).Text=value;
        Require(grid.TryEndEdit(),"Grid rejected a valid input: "+key);
    }
    private static void Subject(Form form,Database db,Action<string> log)
    {
        int Count()=>Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tBook"));
        int before=Count();string name=OriginalText.Normalize("مضمون ' آزمایشی");
        Click(form,"w");Field<UIComboBox>(form,"n").SelectedValue="1";
        Dialog(()=>Click(form,"s"),"نام درس را وارد کنيد",1);
        Field<Control>(form,"t").Text=name;Field<Control>(form,"ad").Text="1";Field<Control>(form,"ac").Text="1";
        Field<Control>(form,"z").Text="30000";Field<Control>(form,"ae").Text="5997001";
        Field<CheckBox>(form,"ag").Checked=true;Click(form,"s");
        var saved=db.Query("SELECT id,Name,CodeDars,Vezarat FROM tBook WHERE xPaye=1 AND CodeDars=5997001").Single();int id=saved.Int("id");
        Require(Count()==before+1 && saved.Text("Name")==name && Convert.ToBoolean(saved["Vezarat"]),"Subject Save did not preserve the quoted name/code/ministry flag.");
        Click(form,"r");
        void Search(string text)
        {
            var input=Field<Control>(form,"m_i");input.Text=text;
            typeof(Control).GetMethod("OnKeyUp",BindingFlags.Instance|BindingFlags.NonPublic).Invoke(input,new object[]{new KeyEventArgs(Keys.A)});
        }
        Search("'");
        Select(form,id,"y");
        var subjects=Field<GridEX>(form,"y");
        Require(Enumerable.Range(0,subjects.RowCount).All(index=>Convert.ToString(subjects.GetRow(index).Cells["Name"].Value).Contains("'")),"Selecting a grade discarded the subject-name filter.");
        Search("' AND 1=0 --");
        Require(Field<GridEX>(form,"y").RowCount==0,"Subject search failed to combine name punctuation with the selected grade.");
        Search("");Select(form,id,"y");Click(form,"x");
        Require(Field<Control>(form,"t").Text==name && !Field<UIComboBox>(form,"n").Enabled,"Subject Edit did not reload the selected name and preserve its grade.");
        string edited=OriginalText.Normalize("اصلاح ' مضمون");Field<Control>(form,"t").Text=edited;Click(form,"s");
        Require(Count()==before+1 && Convert.ToString(db.Scalar("SELECT Name FROM tBook WHERE id=@p0",new object[]{id}))==edited,"Subject Edit did not update the selected identity.");
        Select(form,id,"y");Click(form,"x");Field<Control>(form,"t").Text="لغو";Click(form,"r");
        Require(Convert.ToString(db.Scalar("SELECT Name FROM tBook WHERE id=@p0",new object[]{id}))==edited,"Subject Cancel changed saved data.");
        Click(form,"w");Field<UIComboBox>(form,"n").SelectedValue="1";Field<Control>(form,"t").Text=edited;
        Field<Control>(form,"ad").Text="1";Field<Control>(form,"ac").Text="1";Field<Control>(form,"z").Text="30001";Field<Control>(form,"ae").Text="5997002";
        Dialog(()=>Click(form,"s"),"نام درس را تکراری می باشد",1);Require(Count()==before+1,"Duplicate subject name inserted another row.");
        Field<Control>(form,"t").Text="مضمون متفاوت";Field<Control>(form,"ae").Text="5997001";
        Dialog(()=>Click(form,"s"),"کد درس را تکراری می باشد",1);Click(form,"r");
        Select(form,id,"y");Dialog(()=>Click(form,"v"),"آیا از حذف درس اطمینان دارید",7);
        Require(Count()==before+1,"Declining subject deletion removed the row.");
        Dialog(()=>Click(form,"v"),"آیا از حذف درس اطمینان دارید",6);
        Require(Count()==before && db.Scalar("SELECT id FROM tBook WHERE id=@p0",new object[]{id})==null,"Confirmed subject deletion did not remove only its own row.");
        log("PASS original subject required-name/quoted Save/Edit/Cancel/duplicate-name/duplicate-code/search/delete-confirmation workflow preserves identity, grade and unrelated subjects");
        Click(form,"j");
    }
    private static void ClassManagement(Form form,Database db,Action<string> log)
    {
        var peerRecord=db.Query("SELECT id,sortRpt FROM tClass WHERE xYear=1416 AND name=@p0",new object[]{Values.Text("صنف محفوظ مدیریت")}).Single();
        int peer=peerRecord.Int("id"),peerOrder=peerRecord.Int("sortRpt");
        Require(peer>0,"Class fixture did not return a persisted peer identity.");
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>Convert.ToInt32(row["sortRpt"])));
        int order=30000;while(used.Contains(order))order++;
        Require(order<=32767,"No available class entry order.");
        int Count()=>Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tClass WHERE xYear=1416"));
        int before=Count();
        Click(form,"m_g");Field<UIComboBox>(form,"r").SelectedValue="1";
        Dialog(()=>Click(form,"k"),"عنوان صنف را وارد کنید",1);
        Field<Control>(form,"m").Text="صنف مدیریت آزمایشی";
        Dialog(()=>Click(form,"k"),"نگران را وارد کنید",1);
        Field<Control>(form,"w").Text="نگران آزمایشی";Field<UIComboBox>(form,"aa").SelectedValue="1";
        Field<Control>(form,"ab").Text=order.ToString();
        foreach(string invalid in new[]{"-1","1.5","2147483648"})
        {
            Field<Control>(form,"ad").Text=invalid;Dialog(()=>Click(form,"k"),"مبلغ باید عدد صحیح غیرمنفی باشد",1);
            Require(Count()==before,"Invalid class fee inserted a class.");
        }
        Field<Control>(form,"ad").Text="۱۵۰";
        foreach(string invalid in new[]{"-1","1.5","32768"})
        {
            Field<Control>(form,"ab").Text=invalid;Dialog(()=>Click(form,"k"),"شماره باید عدد صحیح بین ۰ و ۳۲۷۶۷ باشد",1);
            Require(Count()==before,"Invalid class display order inserted a class.");
        }
        Field<Control>(form,"ab").Text=order.ToString();Click(form,"k");
        var row=db.Query("SELECT id,fee,answerable FROM tClass WHERE xYear=1416 AND name=@p0",new object[]{asdaj.b("صنف مدیریت آزمایشی")}).Single();int id=row.Int("id");
        Require(Count()==before+1 && row.Int("fee")==150 && row.Text("answerable")==asdaj.b("نگران آزمایشی"),"Class Save did not preserve normalized fee and supervisor.");
        Select(form,id,"m_c");Click(form,"m_h");Require(Field<Control>(form,"ad").Text=="150","Class Edit did not reload the fee.");SaveGallery(form,"class");
        Field<Control>(form,"ad").Text="200";Click(form,"n");
        Require(Convert.ToInt32(db.Scalar("SELECT fee FROM tClass WHERE id=@p0",new object[]{id}))==150,"Class Cancel changed the saved fee.");
        Select(form,id,"m_c");Click(form,"m_h");Field<Control>(form,"ad").Text="200";Click(form,"k");
        Require(Convert.ToInt32(db.Scalar("SELECT fee FROM tClass WHERE id=@p0",new object[]{id}))==200 && Count()==before+1,"Class Edit did not update exactly one class.");
        Click(form,"m_g");Require(Field<Control>(form,"w").Text=="" && Field<Control>(form,"ad").Text=="0" && Field<Control>(form,"ab").Text=="","New class retained previous class details.");
        int duplicateNameOrder=order+1;while(used.Contains(duplicateNameOrder))duplicateNameOrder++;
        Require(duplicateNameOrder<=32767,"No free display order to isolate duplicate-name validation.");
        Field<Control>(form,"m").Text="صنف محفوظ مدیریت";Field<Control>(form,"w").Text="نگران";Field<Control>(form,"ab").Text=duplicateNameOrder.ToString();
        Dialog(()=>Click(form,"k"),"عنوان صنف تکراری است",1);
        Field<Control>(form,"m").Text="صنف شماره تکراری";Field<Control>(form,"ab").Text=peerOrder.ToString();
        log("CLASS duplicate order input="+Field<Control>(form,"ab").Text+" year="+Field<Control>(form,"af").Text+" peer="+peer+" stored="+db.Scalar("SELECT sortRpt FROM tClass WHERE id=@p0",new object[]{peer}));
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tClass WHERE xYear=1416 AND sortRpt=@p0",new object[]{peerOrder}))>0,"Duplicate-order fixture no longer has an existing matching class.");
        Dialog(()=>Click(form,"k"),"شماره تکراری است",1);Click(form,"n");
        Require(Count()==before+1,"Duplicate class validation inserted a record.");
        Select(form,peer,"m_c");Dialog(()=>Click(form,"m_f"),"تعداد 1 شاگرد در این صنف وجود دارد.امکان حذف وجود ندارد",1);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tClass WHERE id=@p0",new object[]{peer}))==1,"Occupied class was removed.");
        var school=new SchoolService(db,new Session(1416));var entities=new EntityService(school);
        int book=entities.Save("books",new Record{["xPaye"]=1,["Name"]="مضمون مدیریت صنف",["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30002,["SortOneEntry"]=30002,["codedars"]=5996001,["Vezarat"]=true});
        int teacher=entities.Save("teachers",new Record{["fNamF"]="استاد مدیریت صنف",["fNamL"]="آزمون",["fEmail"]="",["fPassword"]=""});school.AssignTeacher(id,book,teacher);
        Select(form,id,"m_c");
        Dialog(()=>Dialog(()=>Click(form,"m_f"),"آيا از حذف صنف مطمئن هستيد؟",6),"این صنف ارتباط معلم و مضمون دارد؛ ابتدا ارتباط‌ها را حذف کنید.",1);
        Require(Count()==before+1 && school.TeacherAssignments(id).Single().Int("xTch")==teacher,"Rejected class deletion changed the class or teacher assignment.");
        school.UnassignTeacher(id,book);
        Dialog(()=>Click(form,"m_f"),"آيا از حذف صنف مطمئن هستيد؟",7);Require(Count()==before+1,"Declining class deletion removed a class.");
        Dialog(()=>Click(form,"m_f"),"آيا از حذف صنف مطمئن هستيد؟",6);Require(Count()==before,"Confirmed class deletion did not remove exactly the selected empty class.");
        Click(form,"j");log("PASS original class buttons validate fees/orders and duplicates, save Persian digits, edit/cancel, clear New fields, preserve occupied classes and respect deletion confirmation");
    }
    private static void Authentication(Database db,Action<string> log)
    {
        var original=db.Query("SELECT pwd,pw FROM tuser WHERE id=1").Single();
        const string first="Native-login-test-1415",second="Native-login-changed-1415";
        string beforeUser=asdaj.l,beforePermissions=asdaj.m,beforeGrades=asdaj.n;
        int temporaryUser=0;
        void Open(Action<Form> exercise,string user="1")
        {
            ChildForm<asda3>(()=>{using var login=new asda3();login.ShowDialog();},child=>
            {Field<UIComboBox>(child,"m_e").SelectedValue=user;exercise(child);});
        }
        try
        {
            db.Execute("UPDATE tuser SET pwd=@p0,pw=398 WHERE id=1",new object[]{asdab.d("1kbr63"+first)});
            asdaj.l="";
            Open(child=>
            {
                foreach(string wrong in new[]{"", "wrong-password", "arya13880307zx"})
                {
                    Field<Control>(child,"m_f").Text=wrong;
                    Dialog(()=>Click(child,"m_c"),"کلمه عبور اشتباه است",1);
                    Require(child.Visible && asdaj.l=="","Rejected password authenticated a session.");
                }
                Dialog(()=>Click(child,"p"),"کلمه عبور اشتباه است",1);
                Require(!Field<Control>(child,"i").Visible,"Incorrect password opened password editing.");
                Field<Control>(child,"m_f").Text=first;Click(child,"p");
                Require(Field<Control>(child,"i").Visible,"Correct password did not open password editing.");
                Field<Control>(child,"k").Text=second;Field<Control>(child,"j").Text="mismatch";
                Dialog(()=>Click(child,"o"),"رمز عبور را با دقت وارد کنید",1);
                Require(Convert.ToString(db.Scalar("SELECT pwd FROM tuser WHERE id=1"))==asdab.d("1kbr63"+first),"Mismatched password confirmation changed the account.");
                Field<Control>(child,"j").Text=second;
                Dialog(()=>Click(child,"o"),"آيا از تغییر کلمه عبور مطمئن هستيد؟",7);
                Require(Convert.ToString(db.Scalar("SELECT pwd FROM tuser WHERE id=1"))==asdab.d("1kbr63"+first),"Declining password change changed the account.");
                Dialog(()=>Dialog(()=>Click(child,"o"),"آيا از تغییر کلمه عبور مطمئن هستيد؟",6),"تغییر ثبت شد",1);
                Require(Convert.ToString(db.Scalar("SELECT pwd FROM tuser WHERE id=1"))==asdab.d("1kbr63"+second),"Confirmed password change was not stored.");
            });
            Open(child=>
            {
                Field<Control>(child,"m_f").Text=first;Dialog(()=>Click(child,"m_c"),"کلمه عبور اشتباه است",1);
                Field<Control>(child,"m_f").Text=second;Click(child,"m_c");
                Require(asdaj.l=="1" && child.DialogResult!=DialogResult.None,"New password did not authenticate and request closure of the selected account login: user="+asdaj.l+" dialog="+child.DialogResult);
            });
            temporaryUser=Convert.ToInt32(db.Scalar("SELECT ISNULL(MAX(id),1)+1 FROM tuser"));
            string user=temporaryUser.ToString(),prefix=user+"kbr63";
            db.Execute("INSERT INTO tuser(id,uid,pwd,pw,per,xPaye) VALUES(@p0,@p1,@p2,398,@p3,@p4)",new object[]{temporaryUser,"native limited user",asdab.d(prefix+first),asdab.d(prefix+",1,"),asdab.d(prefix+",1,")});
            asdaj.l="";
            Open(child=>
            {
                Field<Control>(child,"m_f").Text=first;Click(child,"m_c");
                Require(asdaj.l==user && child.DialogResult!=DialogResult.None,"Limited account did not authenticate and request login closure.");
            },user);
            Require(asdaj.a("1") && !asdaj.a("2") && !asdaj.a("3") && asdaj.n=="1","Limited login did not load exact section/grade permissions.");
            ChildForm<asdc>(()=>{using var allowed=new asdc();allowed.ShowDialog();},allowed=>
                Require(Field<Control>(allowed,"af").Text==asdaj.__field_a,"Permitted class form did not initialize for the selected year."));
            // Exercise every recovered guarded form outside this account's
            // section 1, not just one representative registration window.
            db.Execute("INSERT INTO tmpStdforPrint(id,xUser) VALUES(5997999,@p0)",new object[]{temporaryUser});
            string settingsBefore=System.Text.Json.JsonSerializer.Serialize(db.Query("SELECT * FROM tParmetr"));
            var deniedForms=new Type[]{typeof(asda0),typeof(asda1),typeof(asda2),typeof(asda5),typeof(asda6),typeof(asdae),typeof(asdah),typeof(asdai),typeof(asdak),typeof(asdam),typeof(asdap),typeof(asdaq),typeof(asdar),typeof(asdat),typeof(asdau),typeof(asdaz),typeof(asdb),typeof(asdb1),typeof(asdb2),typeof(asdb5),typeof(asdb7),typeof(asdb8),typeof(asdba),typeof(asdbd),typeof(asdbf),typeof(asdbh),typeof(asdbj),typeof(asdbo),typeof(asdbr),typeof(asdbs),typeof(asdbw),typeof(asdby),typeof(asdf),typeof(asdg),typeof(asdk),typeof(asdm),typeof(asdp),typeof(asdt),typeof(asdv),typeof(asdx)};
            foreach(var deniedType in deniedForms)
            {
                log("VERIFY limited account denied form: "+deniedType.Name);
                using var denied=(Form)Activator.CreateInstance(deniedType);
                Dialog(()=>denied.ShowDialog(),"شما مجوز ورود به این بخش را ندارید",1);
                Require(!denied.Visible && asdaj.l==user && asdaj.n=="1" && !asdaj.a("3"),"Denied form changed the authenticated session or remained open: "+deniedType.Name);
                Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tmpStdforPrint WHERE id=5997999 AND xUser=@p0",new object[]{temporaryUser}))==1
                    && System.Text.Json.JsonSerializer.Serialize(db.Query("SELECT * FROM tParmetr"))==settingsBefore,"Denied form changed the user's print selection or report settings: "+deniedType.Name);
            }
            log("PASS all40 recovered guarded forms outside section1 reject the limited authenticated account before entry");
            Require(asdaj.l==user,"Denied section changed the logged-in account.");
            db.Execute("UPDATE tuser SET per=@p0 WHERE id=@p1",new object[]{asdab.d(prefix),temporaryUser});
            asdaj.l="";
            Open(child=>
            {
                Field<Control>(child,"m_f").Text=first;
                Dialog(()=>Click(child,"m_c"),"شما مجوزی برای ورود به برنامه ندارید\n\nباید برای شما مجوز صادر کند admin کاربر\n\nبرای این کار باید از منوی مدیریت کاربران و دکمه مجوز ها اقدام شود",1);
                Require(asdaj.l=="" && child.DialogResult==DialogResult.None,"An account without section permissions was logged in.");
            },user);
            db.Execute("UPDATE tuser SET per=@p0,xPaye=@p1 WHERE id=@p2",new object[]{asdab.d(prefix+",1,"),asdab.d(prefix+",,"),temporaryUser});
            Open(child=>
            {
                Field<Control>(child,"m_f").Text=first;
                Dialog(()=>Click(child,"m_c"),"برای شما در قسمت مجوزها هیچ صنفی انتخاب نشده است\n\nباید برای شما مجوز صنف های مورد نیاز را صادر کند admin کاربر\n\nبرای این کار باید از منوی مدیریت کاربران و دکمه مجوز ها اقدام شود",1);
                Require(asdaj.l=="" && child.DialogResult==DialogResult.None,"An account without grade permissions was logged in.");
            },user);
            const string invalidAccount="معلومات ذخیره‌شدهٔ حساب معتبر نیست؛ با مدیر برنامه تماس بگیرید.";
            foreach(string damaged in new[]{"pwd","per","xPaye"})
            {
                db.Execute("UPDATE tuser SET pwd=@p0,per=@p1,xPaye=@p2 WHERE id=@p3",new object[]{damaged=="pwd"?"not encoded":asdab.d(prefix+first),damaged=="per"?"not encoded":asdab.d(prefix+",1,"),damaged=="xPaye"?"not encoded":asdab.d(prefix+",1,"),temporaryUser});
                asdaj.l="";asdaj.m=",2,";asdaj.n="2";
                Open(child=>
                {
                    Field<Control>(child,"m_f").Text=first;
                    Dialog(()=>Click(child,"m_c"),invalidAccount,1);
                    Require(asdaj.l=="" && child.DialogResult==DialogResult.None && asdaj.m==",2," && asdaj.n=="2","Damaged "+damaged+" authenticated a session or left partially loaded permissions.");
                    Dialog(()=>Click(child,"p"),invalidAccount,1);
                    Require(!Field<Control>(child,"i").Visible,"Damaged account opened password editing.");
                },user);
            }
            db.Execute("UPDATE tuser SET pwd=@p0,per=@p1,xPaye=@p2 WHERE id=@p3",new object[]{asdab.d(prefix+first),asdab.d(prefix+",1,"),asdab.d(prefix+",1,"),temporaryUser});
            Open(child=>
            {
                Field<Control>(child,"m_f").Text=first;Click(child,"m_c");
                Require(asdaj.l==user && child.DialogResult!=DialogResult.None && asdaj.a("1") && !asdaj.a("2") && asdaj.n=="1","Corrected account did not recover after invalid account data.");
            },user);
            asdaj.l="";
            Open(child=>
            {
                db.Execute("DELETE FROM tuser WHERE id=@p0",new object[]{temporaryUser});
                Field<Control>(child,"m_f").Text=first;Dialog(()=>Click(child,"m_c"),invalidAccount,1);
                Require(asdaj.l=="" && child.DialogResult==DialogResult.None,"A deleted selected account authenticated a session.");
            },user);
            log("PASS original login rejects incorrect/override credentials, changes passwords safely, enforces limited section/grade access, rejects malformed/deleted accounts without partial permission changes and recovers with valid account data");
        }
        finally
        {
            if(temporaryUser>0)
            {
                db.Execute("DELETE FROM tmpStdforPrint WHERE xUser=@p0",new object[]{temporaryUser});
                db.Execute("DELETE FROM tuser WHERE id=@p0",new object[]{temporaryUser});
            }
            db.Execute("UPDATE tuser SET pwd=@p0,pw=@p1 WHERE id=1",new object[]{original["pwd"],original["pw"]});
            asdaj.l=beforeUser;asdaj.m=beforePermissions;asdaj.n=beforeGrades;
        }
    }
    private static void RequireReachable(Form form, Control target)
    {
        Require(target.Visible && target.Enabled && target.Width > 0 && target.Height > 0, "Original control is unavailable: "+target.Name);
        var point=target.PointToScreen(new System.Drawing.Point(target.Width/2,target.Height/2));
        Control hit=form;
        while(true)
        {
            var child=hit.GetChildAtPoint(hit.PointToClient(point),GetChildAtPointSkip.Invisible);
            if(child==null)break;hit=child;
        }
        while(hit!=null && hit!=target)hit=hit.Parent;
        Require(hit==target,"Original control is covered or outside the form: "+target.Name);
    }
    private static void MarkExport(Form form,Database db,Action<string> log)
    {
        int first=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1424 AND name=@p0",new object[]{"صنف/اکسل"}));
        int second=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1424 AND name=@p0",new object[]{"صنف\\اکسل"}));
        int book1=Convert.ToInt32(db.Scalar("SELECT id FROM tBook WHERE codeDars=6000401")),book2=Convert.ToInt32(db.Scalar("SELECT id FROM tBook WHERE codeDars=6000402"));
        Field<UIComboBox>(form,"i").SelectedValue="1";
        var classes=Field<GridEX>(form,"j");var books=Field<GridEX>(form,"m_d");
        string snapshot=System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT * FROM tStudent ORDER BY id"),db.Query("SELECT * FROM tYear_Student ORDER BY id"),db.Query("SELECT * FROM tMark ORDER BY id"),db.Query("SELECT * FROM tExam ORDER BY id")});
        string directory=System.IO.Path.Combine(System.IO.Path.GetTempPath(),"FreeSMS ' اکسل "+Guid.NewGuid().ToString("N"));System.IO.Directory.CreateDirectory(directory);
        var nativeClasses=classes.Controls.OfType<DataGridView>().Single();var nativeBooks=books.Controls.OfType<DataGridView>().Single();
        nativeClasses.DataError+=(s,e)=>{diagnostic("FAILED export class grid: "+e.Exception);e.ThrowException=true;};
        nativeBooks.DataError+=(s,e)=>{diagnostic("FAILED export subject grid: "+e.Exception);e.ThrowException=true;};
        void Checked(GridEX grid,int id){for(int index=0;index<grid.RowCount;index++)if(Convert.ToInt32(grid.GetRow(index).Cells["id"].Value)==id){grid.GetRow(index).Cells[0].Value=true;return;}throw new Exception("Export fixture not found in actual selector.");}
        void Save()=>Dialog(()=>Click(form,"g"),"پایان",1);
        void Reject(string text)=>Dialog(()=>Click(form,"g"),"خطا در ساخت فایل اکسل:",1,requiredText:text);
        string[] Files()=>System.IO.Directory.GetFiles(directory,"*.xlsx").OrderBy(path=>path,StringComparer.OrdinalIgnoreCase).ToArray();
        string Hashes()=>string.Join("|",Files().Select(path=>System.IO.Path.GetFileName(path)+":"+FreeSms.Reports.WorkbookFileBatch.Fingerprint(path)));
        try
        {
            Field<Control>(form,"l").Text="";Dialog(()=>Click(form,"g"),"مسیری برای ساختن فایل اکسل انتخاب نشده است",1);
            Field<Control>(form,"l").Text=directory;Dialog(()=>Click(form,"g"),"هیچ صنفی انتخاب نشده است",1);
            Checked(classes,first);Checked(classes,second);Dialog(()=>Click(form,"g"),"هیچ درسی انتخاب نشده است",1);
            Checked(books,book1);Checked(books,book2);
            RequireReachable(form,Field<UIButton>(form,"g"));SaveGallery(form,"mark-entry-export");
            string grades=asdaj.n;asdaj.n="2";
            try{Reject("سال، پایه یا مجوز دریافت فایل معتبر نیست.");Require(Files().Length==0,"Forbidden export grade wrote output.");}
            finally{asdaj.n=grades;}
            db.Execute("UPDATE tBook SET xPaye=2 WHERE id=@p0",new object[]{book2});
            try{Reject("مضمون انتخاب‌شده با پایه مطابقت ندارد");Require(Files().Length==0,"Stale foreign-grade subject wrote output.");}
            finally{db.Execute("UPDATE tBook SET xPaye=1 WHERE id=@p0",new object[]{book2});}
            db.Execute("UPDATE tClass SET xYear=1425 WHERE id=@p0",new object[]{second});
            try{Reject("صنف انتخاب‌شده با سال و پایه مطابقت ندارد");Require(Files().Length==0,"Stale class year left partial output.");}
            finally{db.Execute("UPDATE tClass SET xYear=1424 WHERE id=@p0",new object[]{second});}
            using(var connection=db.Open())
            using(var transaction=connection.BeginTransaction())
            using(var command=new Microsoft.Data.SqlClient.SqlCommand("UPDATE tClass SET fee=fee WHERE id=@id",connection,transaction))
            {
                command.Parameters.AddWithValue("@id",first);command.ExecuteNonQuery();bool released=false;
                using var timer=new Timer{Interval=500};timer.Tick+=(s,e)=>{timer.Stop();Require(!form.Enabled,"Mark export did not enter its asynchronous state.");form.Close();Require(form.Visible,"Mark export allowed closing while reading its snapshot.");transaction.Rollback();released=true;};
                timer.Start();Save();Require(released,"Mark export UI heartbeat did not release the real SQL lock.");
            }
            string[] files=Files();Require(files.Length==2 && files.Select(System.IO.Path.GetFileName).Distinct(StringComparer.OrdinalIgnoreCase).Count()==2,"Colliding sanitized class names lost an output workbook.");
            var codes=new HashSet<string>();int rows=0;
            foreach(string path in files)
            {
                var imported=ImportWorkbook.Read(path,WorkbookImportKind.Marks);Require(imported.Rows.Count==2,"Mark-entry file did not contain exactly two selected-subject rows.");
                foreach(System.Data.DataRow row in imported.Rows)
                {
                    string code=Convert.ToString(row["code"]);codes.Add(code);rows++;
                    Require(row.IsNull("mark") && new[]{"6000401","6000402"}.Contains(Convert.ToString(row["codedars"])),"Generated file filled a mark or exported a foreign subject.");
                }
                using var zip=System.IO.Compression.ZipFile.OpenRead(path);using var entry=zip.GetEntry("xl/worksheets/sheet1.xml").Open();var xml=System.Xml.Linq.XDocument.Load(entry);System.Xml.Linq.XNamespace ns="http://schemas.openxmlformats.org/spreadsheetml/2006/main";
                Require(!xml.Descendants(ns+"f").Any(),"Formula-looking names became generated formulas.");
                if(imported.Rows.Cast<System.Data.DataRow>().Any(row=>Convert.ToString(row["code"])=="6000400001"))Require(xml.Descendants(ns+"t").Any(node=>node.Value=="=1+2"),"Literal formula-looking student name changed.");
            }
            Require(rows==4 && codes.SetEquals(new[]{"6000400001","6000400002"}),"Export mixed unselected class/grade/student identities or truncated BigInt.");
            string original=Hashes();Dialog(()=>Click(form,"g"),"فایل هم‌نام موجود است. جایگزین شود؟",7);Require(Hashes()==original,"Declining workbook overwrite changed previous files.");
            void Overwrite()=>Dialog(()=>Click(form,"g"),"فایل هم‌نام موجود است. جایگزین شود؟",6);
            Dialog(Overwrite,"پایان",1);Require(Hashes()==original,"Repeated workbook export changed unchanged data.");
            int lastClass=Enumerable.Range(0,classes.RowCount).Where(index=>Equals(classes.GetRow(index).Cells[0].Value,true)).Select(index=>Convert.ToInt32(classes.GetRow(index).Cells["id"].Value)).Last();
            string laterOutput=files.Single(path=>path.EndsWith("-"+lastClass+".xlsx",StringComparison.OrdinalIgnoreCase));
            using(var locked=new System.IO.FileStream(laterOutput,System.IO.FileMode.Open,System.IO.FileAccess.Read,System.IO.FileShare.Read))
                Dialog(Overwrite,"خطا در ساخت فایل اکسل:",1);
            Require(Hashes()==original && !System.IO.Directory.GetFiles(directory).Any(path=>path.EndsWith(".tmp") || path.EndsWith(".bak")),"A locked later destination lost an earlier workbook or left staging artifacts.");
            Dialog(Overwrite,"پایان",1);Require(Hashes()==original,"Retry after locked output changed its data.");
            string after=System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT * FROM tStudent ORDER BY id"),db.Query("SELECT * FROM tYear_Student ORDER BY id"),db.Query("SELECT * FROM tMark ORDER BY id"),db.Query("SELECT * FROM tExam ORDER BY id")});
            Require(snapshot==after,"Mark-entry export changed students/enrolments/marks/calculation flags.");Click(form,"m_e");
            log("PASS original mark-entry export buttons validate path/classes/subjects, enforce grade/year/subject snapshot, retain seven import headers/Sheet1/blank marks/full BigInt/quotes/formula-looking text, avoid sanitized-name collisions, keep UI responsive during SQL wait with close guard, respect overwrite No/Yes, recover locked destination/retry and preserve database state; folder chooser interaction is not covered");
        }
        finally{System.IO.Directory.Delete(directory,true);}
    }
    private static void NewYear(Form form,Database db,Action<string> log)
    {
        int source=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1421 AND name=N'صنف مبدأ انتقال سال'"));
        int other=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1421 AND name=N'صنف دیگر مبدأ انتقال سال'"));
        int target=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1422 AND name=N'صنف مقصد انتقال سال'"));
        int protectedClass=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1422 AND name=N'صنف محفوظ انتقال سال'"));
        int first=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=6000301")),second=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=6000302"));
        int discount=Convert.ToInt32(db.Scalar("SELECT id FROM tTakhfif WHERE name=N'تخفیف انتقال سال آزمایشی'"));
        Field<UIComboBox>(form,"l").SelectedValue="1421";Field<UIComboBox>(form,"m_g").SelectedValue="1";Field<UIComboBox>(form,"n").SelectedValue=source.ToString();
        Field<UIComboBox>(form,"m_e").SelectedValue="2";Field<UIComboBox>(form,"m_i").SelectedValue=target.ToString();
        var grid=Field<GridEX>(form,"r");Require(grid.RowCount==3 && Field<GridEX>(form,"s").RowCount==0,"New-year lists mixed source/target classes or included an already-enrolled student.");
        var nativeGrid=grid.Controls.OfType<DataGridView>().Single();
        nativeGrid.DataError+=(sender,args)=>{diagnostic("FAILED new-year grid data conversion: "+args.Exception);args.ThrowException=true;};
        RequireReachable(form,Field<UIButton>(form,"m_d"));RequireReachable(form,grid);SaveGallery(form,"new-year");
        string Snapshot()=>System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT * FROM tYear_Student ORDER BY id"),db.Query("SELECT * FROM tStudent ORDER BY id"),db.Query("SELECT * FROM tMark ORDER BY id"),db.Query("SELECT * FROM tMarkDoreh ORDER BY xStudent,Xtest,typ"),db.Query("SELECT * FROM tPaymentStudent ORDER BY id"),db.Query("SELECT * FROM tExam ORDER BY id"),db.Query("SELECT * FROM tClass ORDER BY id")});
        string Protected()=>System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT * FROM tYear_Student WHERE NOT(xYear=1422 AND xStudent IN(@p0,@p1)) ORDER BY id",new object[]{first,second}),db.Query("SELECT * FROM tStudent ORDER BY id"),db.Query("SELECT * FROM tMark ORDER BY id"),db.Query("SELECT * FROM tMarkDoreh ORDER BY xStudent,Xtest,typ"),db.Query("SELECT * FROM tPaymentStudent ORDER BY id"),db.Query("SELECT * FROM tExam ORDER BY id"),db.Query("SELECT * FROM tClass ORDER BY id")});
        string before=Snapshot(),keep=Protected();
        Dialog(()=>Click(form,"m_d"),"شاگردی انتخاب نشده است",1);
        void Selected(int student){Select(form,student,"r");grid.GetRow(grid.Row).Cells["Selector"].Value=true;}
        Selected(first);Selected(second);log("NEW-YEAR selected both candidates");
        Select(form,second,"r");int secondRow=grid.Row;
        grid.GetRow(secondRow).Cells["xTakhfif"].Value=discount;log("NEW-YEAR selected discount");
        EditGridCell(grid,secondRow,"Fee1","۷۵");log("NEW-YEAR Persian tuition committed to typed grid");
        EditGridCell(grid,secondRow,"transport1","۲۰");log("NEW-YEAR Persian transport committed to typed grid");
        grid.GetRow(secondRow).Cells["dakhle"].Value=true;grid.GetRow(secondRow).Cells["transport"].Value=true;
        string confirm="تعداد شاگردان انتخابی  : 2 نفر\n-  صنف سال جدید : "+Field<UIComboBox>(form,"m_i").SelectedItem.Text+"\nانتخاب شده آیا از انتقال مطمئن هستيد؟";
        void Confirm()=>Dialog(()=>Click(form,"m_d"),confirm,6);
        void Reject(string text)=>Dialog(Confirm,"خطا در انتقال شاگردان:",1,requiredText:text);
        Dialog(()=>Click(form,"m_d"),confirm,7);Require(Snapshot()==before,"Declining new-year transfer wrote enrollments.");
        foreach(string invalid in new[]{"-1","238609295"})
        {
            EditGridCell(grid,secondRow,"Fee1",invalid);
            Dialog(()=>Click(form,"m_d"),"ردیف "+(secondRow+1)+" فهرست:",1,requiredText:"مقدار عددی خارج از محدودهٔ مجاز است.");
            Require(Snapshot()==before,"Invalid late-row new-year fee wrote earlier students.");
        }
        EditGridCell(grid,secondRow,"Fee1","۷۵");EditGridCell(grid,secondRow,"transport1","-1");
        Dialog(()=>Click(form,"m_d"),"ردیف "+(secondRow+1)+" فهرست:",1,requiredText:"مقدار عددی خارج از محدودهٔ مجاز است.");
        Require(Snapshot()==before,"Negative new-year transport wrote enrollments.");EditGridCell(grid,secondRow,"transport1","۲۰");
        string user=asdaj.l;asdaj.l="2";
        try{Dialog(()=>Click(form,"m_d"),"فقط کاربر admin اجازهٔ انتقال سال را دارد.",1);Require(Snapshot()==before,"Nonadmin new-year Save wrote rows.");}
        finally{asdaj.l=user;}
        string grades=asdaj.n;asdaj.n="1";
        try{Reject("صنف، پایه یا مجوز انتقال معتبر نیست.");Require(Snapshot()==before,"Forbidden target grade wrote rows.");}
        finally{asdaj.n=grades;}
        grid.GetRow(secondRow).Cells["xTakhfif"].Value=0;Reject("برای فیس متفاوت از فیس صنف، تخفیف را انتخاب کنید.");
        Require(Snapshot()==before,"Late missing discount left an earlier student transferred.");grid.GetRow(secondRow).Cells["xTakhfif"].Value=discount;
        db.Execute("UPDATE tClass SET fee=130 WHERE id=@p0",new object[]{target});
        try{string changed=Snapshot();Reject("برای فیس متفاوت از فیس صنف، تخفیف را انتخاب کنید.");Require(Snapshot()==changed,"A changed target class fee allowed a stale undiscounted amount.");}
        finally{db.Execute("UPDATE tClass SET fee=120 WHERE id=@p0",new object[]{target});}
        db.Execute("UPDATE tClass SET xYear=1423 WHERE id=@p0",new object[]{target});
        try{string changed=Snapshot();Reject("صنف مقصد با سال و پایه مطابقت ندارد.");Require(Snapshot()==changed,"A target class moved to another year allowed transfer.");}
        finally{db.Execute("UPDATE tClass SET xYear=1422 WHERE id=@p0",new object[]{target});}
        db.Execute("UPDATE tYear_Student SET xClass=@p0 WHERE xYear=1421 AND xStudent=@p1",new object[]{other,second});
        try{string changed=Snapshot();Reject("فهرست شاگردان مبدأ تغییر کرده است");Require(Snapshot()==changed,"Stale source membership left a partial new-year batch.");}
        finally{db.Execute("UPDATE tYear_Student SET xClass=@p0 WHERE xYear=1421 AND xStudent=@p1",new object[]{source,second});}
        InsertTransitionFixtureEnrollment(db,second,protectedClass,300);
        try{string changed=Snapshot();Reject("شاگرد قبلاً در سال مقصد ثبت‌نام شده است");Require(Snapshot()==changed,"Existing destination enrollment was overwritten or left another student transferred.");}
        finally{db.Execute("DELETE FROM tYear_Student WHERE xYear=1422 AND xStudent=@p0",new object[]{second});}
        db.Execute("CREATE TRIGGER native_new_year_fail ON dbo.tYear_Student AFTER INSERT AS IF EXISTS(SELECT 1 FROM inserted WHERE xYear=1422 AND xStudent="+second+") THROW 51000,'native new-year late student failure',1");
        try{Reject("native new-year late student failure");Require(Snapshot()==before,"Late SQL new-year failure left an earlier enrollment or changed source data.");}
        finally{db.Execute("DROP TRIGGER native_new_year_fail");}
        Require(Convert.ToInt32(grid.GetRow(secondRow).Cells["Fee1"].Value)==75 && Equals(grid.GetRow(secondRow).Cells["Selector"].Value,true),"Failed new-year transfer discarded pending selection or fees.");
        using(var connection=db.Open())
        using(var transaction=connection.BeginTransaction())
        using(var command=new Microsoft.Data.SqlClient.SqlCommand("UPDATE tClass SET fee=fee WHERE id=@id",connection,transaction))
        {
            command.Parameters.AddWithValue("@id",target);command.ExecuteNonQuery();bool released=false;
            using var timer=new Timer{Interval=500};
            timer.Tick+=(s,e)=>{timer.Stop();Require(!form.Enabled,"New-year transfer did not enter an asynchronous busy state.");form.Close();Require(form.Visible,"New-year transfer allowed closing before commit.");transaction.Rollback();released=true;};
            timer.Start();Dialog(Confirm,"انجام شد",1);Require(released,"New-year UI heartbeat did not release the real SQL lock.");
        }
        var rows=db.Query("SELECT y.*,s.Code FROM tYear_Student y JOIN tStudent s ON s.id=y.xStudent WHERE y.xYear=1422 AND y.xStudent IN(@p0,@p1) ORDER BY s.Code",new object[]{first,second});
        Require(rows.Count==2,"New-year Save did not transfer exactly the selected students.");
        for(int i=0;i<2;i++)
        {
            var row=rows[i];int fee=i==0?120:75;
            Require(row.Int("xPaye")==2 && row.Int("xClass")==target && row.Int("Status")==1 && row.Int("SumFee")==fee*9 && Enumerable.Range(1,9).All(month=>row.Int("Fee"+month)==fee),"New-year class/status or original nine-month tuition semantics changed.");
            Require(row.Int("xTakhfif")== (i==0?0:discount) && row.Int("codeTakhfif")==701+i && row.Int("shaghe")== (i==0?1:0) && row.Int("hazer")== (i==0?0:1) && row.Int("mali")==1,"New-year discount/selected study flags changed.");
            Require(row.Int("dakhle")==i && row.Int("transport")==i && row.Int("uniform")==0 && row.Int("komakdarsi")==0 && row.Int("ketab")==0 && row.Int("robotic")==0 && row.Int("maghnae")==0,"New-year flags were copied from old enrollment instead of using selected/reset flags.");
            Require(i==0?row.Value("Sumtransport")==null && Enumerable.Range(1,9).All(month=>row.Value("transport"+month)==null):row.Int("Sumtransport")==180 && Enumerable.Range(1,9).All(month=>row.Int("transport"+month)==20),"New-year blank transport changed to zero or lost its exact nine-month amount.");
            Require(row.Value("sort")==null || row.Int("sort")!=11+i,"New-year copied a source sort that the recovered procedure does not supply.");
        }
        Require(Protected()==keep,"New-year transition changed old-year students/fees/status/marks/calculations/payments, another class or an unselected/existing destination enrollment.");
        Require(grid.RowCount==1 && Field<GridEX>(form,"s").RowCount==2,"Committed new-year transfer did not refresh both source and target lists.");
        string after=Snapshot();Dialog(()=>Click(form,"m_d"),"شاگردی انتخاب نشده است",1);Require(Snapshot()==after,"Repeated new-year Save duplicated enrollments.");
        Click(form,"t");
        using var reopened=new asdbz();reopened.Show();
        Field<UIComboBox>(reopened,"m_e").SelectedValue="2";Field<UIComboBox>(reopened,"m_i").SelectedValue=target.ToString();
        Require(Field<GridEX>(reopened,"s").RowCount==2,"Reopening new-year transfer lost committed destination enrollments.");reopened.Close();
        log("PASS actual new-year Save No/Yes, no-selection/admin/grade/negative/overflow/discount rejection, stale source and existing destination preservation, late SQL rollback/retry, pending selection, real SQL-lock heartbeat/close guard, exact original nine-month fee/null-transport/discount/flag semantics, source years/marks/calculations/payments and unselected students, repeat transfer and reopen");
    }
    private static void WorkbookPreview(Form form, Database db, Action<string> log, bool students)
    {
        string gridField=students?"e":"m_d", pickerField=students?"h":"g", buttonField=students?"g":"f";
        var grid=Field<GridEX>(form,gridField);
        var picker=Field<OpenFileDialog>(form,pickerField);
        var button=Field<Button>(form,buttonField);
        string before=System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT COUNT(*) AS total FROM tStudent"),db.Query("SELECT COUNT(*) AS total FROM tMark"),db.Query("SELECT id,procc FROM tExam ORDER BY id")});
        string fixtures=System.IO.Path.Combine(AppContext.BaseDirectory,"verification-workbooks");
        void WaitReady()
        {
            var elapsed=System.Diagnostics.Stopwatch.StartNew();
            while(!form.Enabled && elapsed.Elapsed<TimeSpan.FromSeconds(10)) {Application.DoEvents();System.Threading.Thread.Sleep(10);}
            Require(form.Enabled,"Workbook preview did not restore the enabled form.");
        }
        void Open(string path,bool cancel=false)
        {
            picker.FileName=path;RequireReachable(form,button);
            bool observed=false;
            using var timer=new Timer {Interval=100};
            timer.Tick+=(s,e)=>EnumThreadWindows(GetCurrentThreadId(),(window,p)=>
            {
                var kind=new StringBuilder(128);GetClassName(window,kind,kind.Capacity);
                var title=new StringBuilder(256);GetWindowText(window,title,title.Capacity);
                if(!IsWindowVisible(window) || kind.ToString()!="#32770" || title.ToString()!="انتخاب فایل اکسل")return true;
                IntPtr selected=IntPtr.Zero;
                EnumChildWindows(window,(child,unused)=>
                {
                    var name=new StringBuilder(128);GetClassName(child,name,name.Capacity);
                    if(name.ToString().Equals("Button",StringComparison.OrdinalIgnoreCase) && GetDlgCtrlID(child)==(cancel?2:1))selected=child;
                    return true;
                },IntPtr.Zero);
                if(selected==IntPtr.Zero)return true;
                observed=true;timer.Stop();SetActiveWindow(window);
                Require(PostMessage(selected,0x00F5,IntPtr.Zero,IntPtr.Zero),"Could not click the actual file chooser button.");
                return false;
            },IntPtr.Zero);
            timer.Start();button.PerformClick();Require(observed,"Actual workbook file chooser did not appear.");
        }
        Open(System.IO.Path.Combine(AppContext.BaseDirectory,"xls",students?"Example.xls":"ExampleMark.xls"));WaitReady();
        Require(grid.DataSource is System.Data.DataTable,"Recovered binary XLS did not load through the actual file button.");
        log("PASS original XLS example loads through the actual native file chooser without an Office provider");
        string valid=System.IO.Path.Combine(fixtures,students?"students-valid.xlsx":"marks-valid.xlsx");
        Open(valid);WaitReady();
        var table=(System.Data.DataTable)grid.DataSource;
        Require(grid.RowCount==(students?2:3) && (string)table.Rows[0]["code"]=="001234","Workbook preview lost leading zeros or duplicated its first row.");
        if(students)Require((string)table.Rows[0]["name"]=="نام ' آزمون" && (string)table.Rows[0]["mobilefather"]=="0700000000","Student preview changed quoted names/telephone text.");
        else Require((string)table.Rows[0]["mark"]=="25.5" && (string)table.Rows[1]["mark"]=="0" && table.Rows[2].IsNull("mark"),"Mark preview changed fractions, zero or a blank mark.");
        RequireReachable(form,grid);SaveGallery(form,students?"student-import":"mark-import");
        Open(valid,cancel:true);Require(ReferenceEquals(table,grid.DataSource),"Cancelling the file chooser changed the old preview.");
        Dialog(()=>Open(System.IO.Path.Combine(fixtures,"corrupt.xlsx")),"فایل اکسل قابل خواندن نیست؛ فایل سالم و بدون گذرواژه را انتخاب کنید.",1);WaitReady();
        Require(ReferenceEquals(table,grid.DataSource),"A corrupt workbook replaced the valid preview.");
        Dialog(()=>Open(System.IO.Path.Combine(fixtures,"missing-header.xlsx")),"ستون‌های لازم در فایل اکسل وجود ندارند:",1,requiredText:students?"class":"codedars");WaitReady();
        Require(ReferenceEquals(table,grid.DataSource),"A missing-column workbook replaced the valid preview.");
        if(!students)
        {
            Dialog(()=>Open(System.IO.Path.Combine(fixtures,"duplicate-header.xlsx")),"عنوان ستون تکراری یا رزروشده است: code",1);WaitReady();
            Require(ReferenceEquals(table,grid.DataSource),"Duplicate columns replaced the valid mark preview.");
            Dialog(()=>Open(System.IO.Path.Combine(fixtures,"cell-error.xlsx")),"خانهٔ اکسل در ردیف 2 و ستون 3 خطا دارد.",1);WaitReady();
            Require(ReferenceEquals(table,grid.DataSource),"An Excel error cell replaced the valid mark preview.");
        }
        Open(valid);WaitReady();Require(grid.RowCount==(students?2:3),"Reload appended rows instead of replacing the preview.");
        string after=System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT COUNT(*) AS total FROM tStudent"),db.Query("SELECT COUNT(*) AS total FROM tMark"),db.Query("SELECT id,procc FROM tExam ORDER BY id")});
        Require(before==after,"Preview/cancel/rejected workbooks changed database rows or processing state.");
        if(students)WorkbookStudentSave(form,db,log,()=>{Open(System.IO.Path.Combine(fixtures,"students-save.xlsx"));WaitReady();});
        else WorkbookMarkSave(form,db,log,()=>{Open(System.IO.Path.Combine(fixtures,"marks-save.xlsx"));WaitReady();});
        Click(form,students?"m_d":"m_c");
        log("PASS actual XLSX preview, repeat-load row isolation, file chooser Cancel, corrupt/missing-column rejection and previous preview/database preservation; import transaction assertions are recorded separately above");
    }
    private static void WorkbookStudentSave(Form form,Database db,Action<string> log,Action load)
    {
        load();var grid=Field<GridEX>(form,"e");var table=(System.Data.DataTable)grid.DataSource;
        int discount=Convert.ToInt32(db.Scalar("SELECT id FROM tTakhfif WHERE name=N'تخفیف آزمون ورود شاگردان اکسل'"));
        Field<UIComboBox>(form,"m").SelectedValue=discount.ToString();
        Field<Control>(form,"p").Text="1420/01/02";
        string Snapshot()=>System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT * FROM tStudent ORDER BY id"),db.Query("SELECT * FROM tYear_Student ORDER BY xYear,xStudent"),db.Query("SELECT * FROM tClass ORDER BY id"),db.Query("SELECT * FROM tPaymentStudent ORDER BY id")});
        string Peers()=>System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT * FROM tStudent WHERE Code IS NULL OR Code NOT BETWEEN 60002010001 AND 60002060006 ORDER BY id"),db.Query("SELECT y.* FROM tYear_Student y JOIN tStudent s ON s.id=y.xStudent WHERE s.Code IS NULL OR s.Code NOT BETWEEN 60002010001 AND 60002060006 ORDER BY y.xYear,y.xStudent"),db.Query("SELECT p.* FROM tPaymentStudent p JOIN tStudent s ON s.id=p.xStudent WHERE s.Code IS NULL OR s.Code NOT BETWEEN 60002010001 AND 60002060006 ORDER BY p.id")});
        void Set(int row,string column,string value)=>EditGridCell(grid,row,column,value);
        void Confirm()=>Dialog(()=>Field<Button>(form,"f").PerformClick(),"آيا از انتقال مطمئن هستيد؟",6);
        void Save()=>Dialog(Confirm,"انجام شد",1);
        void Reject(string text)=>Dialog(Confirm,"خطا در ثبت شاگردان:",1,requiredText:text);
        string before=Snapshot(),peers=Peers();
        Dialog(()=>Field<Button>(form,"f").PerformClick(),"آيا از انتقال مطمئن هستيد؟",7);
        Require(Snapshot()==before,"Declining student workbook Save changed database rows.");
        Field<Control>(form,"p").Text="1420/07/31";
        Dialog(()=>Field<Button>(form,"f").PerformClick(),"تاریخ پرداخت اشتباه است",1);
        Require(Snapshot()==before,"Invalid payment date wrote student rows.");Field<Control>(form,"p").Text="1420/01/02";
        Set(5,"payment","-1");Dialog(()=>Field<Button>(form,"f").PerformClick(),"ردیف 6 فهرست:",1,requiredText:"مقدار عددی خارج از محدودهٔ مجاز است.");
        Require(Snapshot()==before,"Invalid late payment input left a partial student workbook.");Set(5,"payment","0");
        Set(1,"code","60002010001");Reject("کد متعلم در فایل تکراری است");
        Require(Snapshot()==before,"Duplicate workbook code changed the bank.");Set(1,"code","60002020002");
        Set(1,"numberasas","6000201");Reject("نمبر اساس در فایل تکراری است");
        Require(Snapshot()==before,"Duplicate workbook NumberAsas changed the bank.");Set(1,"numberasas","");
        string grades=asdaj.n;asdaj.n="1";
        try{Reject("مجوز ثبت شاگردان این پایه را ندارید");Require(Snapshot()==before,"Late forbidden grade left an earlier student/payment or class.");}
        finally{asdaj.n=grades;}
        string existingCode=Convert.ToString(db.Scalar("SELECT TOP(1) Code FROM tStudent WHERE Code IS NOT NULL ORDER BY id"));
        Require(!string.IsNullOrEmpty(existingCode),"Existing student code fixture is required.");
        Set(5,"code",existingCode);Reject("کد متعلم تکراری است");
        Require(Snapshot()==before,"Late existing code left student/payment/class writes.");Set(5,"code","60002060006");
        string existingNumber=Convert.ToString(db.Scalar("SELECT TOP(1) NumberAsas FROM tStudent WHERE NumberAsas IS NOT NULL ORDER BY id"));
        if(!string.IsNullOrEmpty(existingNumber))
        {
            Set(5,"numberasas",existingNumber);Reject("نمبر اساس تکراری است");
            Require(Snapshot()==before,"Late existing NumberAsas left student/payment/class writes.");Set(5,"numberasas","6000206");
        }
        db.Execute("CREATE TRIGGER native_student_workbook_fail ON dbo.tPaymentStudent AFTER INSERT AS IF EXISTS(SELECT 1 FROM inserted p JOIN tStudent s ON s.id=p.xStudent WHERE s.Code=60002020002) THROW 51000,'native student workbook late payment failure',1");
        try{Reject("native student workbook late payment failure");Require(Snapshot()==before,"Late SQL payment failure left classes, students, enrolments or earlier payments.");}
        finally{db.Execute("DROP TRIGGER native_student_workbook_fail");}
        db.Execute("CREATE TRIGGER native_student_workbook_student_fail ON dbo.tStudent AFTER INSERT AS IF EXISTS(SELECT 1 FROM inserted WHERE Code=60002060006) THROW 51000,'native student workbook late student failure',1");
        try{Reject("native student workbook late student failure");Require(Snapshot()==before,"Late SQL student failure left classes, earlier students, enrolments or payments.");}
        finally{db.Execute("DROP TRIGGER native_student_workbook_student_fail");}
        Require((string)table.Rows[0]["name"]=="نام ' محفوظ 1" && (string)table.Rows[1]["code"]=="60002020002","Failed import discarded pending input.");
        using(var connection=db.Open())
        using(var transaction=connection.BeginTransaction())
        using(var command=new Microsoft.Data.SqlClient.SqlCommand("UPDATE tClass SET fee=fee WHERE xYear=1420 AND xPaye=1 AND name=@name",connection,transaction))
        {
            command.Parameters.AddWithValue("@name","صنف ' اکسل");command.ExecuteNonQuery();bool released=false;
            using var timer=new Timer{Interval=500};
            timer.Tick+=(s,e)=>
            {
                timer.Stop();Require(!form.Enabled,"Student import blocked the UI or did not enter the busy state.");
                form.Close();Require(form.Visible,"Student import allowed closing during its transaction.");
                transaction.Rollback();released=true;
            };
            timer.Start();Save();Require(released,"Student import UI heartbeat did not release the real SQL lock.");
        }
        var saved=db.Query("SELECT s.*,y.*,c.name AS ClassName,c.xPaye AS ClassGrade,c.fee AS ClassFee,c.xYear AS ClassYear FROM tStudent s JOIN tYear_Student y ON y.xStudent=s.id JOIN tClass c ON c.id=y.xClass WHERE s.Code BETWEEN 60002010001 AND 60002060006 ORDER BY s.Code");
        int[][] expected={Enumerable.Repeat(100,9).ToArray(),new[]{100,100,50,0,0,0,0,0,0},new int[9],new[]{25,0,0,0,0,0,0,0,0},new[]{100,100,100,100,100,100,100,100,200},Enumerable.Repeat(100,9).ToArray()};
        Require(saved.Count==6,"Student workbook did not create exactly six enrolments.");
        for(int index=0;index<6;index++)
        {
            var row=saved[index];int grade=index==1?2:index==2?100:1;
            Require(row.Int("xYear")==1420 && row.Int("ClassYear")==1420 && row.Int("xPaye")==grade && row.Int("ClassGrade")==grade,"Same-title classes crossed grade/year boundaries.");
            Require(Enumerable.Range(1,9).Select(month=>row.Int("Fee"+month)).SequenceEqual(expected[index]) && row.Int("SumFee")==expected[index].Sum() && row.Int("xTakhfif")==((index==0 || index==5)?0:discount),"Persisted import fee/discount allocation changed.");
            Require(row.Text("FName")=="نام ' محفوظ "+(index+1) && row.Text("MobileFather")=="0700000000" && row.Text("RegDate")=="1420/01/01","Imported identity, phone or registration date changed.");
        }
        Require(saved[1].Value("NumberAsas")==null && saved[1].Value("Sort")==null && saved[1].Int("Jens")==-1,"Missing optional student fields changed.");
        Require(saved[0].Int("xClass")!=saved[1].Int("xClass") && saved[0].Int("ClassFee")==777 && Convert.ToInt32(db.Scalar("SELECT fee FROM tClass WHERE xYear=1421 AND name=@p0",new object[]{"صنف ' اکسل"}))==888,"Existing class fees or another year's same-title class changed.");
        var payments=db.Query("SELECT s.Code,p.* FROM tPaymentStudent p JOIN tStudent s ON s.id=p.xStudent WHERE s.Code BETWEEN 60002010001 AND 60002060006 ORDER BY s.Code");
        Require(payments.Count==3 && payments[0].Int("Fee")==200 && payments[0].Int("dakhle")==10 && payments[0].Int("Exam")==20 && payments[0].Int("uniform")==30 && payments[1].Int("Fee")==50 && payments[2].Int("Fee")==30 && payments.All(row=>row.Int("xYear")==1420 && row.Int("xUserInsert")==1 && row.Text("PaynemtDate")=="1420/01/02" && row.Text("dayOfWeek")==WorkbookPaymentDate.Parse("1420/01/02").Weekday),"Imported payment amounts/date/user/weekday or zero-payment skip changed.");
        Require(table.Rows.Cast<System.Data.DataRow>().All(row=>(string)row["acp"]=="1"),"Committed student rows were not marked saved.");
        string after=Snapshot();Reject("کد متعلم تکراری است");Require(Snapshot()==after,"Repeating student import duplicated payment/enrolment/class rows.");
        Require(Peers()==peers,"Student workbook changed unrelated students, enrolments or payments.");
        log("PASS actual student workbook Save No/Yes; date/amount/duplicate/grade validation; late existing-code/NumberAsas and SQL-payment rollback; preserved pending values; real SQL-lock heartbeat/close guard; BigInt/quotes/phones/optional fields; kindergarten and same-title cross-grade/year classes; exact nine-month full/discount/zero/partial/remainder fees and original payment semantics; repeat import rejection");
    }
    private static void WorkbookMarkSave(Form form,Database db,Action<string> log,Action load)
    {
        load();var grid=Field<GridEX>(form,"m_d");var table=(System.Data.DataTable)grid.DataSource;
        int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1419 AND term=1"));
        int annual=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1419 AND term=3"));
        int peer=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=6000102"));
        Field<UIComboBox>(form,"k").SelectedValue=exam.ToString();
        string confirm="آيا از انتقال نمرات به  "+Field<UIComboBox>(form,"k").SelectedItem.Text+" مطمئن هستيد؟";
        string Snapshot()=>System.Text.Json.JsonSerializer.Serialize(new[]{db.Query("SELECT id,xStudent,Xtest,xbook,M1,M2,Mark FROM tMark ORDER BY id"),db.Query("SELECT id,procc FROM tExam ORDER BY id")});
        void Set(int row,string column,string value)=>EditGridCell(grid,row,column,value);
        void Confirm()=>Dialog(()=>Field<Button>(form,"m_e").PerformClick(),confirm,6);
        void Save()=>Dialog(Confirm,"انجام شد",1);
        void Reject(string text)=>Dialog(Confirm,"خطا در ثبت نمرات:",1,requiredText:text);
        string before=Snapshot();
        Dialog(()=>Field<Button>(form,"m_e").PerformClick(),confirm,7);
        Require(Snapshot()==before,"Declining workbook Save invalidated calculations or wrote marks.");
        Set(1,"mark","41");Dialog(()=>Field<Button>(form,"m_e").PerformClick(),"ردیف 2 فهرست: نمره وارد شده خارج از محدوده است",1);
        Require(Snapshot()==before,"Invalid late workbook input wrote a preceding row.");Set(1,"mark","0");
        Set(1,"code","6000199");Reject("کد متعلم در سال انتخاب‌شده ثبت‌نام معتبر ندارد");
        Require(Snapshot()==before,"Unknown late student left a partially imported file or invalidated calculations.");Set(1,"code","6000102");
        Set(1,"code","6000101");Reject("کد متعلم و مضمون در فایل تکرار شده است");
        Require(Snapshot()==before,"Duplicate workbook rows changed the bank.");Set(1,"code","6000102");
        string grades=asdaj.n;asdaj.n="2";
        try{Reject("مجوز ورود نمرات پایهٔ این متعلم را ندارید");Require(Snapshot()==before,"Forbidden workbook grade wrote marks.");}
        finally{asdaj.n=grades;}
        db.Execute("CREATE TRIGGER native_workbook_fail ON dbo.tMark AFTER UPDATE AS IF EXISTS(SELECT 1 FROM inserted WHERE xStudent="+peer+" AND Xtest="+exam+") THROW 51000,'native workbook late-row failure',1");
        try{Reject("native workbook late-row failure");Require(Snapshot()==before,"Late workbook SQL failure left prior rows or invalidated processing.");}
        finally{db.Execute("DROP TRIGGER native_workbook_fail");}
        Require((string)table.Rows[0]["mark"]=="۲۵٫۵" && (string)table.Rows[1]["mark"]=="0","Failed workbook Save discarded pending file input.");
        using(var connection=db.Open())
        using(var transaction=connection.BeginTransaction())
        using(var command=new Microsoft.Data.SqlClient.SqlCommand("UPDATE tExam SET procc=1 WHERE id=@id",connection,transaction))
        {
            command.Parameters.AddWithValue("@id",exam);command.ExecuteNonQuery();bool released=false;
            using var timer=new Timer{Interval=500};
            timer.Tick+=(s,e)=>
            {
                timer.Stop();Require(!form.Enabled,"Workbook Save did not enter its asynchronous busy state while SQL was locked.");
                form.Close();Require(form.Visible,"Workbook Save allowed closing during an active transaction.");
                transaction.Rollback();released=true;
            };
            timer.Start();Save();Require(released,"Workbook UI heartbeat did not release the real SQL lock.");
        }
        var records=db.Query("SELECT s.Code,m.M1,m.M2,m.Mark FROM tMark m JOIN tStudent s ON s.id=m.xStudent WHERE m.Xtest=@p0 AND s.Code IN(6000101,6000102,6000103) ORDER BY s.Code",new object[]{exam});
        Require(records.Count==3 && Convert.ToDecimal(records[0]["M1"])==25.5m && Convert.ToDecimal(records[0]["Mark"])==25.5m && Convert.ToDecimal(records[1]["M1"])==0 && Convert.ToDecimal(records[2]["M1"])==20 && records.All(row=>Convert.ToDecimal(row["M2"])==7),"Workbook Save lost fractions/zero, cleared blank input or overwrote hidden components.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tMark m JOIN tStudent s ON s.id=m.xStudent JOIN tExam e ON e.id=m.Xtest WHERE e.xYear=1419 AND e.term=2 AND s.Code IN(6000101,6000102,6000103) AND m.M1=CASE WHEN s.Code=6000103 THEN 20 ELSE 10 END"))==3,"Workbook Save changed another exam.");
        Require(Convert.ToInt32(db.Scalar("SELECT procc FROM tExam WHERE id=@p0",new object[]{exam}))==0 && Convert.ToInt32(db.Scalar("SELECT procc FROM tExam WHERE id=@p0",new object[]{annual}))==0,"Workbook Save did not invalidate both selected and annual calculations.");
        Require((string)table.Rows[0]["acp"]=="1" && (string)table.Rows[1]["acp"]=="1" && (string)table.Rows[2]["acp"]=="0","Workbook preview marked an unsaved blank row as saved.");
        string saved=Snapshot();Save();Require(Snapshot()==saved,"Repeating workbook Save duplicated or changed already imported marks.");
        log("PASS actual workbook Save confirmation No/Yes, bounds/unknown student/duplicate/grade rejection, late SQL rollback and retry, pending input, real SQL-lock UI heartbeat/close guard, fractional/zero/blank/hidden component semantics and repeated import with selected/annual invalidation and other-exam preservation");
    }
    private static void BatchPrintList(Form form,Database db,Action<string> log)
    {
        int student=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5999001"));
        int second=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5999002"));
        int otherGrade=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5999003"));
        const int otherUser=5999000;
        string settingsBefore=System.Text.Json.JsonSerializer.Serialize(db.Query("SELECT * FROM tParmetr"));
        db.Execute("INSERT INTO tmpStdforPrint(id,xUser) VALUES(@p0,@p2),(@p1,@p2)",new object[]{student,otherGrade,otherUser});
        int Count(int user)=>Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tmpStdforPrint WHERE xUser=@p0",new object[]{user}));
        try
        {
            Field<UIComboBox>(form,"aq").SelectedValue="1418";
            Field<UIComboBox>(form,"ai").SelectedValue="1";
            Require(Field<GridEX>(form,"ak").RowCount==0 && Field<GridEX>(form,"ac").RowCount==2,"Print lists did not isolate current-user selection and selected grade.");
            Select(form,student,"ac");Click(form,"am");
            Require(Count(1)==1 && Count(otherUser)==2 && Field<GridEX>(form,"ak").RowCount==1,"Adding a print selection changed another user's list.");
            Dialog(()=>Click(form,"am"),"این شاگرد قبلا به لیست پرینت اضافه شده است",1);
            Require(Count(1)==1,"Duplicate selection added a second print row.");
            Select(form,student,"ak");Click(form,"al");
            Require(Count(1)==0 && Count(otherUser)==2 && Field<GridEX>(form,"ak").RowCount==0,"Removing a selected student deleted another user's print selection.");
            Select(form,student,"ac");Click(form,"am");Select(form,second,"ac");Click(form,"am");
            Require(Count(1)==2 && Field<GridEX>(form,"ak").RowCount==2,"Print list did not reload both selected students.");
            RequireReachable(form,Field<UIButton>(form,"am"));RequireReachable(form,Field<UIButton>(form,"al"));
            SaveGallery(form,"batch-print-list");
            Click(form,"an");Require(Count(1)==0 && Count(otherUser)==2,"Clearing the print list changed another user's selections.");
            Select(form,second,"ac");Click(form,"am");Click(form,"m_e");
            Require(Count(1)==0 && Count(otherUser)==2 && System.Text.Json.JsonSerializer.Serialize(db.Query("SELECT * FROM tParmetr"))==settingsBefore,"Closing a print selector changed another user's selections or unchanged report settings.");
            log("PASS original batch print list grade filtering, add/duplicate/remove/clear/close buttons preserve another user's selections and unchanged report settings; populated report rendering remains separate");
        }
        finally{db.Execute("DELETE FROM tmpStdforPrint WHERE xUser=@p0",new object[]{otherUser});}
    }
    private static void BulkMarkEntry(Form selector,Database db,Action<string> log)
    {
        int classroom=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1417 AND name=N'صنف ورود گروهی نمره'"));
        int student=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5998002"));
        int peer=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5998001"));
        int book=Convert.ToInt32(db.Scalar("SELECT id FROM tBook WHERE codedars=5998001"));
        int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1417 AND term=1"));
        int annual=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1417 AND term=3"));
        int other=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1417 AND term=2"));
        Field<UIComboBox>(selector,"l").SelectedValue="1";
        Field<UIComboBox>(selector,"f").SelectedValue=exam.ToString();
        Field<UIComboBox>(selector,"j").SelectedValue=classroom.ToString();
        Field<UIComboBox>(selector,"h").SelectedValue=book.ToString();
        void Open(Action<Form> exercise)=>ChildForm<asdbd>(()=>Field<Button>(selector,"o").PerformClick(),exercise);
        object Value(int id,int test)=>db.Scalar("SELECT M1 FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{id,test,book});
        void Save(Form form,int count=2)=>Dialog(()=>Field<Button>(form,"m").PerformClick(),"تعداد "+count+" ردیف انجام شد",1);
        Open(form=>
        {
            var grid=Field<GridEX>(form,"ab");Require(grid.RowCount==2,"Bulk entry did not load exactly the selected class.");
            RequireReachable(form,grid);RequireReachable(form,Field<Button>(form,"m"));
            SaveGallery(form,"bulk-mark-entry");
            Select(form,student,"ab");EditGridCell(grid,grid.Row,"m1","۲۵");
            Select(form,peer,"ab");EditGridCell(grid,grid.Row,"m1","۳۰");Save(form);
            Require(Convert.ToDecimal(Value(student,exam))==25 && Convert.ToDecimal(Value(peer,exam))==30 && Convert.ToDecimal(Value(student,other))==15,"Bulk Save mixed students or exams.");
            db.Execute("UPDATE tYear_Student SET Status=2 WHERE xYear=1417 AND xStudent=@p0",new object[]{student});
            try
            {
                Select(form,peer,"ab");EditGridCell(grid,grid.Row,"m1","32");
                Dialog(()=>Field<Button>(form,"m").PerformClick(),"",1,requiredText:"فهرست شاگردان تغییر کرده است");
                Require(Convert.ToDecimal(Value(student,exam))==25 && Convert.ToDecimal(Value(peer,exam))==30,"Stale enrollment allowed a partial bulk Save.");
                EditGridCell(grid,grid.Row,"m1","30");
            }
            finally{db.Execute("UPDATE tYear_Student SET Status=1 WHERE xYear=1417 AND xStudent=@p0",new object[]{student});}
            Select(form,student,"ab");EditGridCell(grid,grid.Row,"m1","41");
            db.Execute("UPDATE tExam SET procc=1 WHERE id IN(@p0,@p1)",new object[]{exam,annual});
            Dialog(()=>Field<Button>(form,"m").PerformClick(),"نمره وارد شده خارج از محدوده است",1);
            Require(Convert.ToDecimal(Value(student,exam))==25 && Convert.ToInt32(db.Scalar("SELECT procc FROM tExam WHERE id=@p0",new object[]{exam}))==1,"Invalid bulk mark changed data or processing status.");
            EditGridCell(grid,grid.Row,"m1","26");Select(form,peer,"ab");EditGridCell(grid,grid.Row,"m1","31");
            int failStudent=Convert.ToInt32(grid.GetRow(grid.RowCount-1).Cells["id"].Value);
            db.Execute("CREATE TRIGGER native_bulk_ui_abort ON tMark AFTER INSERT,UPDATE AS BEGIN IF EXISTS(SELECT 1 FROM inserted WHERE xStudent="+failStudent+" AND Xtest="+exam+") THROW 51003,'owned bulk rollback fixture',1; END");
            try
            {
                Dialog(()=>Field<Button>(form,"m").PerformClick(),"",1,requiredText:"نمره‌ها ذخیره نشد.");
                Require(Convert.ToDecimal(Value(student,exam))==25 && Convert.ToDecimal(Value(peer,exam))==30,"A late bulk SQL failure partially saved earlier students.");
                Require(Convert.ToInt32(db.Scalar("SELECT SUM(CONVERT(int,procc)) FROM tExam WHERE id IN(@p0,@p1)",new object[]{exam,annual}))==2,"A failed bulk Save invalidated calculated results.");
            }
            finally{db.Execute("DROP TRIGGER native_bulk_ui_abort");}
            using(var connection=db.Open())
            using(var transaction=connection.BeginTransaction())
            {
                using var command=connection.CreateCommand();command.Transaction=transaction;command.CommandText="UPDATE tExam SET procc=procc WHERE id=@exam";command.Parameters.AddWithValue("@exam",exam);command.ExecuteNonQuery();
                bool heartbeat=false;using var release=new Timer{Interval=350};release.Tick+=(sender,args)=>{release.Stop();transaction.Rollback();heartbeat=true;};release.Start();Save(form);
                Require(heartbeat,"Bulk Save blocked the Windows UI while waiting for SQL.");
            }
            Require(Convert.ToDecimal(Value(student,exam))==26 && Convert.ToDecimal(Value(peer,exam))==31,"Bulk retry discarded the pending edited marks.");
            Require(Convert.ToInt32(db.Scalar("SELECT SUM(CONVERT(int,procc)) FROM tExam WHERE id IN(@p0,@p1)",new object[]{exam,annual}))==0,"Bulk Save did not invalidate both selected and annual results.");
            Select(form,student,"ab");EditGridCell(grid,grid.Row,"m1","29");
            const string unsaved="آخرین تغییرات شما ثبت نشده است.\nآیا میخواهید بدون ثبت آخرین تغییرات از این صفحه خارج شود؟";
            Dialog(()=>Click(form,"aa"),unsaved,7);Require(form.Visible,"Declining unsaved-close still closed bulk entry.");
            var editor=grid.Controls.OfType<DataGridView>().Single();Require(editor.BeginEdit(true),"Bulk cell did not open for invalid-editor discard.");((TextBox)editor.EditingControl).Text="bad";
            Dialog(()=>Click(form,"aa"),unsaved,6);
            Require(Convert.ToDecimal(Value(student,exam))==26,"Discarding bulk edits saved pending marks.");
        });
        Open(form=>
        {
            var grid=Field<GridEX>(form,"ab");Select(form,student,"ab");Require(Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==26,"Bulk reopen did not reload committed marks.");
            Field<Control>(form,"g").Text="۲۸";Field<Button>(form,"i").PerformClick();Save(form);
            Require(Convert.ToDecimal(Value(student,exam))==28 && Convert.ToDecimal(Value(peer,exam))==28,"Uniform Persian bulk input did not update every displayed row.");
            Field<Control>(form,"g").Text="";
            string clear="آیا میخواهید نمرات "+Field<UIComboBox>(form,"k").SelectedItem.Text+" خالی شود";
            Dialog(()=>Field<Button>(form,"i").PerformClick(),clear,7);
            Require(grid.GetRow(0).Cells["m1"].Text!="","Declining bulk clear removed pending marks.");
            Dialog(()=>Field<Button>(form,"i").PerformClick(),clear,6);Save(form);
            Require(db.Scalar("SELECT id FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,exam,book})==null && db.Scalar("SELECT id FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{peer,exam,book})==null,"Clearing bulk marks did not delete exactly the selected subject/exam marks.");
            Require(Convert.ToDecimal(Value(student,other))==15,"Bulk clear changed another exam.");Click(form,"aa");
        });
        // The all-class branch must still isolate the selected year and grade.
        db.Execute("INSERT INTO tYear_Student(xYear,xStudent,xPaye,xClass,Status,MarkTerm3_From100,sort) SELECT 1416,xStudent,xPaye,xClass,Status,MarkTerm3_From100,7 FROM tYear_Student WHERE xYear=1417 AND xStudent=@p0",new object[]{student});
        var school=new SchoolService(db,new Session(1417));
        int order=30000;while(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tClass WHERE sortRpt=@p0",new object[]{order}))>0)order++;
        int otherClass=school.SaveClass(new Record{["name"]="صنف محفوظ گروهی پایه دوم",["xpaye"]=2,["fee"]=0,["sortRpt"]=order});
        school.SaveStudent(new Record{["FName"]="شاگرد محفوظ پایه دوم",["LName"]="پدر گروهی",["Code"]=5998003,["NumberAsas"]=5998003,["xPaye"]=2,["xClass"]=otherClass,["Status"]=1,["Jens"]=0,["Fee1"]=0});
        using(var all=new asdbd{af="0",ag="1",ah=exam.ToString(),ai=book.ToString(),aj="1417",ak="1"})
        {
            all.Show();var grid=Field<GridEX>(all,"ab");Require(grid.RowCount==2,"All-class bulk entry included duplicate previous-year enrollment rows.");
            Field<CheckBox>(all,"l").Checked=true;Select(all,student,"ab");EditGridCell(grid,grid.Row,"sort","12");
            var timeout=System.Diagnostics.Stopwatch.StartNew();while(Field<bool>(all,"savingMarks") && timeout.ElapsedMilliseconds<5000){Application.DoEvents();System.Threading.Thread.Sleep(10);}Application.DoEvents();
            Require(Convert.ToInt32(db.Scalar("SELECT sort FROM tYear_Student WHERE xYear=1417 AND xStudent=@p0",new object[]{student}))==12 && Convert.ToInt32(db.Scalar("SELECT sort FROM tYear_Student WHERE xYear=1416 AND xStudent=@p0",new object[]{student}))==7,"Bulk display-order edit did not isolate the enrollment year.");
            Select(all,student,"ab");
            Dialog(()=>EditGridCell(grid,grid.Row,"sort","-1"),"",1,requiredText:"ترتیب شاگرد ثبت نشد؛ مقدار قبلی حفظ شد.");
            Require(Convert.ToInt32(grid.GetRow(grid.Row).Cells["sort"].Value)==12 && Convert.ToInt32(db.Scalar("SELECT sort FROM tYear_Student WHERE xYear=1417 AND xStudent=@p0",new object[]{student}))==12,"Rejected order did not restore the displayed/saved order.");
            Click(all,"aa");
        }
        db.Execute("UPDATE tYear_Student SET MarkTerm3_From100=1 WHERE xYear=1417 AND xStudent=@p0",new object[]{student});
        db.Execute("INSERT INTO tMark(xStudent,Xtest,xbook,typ,M3,Mark) VALUES(@p0,@p1,@p2,1,5,5)",new object[]{student,annual,book});
        Field<UIComboBox>(selector,"f").SelectedValue=annual.ToString();Field<UIComboBox>(selector,"h").SelectedValue=book.ToString();
        Open(form=>
        {
            var grid=Field<GridEX>(form,"ab");Require(grid.RowCount==1 && Convert.ToInt32(grid.GetRow(0).Cells["id"].Value)==student,"Annual bulk entry included students outside 100-point mode.");
            EditGridCell(grid,0,"m1","75");Save(form,1);
            var mark=db.Query("SELECT M1,M2,M3,Mark FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,annual,book}).Single();
            Require(mark["M1"]==null && Convert.ToDecimal(mark["M2"])==75 && Convert.ToDecimal(mark["M3"])==5 && Convert.ToDecimal(mark["Mark"])==75,"Annual bulk Save changed the recovered total/storage convention.");Click(form,"aa");
        });
        Click(selector,"m_c");log("PASS original bulk marks Save/reopen/unsaved-close/clear/uniform Persian input/bounds/stale enrollment/late SQL rollback/retry/UI lock heartbeat/annual M2 convention and year-scoped display ordering");
    }
    private static void MarkEntry(Form form,Database db,Action<string> log)
    {
        int classroom=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1414 AND name=N'صنف ورود نمره'"));
        int student=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5995002"));
        int peer=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5995001"));
        int book=Convert.ToInt32(db.Scalar("SELECT id FROM tBook WHERE codedars=5995001"));
        int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1414 AND term=1"));
        int other=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1414 AND term=2"));
        Field<UIComboBox>(form,"q").SelectedValue=exam.ToString();
        Field<UIComboBox>(form,"u").SelectedValue="1";
        Field<UIComboBox>(form,"s").SelectedValue=classroom.ToString();
        void Open()
        {
            Select(form,student,"m_i");Click(form,"m_c");Select(form,book,"w","xbook");
            Require(Field<Control>(form,"m_k").Visible,"Mark entry panel did not open.");
            bool Reachable(Control target,System.Drawing.Point point)
            {
                Control hit=form;
                while(true)
                {
                    var child=hit.GetChildAtPoint(hit.PointToClient(point),GetChildAtPointSkip.Invisible);
                    if(child==null)break;hit=child;
                }
                while(hit!=null && hit!=target)hit=hit.Parent;
                return hit==target;
            }
            var save=Field<UIButton>(form,"o");
            Require(Reachable(save,save.PointToScreen(new System.Drawing.Point(save.Width/2,save.Height/2))),"Mark Save is covered by another panel or outside the form.");
            var native=Field<GridEX>(form,"w").Controls.OfType<DataGridView>().Single();
            var cell=native.GetCellDisplayRectangle(native.CurrentCell.ColumnIndex,native.CurrentCell.RowIndex,false);
            Require(Reachable(native,native.PointToScreen(new System.Drawing.Point(cell.Left+cell.Width/2,cell.Top+cell.Height/2))),"The selected mark cell is covered by the student list or another control.");
        }
        void Save()
        {
            var students=Field<GridEX>(form,"m_i");bool next=students.Row<students.RowCount-1;
            Dialog(()=>Click(form,"o"),next?"اطلاعات ذخیره شد . آیا مایل هستید نفر بعدی نمایش داده شود":"اطلاعات ذخیره شد",next?7:1);
        }
        object Value(int id,int test)=>db.Scalar("SELECT M1 FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{id,test,book});
        Field<Control>(form,"m_e").Text="' AND 1=0 --";Click(form,"m_j");
        Require(Field<GridEX>(form,"m_i").RowCount==0,"Mark-entry search punctuation was executed as SQL.");
        Field<Control>(form,"m_e").Text="";Click(form,"m_j");
        Open();var grid=Field<GridEX>(form,"w");
        EditGridCell(grid,grid.Row,"m1","۲۵");Save();
        Require(Convert.ToDecimal(Value(student,exam))==25,"Original mark Save did not persist the entered Persian digits.");
        Open();grid=Field<GridEX>(form,"w");
        Require(Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==25,"Mark entry did not reload the saved mark.");SaveGallery(form,"mark-entry");
        EditGridCell(grid,grid.Row,"m1","28");Click(form,"p");
        Require(Convert.ToDecimal(Value(student,exam))==25,"Cancel committed an edited mark.");
        Open();grid=Field<GridEX>(form,"w");EditGridCell(grid,grid.Row,"m1","28");Save();
        Require(Convert.ToDecimal(Value(student,exam))==28,"Original mark Edit did not update the selected mark.");
        Require(Convert.ToDecimal(Value(peer,exam))==10 && Convert.ToDecimal(Value(student,other))==15,"Mark entry changed a peer or another exam.");
        Open();grid=Field<GridEX>(form,"w");
        Require(Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==28,"Edited mark was not persisted on reopening the entry panel.");
        // Rejected entries must preserve every subject and invalidation flag.
        EditGridCell(grid,grid.Row,"m1","41");
        db.Execute("UPDATE tExam SET procc=1 WHERE id=@p0",new object[]{exam});
        Dialog(()=>Click(form,"o"),"نمره وارد شده خارج از محدوده است",1);
        Require(Convert.ToDecimal(Value(student,exam))==28 && Convert.ToInt32(db.Scalar("SELECT procc FROM tExam WHERE id=@p0",new object[]{exam}))==1,"Rejected mark changed persisted data or processing status.");
        EditGridCell(grid,grid.Row,"m1","28");
        var markView=grid.Controls.OfType<DataGridView>().Single();
        Require(markView.BeginEdit(true),"Mark cell did not open for rejected-input check.");
        ((TextBox)markView.EditingControl).Text="27.5";
        Require(!grid.TryEndEdit() && Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==28,"Integer mark column accepted or rounded fractional input.");
        markView.CancelEdit();EditGridCell(grid,grid.Row,"m1","27");
        int secondBook=Convert.ToInt32(db.Scalar("SELECT id FROM tBook WHERE codedars=5995002"));
        Select(form,secondBook,"w","xbook");EditGridCell(grid,grid.Row,"m1","30");
        db.Execute("CREATE TRIGGER native_mark_ui_abort ON tMark AFTER INSERT,UPDATE AS BEGIN IF EXISTS(SELECT 1 FROM inserted WHERE xbook="+secondBook+" AND xStudent="+student+") THROW 51002,'owned mark rollback fixture',1; END");
        try
        {
            Dialog(()=>Click(form,"o"),"",1,requiredText:"نمره‌ها ذخیره نشد.");
            Require(Convert.ToDecimal(Value(student,exam))==28 && db.Scalar("SELECT id FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,exam,secondBook})==null,"A later subject failure left partially saved marks.");
            Require(Convert.ToInt32(db.Scalar("SELECT procc FROM tExam WHERE id=@p0",new object[]{exam}))==1,"A failed batch invalidated calculations.");
            Require(Field<Control>(form,"m_k").Visible && Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==30,"Failed Save discarded the user's pending marks.");
        }
        finally{db.Execute("DROP TRIGGER native_mark_ui_abort");}
        // A UI timer must release a real row lock while the Save is waiting.
        using(var connection=db.Open())
        using(var transaction=connection.BeginTransaction())
        {
            using var command=connection.CreateCommand();command.Transaction=transaction;
            command.CommandText="UPDATE tExam SET procc=procc WHERE id=@exam";command.Parameters.AddWithValue("@exam",exam);command.ExecuteNonQuery();
            bool heartbeat=false;using var release=new Timer{Interval=350};
            release.Tick+=(sender,args)=>{release.Stop();transaction.Rollback();heartbeat=true;};release.Start();Save();
            Require(heartbeat,"Mark Save blocked the UI while waiting for SQL.");
        }
        Require(Convert.ToDecimal(Value(student,exam))==27m && Convert.ToDecimal(db.Scalar("SELECT M1 FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,exam,secondBook}))==30,"Retry did not commit the complete batch.");
        Require(Convert.ToInt32(db.Scalar("SELECT procc FROM tExam WHERE id=@p0",new object[]{exam}))==0,"Successful marks did not invalidate calculated results.");
        Open();Select(form,secondBook,"w","xbook");EditGridCell(grid,grid.Row,"m1","");Save();
        Require(db.Scalar("SELECT id FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,exam,secondBook})==null,"Clearing all components did not delete the selected subject's mark.");
        Require(Convert.ToDecimal(Value(student,exam))==27m && Convert.ToDecimal(Value(peer,exam))==10 && Convert.ToDecimal(Value(student,other))==15,"Clearing changed another subject, student or exam.");
        Click(form,"p");
        int annual=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1414 AND term=3"));
        db.Execute("UPDATE tYear_Student SET MarkTerm3_From100=1 WHERE xStudent=@p0 AND xYear=1414",new object[]{student});
        Field<UIComboBox>(form,"q").SelectedValue=annual.ToString();
        Require(Field<Control>(form,"y").Text=="100","Annual manual-entry limit differs from the original 100-point mode.");
        Open();grid=Field<GridEX>(form,"w");EditGridCell(grid,grid.Row,"m1","101");
        Dialog(()=>Click(form,"o"),"نمره وارد شده خارج از محدوده است",1);
        Require(db.Scalar("SELECT id FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,annual,book})==null,"Out-of-range annual mark was stored.");
        Click(form,"p");
        db.Execute("INSERT INTO tMark(xStudent,Xtest,xbook,typ,M3,Mark) VALUES(@p0,@p1,@p2,1,5,5)",new object[]{student,annual,book});
        Open();grid=Field<GridEX>(form,"w");EditGridCell(grid,grid.Row,"m1","75");Save();
        var annualMark=db.Query("SELECT M1,M2,M3,Mark FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,annual,book}).Single();
        Require(annualMark["M1"]==null && Convert.ToDecimal(annualMark["M2"])==75 && Convert.ToDecimal(annualMark["Mark"])==75 && Convert.ToDecimal(annualMark["M3"])==5,"Annual manual mark did not preserve the original M2/total convention and hidden component.");
        Open();grid=Field<GridEX>(form,"w");
        Require(Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==75,"Annual mark did not reload in its displayed input column.");
        EditGridCell(grid,grid.Row,"m1","80");Click(form,"p");
        Require(Convert.ToDecimal(db.Scalar("SELECT Mark FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{student,annual,book}))==75 && Convert.ToDecimal(Value(student,exam))==27m,"Annual Cancel modified saved annual or half-year marks.");
        Click(form,"m_d");
        log("PASS original individual mark entry validates bounds, rejects fractional input without data loss, rolls back all subjects on late SQL failure, retries pending edits, remains responsive under a row lock, verifies actual annual 100-point M2 storage, clears only the selected mark, reloads edits and preserves peer/other-exam marks");
    }
    private static void Attendance(Form form,Database db,Action<string> log)
    {
        string period=((asdp)form).q,other=period=="1"?"2":"1";
        int days=period=="1"?100:200;
        Require(Field<Control>(form,"o").Text==days.ToString(),"Attendance did not load the configured period's days.");
        int id=Convert.ToInt32(db.Scalar("SELECT y.id FROM tYear_Student y JOIN tStudent s ON s.id=y.xStudent WHERE s.Code=5993001 AND y.xYear=1412"));
        string OtherPeriod()=>string.Join("|",db.Query("SELECT hazer"+other+",Ghayeb"+other+",Mariz"+other+",rokhsat"+other+" FROM tYear_Student WHERE id=@p0",new object[]{id}).Single().Values.Select(Convert.ToString));
        string otherBefore=OtherPeriod();
        Select(form,id,"g");var grid=Field<GridEX>(form,"g");int row=grid.Row;
        EditGridCell(grid,row,"ghayeb","۵");EditGridCell(grid,row,"Mariz","٣");EditGridCell(grid,row,"rokhsat","2");
        Require(Convert.ToInt32(grid.GetRow(row).Cells["hazer"].Value)==days-10,"Editing absence categories did not recalculate present days.");
        // Hold a real SQL row lock. Only a responsive UI timer can release it.
        using(var connection=db.Open())
        using(var transaction=connection.BeginTransaction())
        {
            using var command=connection.CreateCommand();command.Transaction=transaction;
            command.CommandText="UPDATE tYear_Student SET hazer"+period+"=hazer"+period+" WHERE id=@id";
            command.Parameters.AddWithValue("@id",id);command.ExecuteNonQuery();
            bool heartbeat=false;using var release=new Timer{Interval=350};
            release.Tick+=(sender,args)=>{release.Stop();transaction.Rollback();heartbeat=true;};release.Start();
            Dialog(()=>Click(form,"m"),"تعداد 2 ردیف انجام شد",1);
            Require(heartbeat,"Attendance Save blocked the UI while SQL was waiting.");
        }
        void AssertSaved()
        {
            var saved=db.Query("SELECT hazer"+period+" AS present,Ghayeb"+period+" AS absent,Mariz"+period+" AS sick,rokhsat"+period+" AS leave FROM tYear_Student WHERE id=@p0",new object[]{id}).Single();
            Require(saved.Int("present")==days-10 && saved.Int("absent")==5 && saved.Int("sick")==3 && saved.Int("leave")==2,"Attendance Save did not preserve the known counts.");
            Require(OtherPeriod()==otherBefore,"Saving attendance overwrote the other period.");
        }
        AssertSaved();
        foreach(string invalid in new[]{days.ToString(),"-1"})
        {
            EditGridCell(grid,row,"hazer",invalid);
            Dialog(()=>Click(form,"m"),"تعداد 1 ردیف ثبت شد؛ 1 ردیف نامعتبر ثبت نشد",1);
            AssertSaved();
            Require(Convert.ToInt32(grid.GetRow(row).Cells["acp"].Value)==-1,"Invalid attendance row was not marked rejected.");
        }
        EditGridCell(grid,row,"hazer",(days-10).ToString());Dialog(()=>Click(form,"m"),"تعداد 2 ردیف انجام شد",1);AssertSaved();
        Click(form,"f");
        using var reopened=new asdp{q=period};reopened.Show();Select(reopened,id,"g");
        var reloaded=Field<GridEX>(reopened,"g");
        Require(Convert.ToInt32(reloaded.GetRow(reloaded.Row).Cells["hazer"].Value)==days-10,"Attendance did not reload saved counts after reopening.");
        Click(reopened,"f");
        log("PASS original attendance period"+period+" edits normalize Persian/Arabic digits, recalculate present days, reject negative/over-total rows without overwriting saved values, preserve the other period and reload committed counts");
    }
    private static void ChildPayment(Action open,Action<Form> exercise)=>ChildForm<asdae>(open,exercise);
    private static void ChildForm<T>(Action open,Action<Form> exercise) where T:Form
    {
        Exception failure=null;bool exercised=false;
        using var timer=new Timer{Interval=100};
        timer.Tick+=(sender,args)=>
        {
            var child=Application.OpenForms.Cast<Form>().FirstOrDefault(item=>item is T && item.Visible);
            if(child==null)return;
            timer.Stop();exercised=true;
            try{exercise(child);}
            catch(Exception error){failure=error;diagnostic("FAILED child workflow: "+error);}
            finally
            {
                // Preserve the first assertion failure instead of hiding it
                // behind a second unsaved-close dialog in this owned fixture.
                if(!child.IsDisposed){if(failure!=null)child.Dispose();else child.Close();}
            }
        };
        timer.Start();open();timer.Stop();
        Require(exercised,"Original button did not open the expected editor: "+typeof(T).Name+".");
        if(failure!=null)System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(failure).Throw();
    }
    private static void Payment(Form form,Database db,Action<string> log)
    {
        int student=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5992001"));
        Field<UIComboBox>(form,"ai").SelectedValue="1411";
        Select(form,student,"aa");
        string where=" WHERE xStudent=@p0 AND xYear=1411";
        int Count()=>Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tPaymentStudent"+where,new object[]{student}));
        int before=Count();string comment="فیس ' آزمایشی ; SELECT 1 --";
        ChildPayment(()=>Click(form,"m_j"),child=>
        {
            Field<Control>(child,"n").Text="1411/02/01";
            Dialog(()=>Click(child,"k"),"جهت ثبت پرداخت حداقل یکی از گزینه ها باید وارد شود",1);
            Require(Count()==before,"Empty payment inserted a record.");
            foreach(string invalid in new[]{"-1","1.5","2147483648"})
            {
                Field<Control>(child,"q").Text=invalid;
                Dialog(()=>Click(child,"k"),"مبلغ باید عدد صحیح غیرمنفی باشد و مجموع پرداخت از ۲۱۴۷۴۸۳۶۴۷ بیشتر نباشد",1);
                Require(Count()==before,"Invalid amount inserted a payment.");
            }
            Field<Control>(child,"q").Text="1";Field<Control>(child,"r").Text="2147483647";
            Dialog(()=>Click(child,"k"),"مبلغ باید عدد صحیح غیرمنفی باشد و مجموع پرداخت از ۲۱۴۷۴۸۳۶۴۷ بیشتر نباشد",1);
            Require(Count()==before,"Overflowing payment total inserted a record.");
            Field<Control>(child,"r").Text="";
            Field<Control>(child,"q").Text="400";
            Field<Control>(child,"n").Text="1411/13/01";
            Dialog(()=>Click(child,"k"),"تاریخ پرداخت اشتباه است",1);
            Require(Count()==before,"Invalid date inserted a payment.");
            Field<Control>(child,"n").Text="1411/02/01";
            Field<Control>(child,"q").Text="1001";
            Dialog(()=>Click(child,"k"),"مبلغ وارد شده برای فیس بالاتر از مقدار باقی مانده است",1);
            Require(Count()==before,"Overpayment inserted a record.");
            Field<Control>(child,"q").Text="۴۰۰";
            Field<Control>(child,"r").Text="٢٠";
            Field<Control>(child,"h").Text=comment;
            Dialog(()=>Click(child,"k"),"ثبت شد",1);
        });
        var row=db.Query("SELECT * FROM tPaymentStudent"+where,new object[]{student}).Single();
        int id=Convert.ToInt32(row["id"]);
        Require(Convert.ToInt32(row["Fee"])==400 && Convert.ToInt32(row["Transport"])==20 && Convert.ToString(row["comment"])==comment,"Original payment Save did not preserve amounts and quoted comment.");
        ChildPayment(()=>Click(form,"m_j"),child=>
        {
            Require(Field<Control>(child,"am").Text=="400" && Field<Control>(child,"an").Text=="600","Payment totals did not reload committed fee and remaining balance.");
            Field<Control>(child,"n").Text="1411/02/01";Field<Control>(child,"q").Text="100";
            Dialog(()=>Click(child,"k"),"در این تاریخ یک پرداخت ثبت شده است\n\nامکان ثبت بیشتر از یک پرداخت در هر روز برای شاگرد امکان پذیر نیست\n\nدر صورت نیاز ، پرداخت موجود در این تاریخ را اصلاح نمایید",1);
            Require(Count()==before+1,"Duplicate-date validation inserted another payment.");
            Click(child,"j");
        });
        Select(form,id,"x");
        ChildPayment(()=>Click(form,"u"),child=>
        {
            Require(Field<Control>(child,"q").Text=="400" && Field<Control>(child,"h").Text==comment,"Payment Edit did not reload the selected payment.");SaveGallery(child,"payment");
            Field<Control>(child,"q").Text="600";Dialog(()=>Click(child,"k"),"ثبت شد",1);
        });
        Require(Count()==before+1 && Convert.ToInt32(db.Scalar("SELECT Fee FROM tPaymentStudent WHERE id=@p0",new object[]{id}))==600,"Payment Edit did not update exactly the selected record.");
        Select(form,id,"x");
        ChildPayment(()=>Click(form,"u"),child=>
        {
            Require(Field<Control>(child,"am").Text=="600" && Field<Control>(child,"an").Text=="400","Edited payment totals did not reload.");
            Field<Control>(child,"q").Text="700";Click(child,"j");
        });
        Require(Convert.ToInt32(db.Scalar("SELECT Fee FROM tPaymentStudent WHERE id=@p0",new object[]{id}))==600,"Payment Cancel saved changes.");
        Select(form,id,"x");Dialog(()=>Click(form,"m_i"),"آيا از حذف مطمئن هستيد؟",7);
        Require(Count()==before+1,"Declining deletion removed the payment.");
        Dialog(()=>Click(form,"m_i"),"آيا از حذف مطمئن هستيد؟",6);
        Require(Count()==before && Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tPaymentStudent WHERE id=@p0",new object[]{id}))==0,"Confirmed payment deletion did not remove only the selected record.");
        log("PASS original payment buttons reject empty/invalid-date/overpayment/duplicate input, preserve quoted comments and separate amounts, recalculate balances, edit/cancel and respect deletion confirmation");
    }
    private static void People(string scenario,Form form,Database db,Action<string> log)
    {
        bool teacher=scenario=="teacher";
        string table=teacher ? "tTeacher" : "tDriver";
        string save=teacher ? "o" : "m_k";
        string nameField=teacher ? "m_n" : "m_j";
        string valueField=teacher ? "m_l" : "w";
        string valueColumn=teacher ? "fEmail" : "comment";
        int before=Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM "+table));
        Click(form,"m_d");
        if(teacher)
        {
            Field<CheckBox>(form,"z").Checked=true;
            Dialog(()=>Click(form,save),"نام خانوادگي را وارد کنيد",1);
            Field<Control>(form,"m_m").Text="آزمایشی";
        }
        string name=OriginalText.Normalize("آزمون ثبت "+scenario+" ' نقل");
        string value=teacher ? "o'neil@example.invalid" : "توضیح ' فارسی ; SELECT 1 --";
        string secret="test'only";
        Field<Control>(form,nameField).Text=name;
        Field<Control>(form,valueField).Text=value;
        if(teacher)Field<Control>(form,"w").Text=secret;
        Click(form,save);
        var saved=db.Query("SELECT * FROM "+table+" WHERE "+(teacher ? "fNamF" : "name")+"=@p0",new object[]{name}).Single();
        int id=Convert.ToInt32(saved["id"]);
        Require(Convert.ToString(saved[valueColumn])==value,"Quoted input was not saved as data.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM "+table))==before+1,"New did not insert exactly one record.");
        string searchField=teacher?"u":"p";
        Field<Control>(form,searchField).Text="'";
        Require(Field<GridEX>(form,"m_h").RowCount>0,"Quoted name search lost the matching persisted person.");
        Select(form,id,"m_h");
        Field<Control>(form,searchField).Text="' AND 1=0 --";
        Require(Field<GridEX>(form,"m_h").RowCount==0,"Search punctuation was executed as SQL instead of treated as data.");
        Field<Control>(form,searchField).Text="";
        // A second teacher must not inherit the first teacher's credentials from stale controls.
        if(teacher)
        {
            Click(form,"m_d");
            Require(Field<Control>(form,"m_l").Text=="" && Field<Control>(form,"w").Text=="","New teacher retained another teacher's credentials.");
            Click(form,"m_g");
        }
        Select(form,id,"m_h");
        Require(Field<UIButton>(form,"m_e").Enabled && Field<UIButton>(form,"m_c").Enabled,"Keyboard row selection did not enable Edit/Delete.");
        Click(form,"m_e");
        Require(Field<Control>(form,valueField).Text==value,"Edit did not load the selected record's saved fields.");
        if(teacher)Require(Field<Control>(form,"w").Text==secret,"Edit did not load the selected teacher's credentials.");
        string edited=teacher ? "edited'person@example.invalid" : "اصلاح ' دوم ; --";
        Field<Control>(form,valueField).Text=edited;
        Click(form,save);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM "+table))==before+1,"Edit inserted a duplicate record.");
        Require(Convert.ToString(db.Scalar("SELECT "+valueColumn+" FROM "+table+" WHERE id=@p0",new object[]{id}))==edited,"Edit did not update the selected record.");
        if(teacher)Require(Convert.ToString(db.Scalar("SELECT fPassword FROM tTeacher WHERE id=@p0",new object[]{id}))==secret,"Editing teacher details changed the saved password.");
        Select(form,id,"m_h");
        Require(Field<UIButton>(form,"m_e").Enabled && Field<UIButton>(form,"m_c").Enabled,"Keyboard row selection did not enable Edit/Delete.");
        Click(form,"m_e");
        Field<Control>(form,valueField).Text="cancelled";Click(form,"m_g");
        Require(Convert.ToString(db.Scalar("SELECT "+valueColumn+" FROM "+table+" WHERE id=@p0",new object[]{id}))==edited,"Cancel saved unsaved changes.");
        Select(form,id,"m_h");
        string question=teacher ? "آيا از حذف معلم مطمئن هستيد؟" : "آيا از حذف راننده مطمئن هستيد؟";
        Dialog(()=>Click(form,"m_c"),question,7);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM "+table+" WHERE id=@p0",new object[]{id}))==1,"Declining deletion removed the record.");
        Dialog(()=>Click(form,"m_c"),question,6);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM "+table))==before,"Deletion removed the wrong records.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM "+table+" WHERE id=@p0",new object[]{id}))==0,"Deletion did not remove the selected record.");
        log("PASS original "+scenario+" New/Edit/Save/Cancel/Delete buttons preserve quoted text, update exactly one selected record and respect deletion confirmation");
    }
    private static void Backup(Form form,Database db,Action<string> log)
    {
        string folder=System.IO.Path.Combine(System.IO.Path.GetTempPath(),"FreeSmsBackupUi_"+Guid.NewGuid().ToString("N"));
        System.IO.Directory.CreateDirectory(folder);
        try
        {
            Field<Control>(form,"m_e").Text="";
            Dialog(()=>Click(form,"m_d"),"مسیر فایل پشتیبان را مشخص کنید",1);
            db.Execute("CREATE TABLE native_ui_backup_fixture(id int PRIMARY KEY,value nvarchar(100))");
            db.Execute("INSERT INTO native_ui_backup_fixture VALUES(1,N'پیش از پشتیبان')");
            string path=System.IO.Path.Combine(folder,"نسخه ' فارسی.bak");Field<Control>(form,"m_e").Text=path;
            Dialog(()=>Click(form,"m_d"),"تهيه نسخه پشتيبان با موفقیت انجام شد",1);
            Require(System.IO.File.Exists(path),"Original backup button did not create the selected file.");
            var header=db.Query("RESTORE HEADERONLY FROM DISK=@p0",new object[]{path}).Single();
            Require(Convert.ToString(header["DatabaseName"])==new Microsoft.Data.SqlClient.SqlConnectionStringBuilder(db.ConnectionString).InitialCatalog,"Backup button saved a different database.");
            db.Execute("UPDATE native_ui_backup_fixture SET value=N'پس از پشتیبان'");
            new DatabaseMaintenance(db).Restore(path);
            Require(Convert.ToString(db.Scalar("SELECT value FROM native_ui_backup_fixture WHERE id=1"))=="پیش از پشتیبان","Backup from the actual button did not restore its actual record.");
            string originalUser=asdaj.l;
            try
            {
                asdaj.l="2";Field<Control>(form,"l").Text=path;
                Dialog(()=>Click(form,"k"),"اجازه بازگردانی دارد admin فقط کاربر",1);
                Require(Convert.ToString(db.Scalar("SELECT value FROM native_ui_backup_fixture WHERE id=1"))=="پیش از پشتیبان","Non-admin restore action altered the database.");
            }
            finally{asdaj.l=originalUser;}
            db.Execute("UPDATE native_ui_backup_fixture SET value=N'پیش از دکمهٔ بازگردانی'");
            Dialog(()=>Click(form,"k"),"بازگردانی نسخهٔ پشتیبان انجام شد. برنامه را دوباره اجرا کنید.",1,timeoutSeconds:300);
            Require(Convert.ToString(db.Scalar("SELECT value FROM native_ui_backup_fixture WHERE id=1"))=="پیش از پشتیبان","Original admin restore button did not restore the saved record.");
            db.Execute("DROP TABLE native_ui_backup_fixture");
            log("PASS actual async backup button validates path, backs up configured bank to quoted Persian path, produces restorable records, blocks non-admin restore and completes actual admin restore");
        }
        finally
        {
            try{System.IO.Directory.Delete(folder,true);}
            catch(System.IO.IOException){log("Diagnostic backup media retained because SQL still holds the file; do not mask the workflow result: "+folder);}
        }
    }
    private static void StudentDelete(Form form, Database db, Action<string> log)
    {
        int id = Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5991001"));
        int before = Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent"));
        Require(id > 0, "Student deletion fixture was not created.");
        Select(form,id,"av");
        Dialog(() => Click(form,"m_g"), "آيا از حذف شاگرد مطمئن هستيد؟",6);
        string warning = "با حذف شاگرد کلیه اطلاعات مربوط به او حذف خواهد شد\n\nآیا از حذف شاگرد اطمینان دارید؟";
        Dialog(() => Click(form,"ai"), warning,7);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tYear_Student WHERE xStudent=@p0",new object[]{id})) == 1,"Declining deletion removed enrolment.");
        Click(form,"ad");
        log("PASS declining student deletion and cancelling panel preserve enrolment");
        Dialog(() => Click(form,"m_g"), "آيا از حذف شاگرد مطمئن هستيد؟",6);
        Dialog(() => Click(form,"ai"), warning,6);
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent WHERE id=@p0",new object[]{id})) == 0,"Student delete button did not remove the selected student.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tYear_Student WHERE xStudent=@p0",new object[]{id})) == 0,"Student delete left enrolment behind.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudent")) == before-1,"Student delete modified unrelated records.");
        Require(Convert.ToString(db.Scalar("SELECT FName FROM tStudent WHERE Code=5991002"))=="شاگرد محفوظ", "Deletion modified the other student's identity.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tYear_Student y JOIN tStudent s ON s.id=y.xStudent WHERE s.Code=5991002 AND y.xYear=1410"))==1, "Deletion removed another student's enrolment.");
        Require(Convert.ToInt32(db.Scalar("SELECT COUNT(*) FROM tStudentImg WHERE xStudent=@p0",new object[]{id}))==0,"Student deletion left the selected photo behind.");
        int peer=Convert.ToInt32(db.Scalar("SELECT id FROM tStudent WHERE Code=5991002"));
        Require(new SchoolService(db,new Session(1410)).StudentImage(peer)?.SequenceEqual(FixturePhoto(SecondPhotoColor))==true,"Student deletion changed the other student's photo.");
        log("PASS original student deletion buttons preserve the other student and complete against the supplied database edition");
    }
    private static void School(Form form, Database db, Action<string> log)
    {
        var values = new Dictionary<string,string> { ["o"]="کابل ' آزمون", ["m"]="ولسوالی ; آزمون", ["j"]="مدیر ' آزمون", ["k"]="مکتب آزمون .NET" };
        foreach (var value in values) Field<Control>(form,value.Key).Text=value.Value;
        Dialog(() => Click(form,"f"), "ثبت شد", 1);
        var row = db.Query("SELECT Ost,cty,Foter1,sch FROM tParmetr").Single();
        foreach (var pair in new[] { ("o","Ost"), ("m","cty"), ("j","Foter1"), ("k","sch") })
            Require(Convert.ToString(row[pair.Item2]) == values[pair.Item1], "School field did not round trip: " + pair.Item2);
        log("PASS school Save button persists every field, including quotes");
        using var reopened = new asdac();
        reopened.Show();
        foreach (var value in values) Require(Field<Control>(reopened,value.Key).Text == value.Value, "Reopened school form lost saved field: " + value.Key);
        reopened.Close();
        log("PASS school form reloads all saved fields after reopening");
    }
    private delegate bool WindowCallback(IntPtr window, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool EnumThreadWindows(uint thread, WindowCallback callback, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool EnumChildWindows(IntPtr window, WindowCallback callback, IntPtr parameter);
    [DllImport("user32.dll")] private static extern bool IsWindowVisible(IntPtr window);
    [DllImport("user32.dll", CharSet=CharSet.Unicode)] private static extern int GetClassName(IntPtr window, StringBuilder name, int size);
    [DllImport("user32.dll", CharSet=CharSet.Unicode)] private static extern int GetWindowText(IntPtr window, StringBuilder text, int size);
    [DllImport("user32.dll")] private static extern int GetDlgCtrlID(IntPtr window);
    [DllImport("user32.dll")] private static extern IntPtr SetActiveWindow(IntPtr window);
    [DllImport("user32.dll")] private static extern bool PostMessage(IntPtr window, uint message, IntPtr wparam, IntPtr lparam);
    [DllImport("kernel32.dll")] private static extern uint GetCurrentThreadId();
    private static void Dialog(Action action, string expectedText, int buttonId, string requiredText = null,int timeoutSeconds=45)
    {
        bool observed = false, logged = false;
        diagnostic("EXPECT dialog: " + expectedText);
        using var timer = new Timer {Interval=100};
        timer.Tick += (s,e) => EnumThreadWindows(GetCurrentThreadId(), (window,p) =>
        {
            var name = new StringBuilder(128); GetClassName(window,name,name.Capacity);
            if (!IsWindowVisible(window) || name.ToString() != "#32770") return true;
            var texts = new List<string>();
            var buttons = new List<(IntPtr Handle,int Id,string Text)>();
            EnumChildWindows(window,(child,unused) =>
            {
                var text = new StringBuilder(2048); GetWindowText(child,text,text.Capacity); texts.Add(text.ToString());
                var kind = new StringBuilder(128); GetClassName(child,kind,kind.Capacity);
                if (kind.ToString().IndexOf("button",StringComparison.OrdinalIgnoreCase)>=0)
                    buttons.Add((child,GetDlgCtrlID(child),text.ToString().Replace("&","").Trim()));
                return true;
            },IntPtr.Zero);
            // Never acknowledge an unexpected message or an unrelated window.
            if (!logged) { logged = true; diagnostic("OBSERVED dialog child texts: " + string.Join(" | ",texts)); }
            if (!texts.Any(text => requiredText == null ? text.Trim() == expectedText : text.StartsWith(expectedText,StringComparison.Ordinal) && text.Contains(requiredText,StringComparison.Ordinal))) return true;
            string[] labels = buttonId == 1 ? new[] { "OK", "تأیید", "تایید" } : buttonId == 6 ? new[] { "Yes", "بله" } : buttonId == 7 ? new[] { "No", "خیر" } : Array.Empty<string>();
            // Some native dialog hosts nest their buttons; GetDlgItem(root,id)
            // cannot find those. Resolve the actual descendant button first.
            var selected = buttons.FirstOrDefault(button => labels.Contains(button.Text,StringComparer.OrdinalIgnoreCase));
            if (selected.Handle == IntPtr.Zero) selected = buttons.FirstOrDefault(button => button.Id == buttonId);
            if (selected.Handle == IntPtr.Zero)
            {
                diagnostic("FAILED expected dialog button missing; available=" + string.Join(" | ",buttons.Select(button => button.Id + ":" + button.Text)));
                Environment.Exit(1);
            }
            observed = true; timer.Stop();
            SetActiveWindow(window);
            Require(PostMessage(selected.Handle,0x00F5,IntPtr.Zero,IntPtr.Zero), "Could not queue expected dialog button click."); // BM_CLICK
            diagnostic("RESPOND expected dialog, requested=" + buttonId + " actual=" + selected.Id + ":" + selected.Text);
            return false;
        },IntPtr.Zero);
        timer.Start(); action();
        var deadline=System.Diagnostics.Stopwatch.StartNew();
        while(!observed && deadline.Elapsed<TimeSpan.FromSeconds(timeoutSeconds))
        {Application.DoEvents();System.Threading.Thread.Sleep(10);}
        Require(observed,"Expected dialog did not appear: " + expectedText);
    }
}
