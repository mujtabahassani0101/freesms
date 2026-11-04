using System.Data;
using FreeSms.Core;

internal static class WorkbookChecks
{
    internal static void Verify(string root, Action<string, Action> check)
    {
        string fixtures = Path.Combine(root, "validation", "functional", "workbooks");
        Record StudentRow(int index=0)
        {
            var row=ImportWorkbook.Read(Path.Combine(fixtures,"students-save.xlsx"),WorkbookImportKind.Students).Rows[index];
            var result=new Record();foreach(DataColumn column in row.Table.Columns)result[column.ColumnName]=row[column];return result;
        }
        void RejectStudent(Record row,int discount=1)
        {
            try{WorkbookStudentEntry.Create(row,discount);}
            catch(ValidationException){return;}
            throw new Exception("Accepted invalid student workbook input.");
        }
        check("Recovered workbook fee allocation keeps full, discounted, zero, partial and large ninth-month remainder semantics",()=>
        {
            int[][] expected={Enumerable.Repeat(100,9).ToArray(),[100,100,50,0,0,0,0,0,0],new int[9],[25,0,0,0,0,0,0,0,0],[100,100,100,100,100,100,100,100,200],Enumerable.Repeat(100,9).ToArray()};
            for(int i=0;i<6;i++)
            {
                var row=WorkbookStudentEntry.Create(StudentRow(i),1);
                if(!row.Fees.SequenceEqual(expected[i]) || row.Fees.Sum()!=row.Total || row.Discount!=(i is 0 or 5?0:1))throw new Exception("Recovered fee allocation changed.");
            }
            if(WorkbookStudentEntry.Create(StudentRow(),0).Discount!=0)throw new Exception("Full fee incorrectly requires a discount.");
            RejectStudent(StudentRow(1),0);
        });
        check("Student workbook input preserves BigInt, quotes, phones, kindergarten and optional identifiers",()=>
        {
            var first=WorkbookStudentEntry.Create(StudentRow(),1);var second=WorkbookStudentEntry.Create(StudentRow(1),1);
            if(first.Code!=60002010001L || first.FirstName!="نام ' محفوظ 1" || first.ClassName!="صنف ' اکسل" || first.MobileFather!="0700000000"
                || second.Gender!=-1 || second.Sort!=null || second.NumberAsas!=null || WorkbookStudentEntry.Create(StudentRow(2),1).Grade!=100)throw new Exception("Student workbook values changed.");
            foreach(var item in new (string,object)[]{("code","9223372036854775808"),("code",""),("paye",13),("class",""),("jens",2),("stdfees",-1),("stdfeeskoll","1.5"),("mainfees",""),("payment",-1),("dakhele","2147483648"),("exam","1.1"),("uniform",-1),("mobilefather","123456789012"),("numberasas","1.5"),("sort",-1)})
            {var row=StudentRow();row[item.Item1]=item.Item2;RejectStudent(row);}
        });
        check("Workbook payment dates use valid Persian calendar dates, stable weekday text and reject malformed dates",()=>
        {
            var date=WorkbookPaymentDate.Parse("۱۴۲۰/۰۱/۰۱");
            if(date.Text!="1420/01/01" || date.Weekday.Length==0)throw new Exception("Persian date normalization failed.");
            foreach(string invalid in new[]{"1420/13/01","1420/07/31","1420/00/00","1420/1/01","","not a date"})
            {try{WorkbookPaymentDate.Parse(invalid);}catch(ValidationException){continue;}throw new Exception("Accepted invalid payment date.");}
        });
        check("Office-free OOXML student preview reads each row once, keeps quotes/leading zeros and skips only blank/no-class rows", () =>
        {
            var table = ImportWorkbook.Read(Path.Combine(fixtures, "students-valid.xlsx"), WorkbookImportKind.Students);
            if (table.Rows.Count != 2 || (string)table.Rows[0]["code"] != "001234" || (string)table.Rows[1]["code"] != "۱۲۳۵"
                || (string)table.Rows[0]["name"] != "نام ' آزمون" || (string)table.Rows[0]["mobilefather"] != "0700000000"
                || table.Columns.Cast<DataColumn>().Any(column => column.DataType != typeof(string))) throw new Exception("Student workbook values/count changed.");
        });
        check("Office-free OOXML mark preview keeps zero, fractions, empty values and the Sheet1 contract", () =>
        {
            var table = ImportWorkbook.Read(Path.Combine(fixtures, "marks-valid.xlsx"), WorkbookImportKind.Marks);
            if (table.Rows.Count != 3 || (string)table.Rows[0]["code"] != "001234" || (string)table.Rows[0]["mark"] != "25.5"
                || (string)table.Rows[1]["mark"] != "0" || !table.Rows[2].IsNull("mark")) throw new Exception("Mark workbook values/count changed.");
            if (ImportWorkbook.Read(Path.Combine(fixtures, "marks-empty.xlsx"), WorkbookImportKind.Marks).Rows.Count != 0) throw new Exception("Empty workbook gained a row.");
        });
        check("Malformed Excel contracts, cell errors, duplicate/reserved/unnamed headers and missing Sheet1 reject before any preview is returned", () =>
        {
            foreach (string name in new[] { "corrupt", "duplicate-header", "missing-header", "unnamed-data", "reserved-header", "cell-error", "missing-sheet" })
            {
                try { ImportWorkbook.Read(Path.Combine(fixtures, name + ".xlsx"), WorkbookImportKind.Marks); }
                catch (ValidationException) { continue; }
                throw new Exception("Accepted malformed workbook: " + name);
            }
        });
        check("Recovered binary XLS student/mark examples parse without ACE, Jet or Excel", () =>
        {
            string directory = Path.Combine(root, "dotnet", "FreeSms.Original.Windows");
            foreach (var item in new[] { ("xls/Example.xls", WorkbookImportKind.Students), ("xls/ExampleMark.xls", WorkbookImportKind.Marks) })
            {
                var table = ImportWorkbook.Read(Path.Combine(directory, item.Item1), item.Item2);
                if (table.Columns.Count < 5) throw new Exception("Recovered XLS contract was lost: " + item.Item1);
            }
        });
        check("Workbook mark input preserves Persian fractions/zero/blank and rejects overflow, nonfinite and invalid identifiers", () =>
        {
            var row=WorkbookMarkEntry.Create("۶۰۰۰۱۰۱","۶۰۰۰۱۰۱","۲۵٫۵",0,40);
            if(row.Code!=6000101 || row.CourseCode!=6000101 || row.Mark!=25.5
                || WorkbookMarkEntry.Create(1,1,0,0,40).Mark!=0 || WorkbookMarkEntry.Create(1,1,DBNull.Value,0,40).Mark!=null)
                throw new Exception("Workbook mark input changed its values.");
            foreach(var invalid in new object?[][]{["100000000000000",1,1],[0,1,1],[1,0,1],[1,1,"NaN"],[1,1,"Infinity"],[1,1,41],[1,1,-1]})
            {
                try { WorkbookMarkEntry.Create(invalid[0],invalid[1],invalid[2],0,40); }
                catch(ValidationException){continue;}
                throw new Exception("Accepted invalid workbook mark input.");
            }
        });
    }
}
