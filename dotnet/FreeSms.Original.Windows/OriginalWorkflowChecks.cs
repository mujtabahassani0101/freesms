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
    internal static void PrepareMarkEntryFixture(Database db)
    {
        var school=new SchoolService(db,new Session(1414));school.SetYear(1414);
        var used=new HashSet<int>(db.Query("SELECT sortRpt FROM tClass WHERE sortRpt IS NOT NULL").Select(row=>Convert.ToInt32(row["sortRpt"])));
        int order=30000;while(used.Contains(order))order++;
        Require(order<=32767,"No available mark fixture class order.");
        int classroom=school.SaveClass(new Record{["name"]="صنف ورود نمره",["xpaye"]=1,["fee"]=0,["shift"]=1,["sortRpt"]=order});
        var entities=new EntityService(school);
        int book=entities.Save("books",new Record{["xPaye"]=1,["Name"]="مضمون ورود نمره",["vahed"]=1,["timeWeek"]=1,["Type"]=1,["sort"]=30001,["SortOneEntry"]=30001,["codedars"]=5995001,["Vezarat"]=true});
        db.Execute("UPDATE tBook SET showOneEntry=1 WHERE id=@p0",new object[]{book});
        int teacher=entities.Save("teachers",new Record{["fNamF"]="استاد نمره",["fNamL"]="آزمون",["fEmail"]="",["fPassword"]=""});school.AssignTeacher(classroom,book,teacher);
        foreach(int code in new[]{5995001,5995002})
            school.SaveStudent(new Record{["FName"]=code==5995001?"شاگرد محفوظ نمره":"شاگرد ورود نمره",["LName"]="پدر نمره",["PName"]="پدرکلان نمره",["Code"]=code,["NumberAsas"]=code,["xPaye"]=1,["xClass"]=classroom,["Status"]=1,["Jens"]=0,["Fee1"]=0});
        foreach(var item in new[]{(5995001,1,10),(5995002,2,15)})
        {
            int exam=Convert.ToInt32(db.Scalar("SELECT id FROM tExam WHERE xYear=1414 AND term=@p0",new object[]{item.Item2}));
            var result=db.Call("sp_tMark_insertUpdate_FromXls_Af",new Record{["xuser"]=1,["code"]=item.Item1.ToString(),["codedars"]=5995001,["Xtest"]=exam,["xYear"]=1414,["Mark"]=item.Item3});
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
        int firstPhoto=0,secondPhoto=0;
        for(int page=0;page<document.PageCount;page++)
        {
            string path=System.IO.Path.Combine(directory,scenario+"-page-"+(page+1)+".png");document.SavePageImage(path,page,100);
            if(!photos)continue;
            using var bitmap=new System.Drawing.Bitmap(path);
            for(int y=0;y<bitmap.Height;y+=4)for(int x=0;x<bitmap.Width;x+=4)
            {
                int pixel=bitmap.GetPixel(x,y).ToArgb();
                if(pixel==FirstPhotoColor.ToArgb())firstPhoto++;
                if(pixel==SecondPhotoColor.ToArgb())secondPhoto++;
            }
        }
        if(photos)Require(firstPhoto>50 && secondPhoto>50,"Rendered report pages omitted or mixed the two students' persisted photos.");
    }
    internal static void Run(string scenario, Form form, Database db, Action<string> log)
    {
        diagnostic = log;
        if (scenario == "discount") Discount(form, db, log);
        else if (scenario == "school") School(form, db, log);
        else if (scenario == "class") ClassManagement(form,db,log);
        else if (scenario == "authentication") Authentication(db,log);
        else if (scenario == "student-delete") StudentDelete(form, db, log);
        else if (scenario == "student-edit") StudentEdit(form,db,log);
        else if (scenario == "backup") Backup(form,db,log);
        else if (scenario == "teacher" || scenario == "driver") People(scenario,form,db,log);
        else if (scenario == "payment") Payment(form,db,log);
        else if (scenario == "mark-entry") MarkEntry(form,db,log);
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
            Select(form,id,"av");
            ChildForm<asdat>(()=>Click(form,"v"),child=>
            {
                Require(Field<Control>(child,"m_w").Text==asdaj.b("شاگرد ثبت نام"),"Edit did not reload the saved student.");
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
    private static void ClassManagement(Form form,Database db,Action<string> log)
    {
        int peer=Convert.ToInt32(db.Scalar("SELECT id FROM tClass WHERE xYear=1416 AND name=@p0",new object[]{asdaj.b("صنف محفوظ مدیریت")}));
        int peerOrder=Convert.ToInt32(db.Scalar("SELECT sortRpt FROM tClass WHERE id=@p0",new object[]{peer}));
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
        Select(form,id,"m_c");Click(form,"m_h");Require(Field<Control>(form,"ad").Text=="150","Class Edit did not reload the fee.");
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
            Dialog(()=>{using var denied=new asdat();denied.ShowDialog();},"شما مجوز ورود به این بخش را ندارید",1);
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
            log("PASS original login rejects empty/wrong/legacy override passwords, changes passwords safely, authenticates the new password, loads limited section/grade permissions, opens permitted forms and rejects forbidden sections and unconfigured accounts");
        }
        finally
        {
            if(temporaryUser>0)db.Execute("DELETE FROM tuser WHERE id=@p0",new object[]{temporaryUser});
            db.Execute("UPDATE tuser SET pwd=@p0,pw=@p1 WHERE id=1",new object[]{original["pwd"],original["pw"]});
            asdaj.l=beforeUser;asdaj.m=beforePermissions;asdaj.n=beforeGrades;
        }
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
        }
        void Save()
        {
            var students=Field<GridEX>(form,"m_i");bool next=students.Row<students.RowCount-1;
            Dialog(()=>Click(form,"o"),next?"اطلاعات ذخیره شد . آیا مایل هستید نفر بعدی نمایش داده شود":"اطلاعات ذخیره شد",next?7:1);
        }
        object Value(int id,int test)=>db.Scalar("SELECT M1 FROM tMark WHERE xStudent=@p0 AND Xtest=@p1 AND xbook=@p2",new object[]{id,test,book});
        Open();var grid=Field<GridEX>(form,"w");
        EditGridCell(grid,grid.Row,"m1","۲۵");Save();
        Require(Convert.ToDecimal(Value(student,exam))==25,"Original mark Save did not persist the entered Persian digits.");
        Open();grid=Field<GridEX>(form,"w");
        Require(Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==25,"Mark entry did not reload the saved mark.");
        EditGridCell(grid,grid.Row,"m1","28");Click(form,"p");
        Require(Convert.ToDecimal(Value(student,exam))==25,"Cancel committed an edited mark.");
        Open();grid=Field<GridEX>(form,"w");EditGridCell(grid,grid.Row,"m1","28");Save();
        Require(Convert.ToDecimal(Value(student,exam))==28,"Original mark Edit did not update the selected mark.");
        Require(Convert.ToDecimal(Value(peer,exam))==10 && Convert.ToDecimal(Value(student,other))==15,"Mark entry changed a peer or another exam.");
        Open();grid=Field<GridEX>(form,"w");
        Require(Convert.ToDecimal(grid.GetRow(grid.Row).Cells["m1"].Value)==28,"Edited mark was not persisted on reopening the entry panel.");
        Click(form,"p");Click(form,"m_d");
        log("PASS original individual mark entry saves Persian digits, reloads edits, cancels safely and preserves peer and other-exam marks");
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
            catch(Exception error){failure=error;}
            finally{if(!child.IsDisposed)child.Close();}
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
            Require(Field<Control>(child,"q").Text=="400" && Field<Control>(child,"h").Text==comment,"Payment Edit did not reload the selected payment.");
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
        string name=asdaj.b("آزمون ثبت "+scenario);
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
            Dialog(()=>Click(form,"k"),"بازگردانی نسخهٔ پشتیبان انجام شد. برنامه را دوباره اجرا کنید.",1);
            Require(Convert.ToString(db.Scalar("SELECT value FROM native_ui_backup_fixture WHERE id=1"))=="پیش از پشتیبان","Original admin restore button did not restore the saved record.");
            db.Execute("DROP TABLE native_ui_backup_fixture");
            log("PASS actual async backup button validates path, backs up configured bank to quoted Persian path, produces restorable records, blocks non-admin restore and completes actual admin restore");
        }
        finally{System.IO.Directory.Delete(folder,true);}
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
    private static void Dialog(Action action, string expectedText, int buttonId, string requiredText = null)
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
        while(!observed && deadline.Elapsed<TimeSpan.FromSeconds(45))
        {Application.DoEvents();System.Threading.Thread.Sleep(10);}
        Require(observed,"Expected dialog did not appear: " + expectedText);
    }
}
