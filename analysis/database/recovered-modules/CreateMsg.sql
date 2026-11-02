--CreateMsg 1,103,'7,8,9,10','1',1,1,1,N'',N'سلام',N'باي',1
CREATE procedure CreateMsg
@sendTo smallint,
@test int,
@xbook varchar(200),
@xClass varchar(200),
@gBook  smallint,
@mKolli smallint,
@gkolli smallint,
@heder1 nvarchar(200),
@heder2 nvarchar(200),
@foter nvarchar(200),
@NameStd smallint   with encryption
as

SELECT     tMark.xStudent, tBook.Name, ROUND(tMark.Mark, 2) AS mark,tMark.gkoll,typ, tBook.sort
into #tmpMark1
FROM         tMark INNER JOIN tstudent on tMark.xstudent=tstudent.id
                   INNER JOIN tBook ON tMark.xbook = tBook.id
WHERE tMark.mark is not null  and tstudent.xClass in( select * from SplitNumber(@xClass)) and  (tMark.Xtest = @test) and tMark.xbook in( select * from SplitNumber(@xbook))

if (@mKolli=1)
  insert into #tmpMark1  SELECT tMarkDoreh.xStudent,N'معدل', ROUND(tMarkDoreh.MarkDoreh, 2) AS mark,null, tMarkDoreh.typ,1000 FROM tMarkDoreh INNER JOIN tstudent 
                on tMarkDoreh.xstudent=tstudent.id
   WHERE  tstudent.xClass in( select * from SplitNumber(@xClass)) and    tMarkDoreh.Xtest = @test and tMarkDoreh.typ=5

if (@gkolli=1)
  insert into #tmpMark1  SELECT tMarkDoreh.xStudent,N'رتبه کل', tMarkDoreh.gPaye AS mark,null, tMarkDoreh.typ,1001 FROM tMarkDoreh INNER JOIN tstudent 
                on tMarkDoreh.xstudent=tstudent.id
   WHERE  tstudent.xClass in( select * from SplitNumber(@xClass)) and    tMarkDoreh.Xtest = @test and tMarkDoreh.typ=5


create table #tmpmsg(xStudent bigint,msg nvarchar(1000) COLLATE Arabic_CI_AS NULL)

declare @xTestStd bigint
declare @Tmp_xTestStd bigint
declare @mark float
declare @gkoll int
declare @book nvarchar(100)
declare @book2 nvarchar(1000)

 if (@heder1<>'')
    set @heder1=@heder1+' '
 if (@heder2<>'')
    set @heder2=+@heder2+CHAR(13)+CHAR(10)
 if (@foter<>'')
    set @foter=CHAR(13)+CHAR(10)+@foter

set @Tmp_xTestStd=-1

declare Book cursor for
 select xStudent,Name,mark,gkoll from #tmpMark1 order by xStudent ,sort


  open Book
    fetch next from Book into 
     @xTestStd,@book,@mark,@gkoll

while (@@fetch_status = 0)
     begin
         if(@Tmp_xTestStd<>@xTestStd)
           begin
             if(@Tmp_xTestStd>-1)
             begin
                 insert into #tmpmsg(xStudent,msg) values(@Tmp_xTestStd,@book2)         
             end
             set @book2=''
           end
        
        if(@book2<>'')
          set @book2=@book2+CHAR(13)+CHAR(10) 
       
       if(@mark<0)
           set @book2=@book2+@book+CHAR(13)+CHAR(10)+cast( abs(@mark) as varchar)+'(منفي)'
       else
           set @book2=@book2+@book+cast(@mark as varchar)
   
       if(@gBook=1 and @gkoll is not null)
          set @book2=@book2+CHAR(13)+CHAR(10) +'رتبه'+cast(@gkoll as varchar)
       set @Tmp_xTestStd=@xTestStd

      fetch next from Book into 
      @xTestStd,@book,@mark,@gkoll
   end
  close Book
 deallocate Book

   if(@Tmp_xTestStd>-1)
             begin
            
                insert into #tmpmsg(xStudent,msg) values(@Tmp_xTestStd,@book2)         
             end


declare @massege nvarchar (1000)
set @massege=''''+@heder1+''''
if(@NameStd=1)
  set @massege=@massege+' '+'+tstudent.fname+'' ''+tstudent.lname+'' '''
set @massege=@massege+CHAR(13)+CHAR(10) +'+'''+@heder2+'''+#tmpmsg.msg+'
set @massege=@massege+'+'''+@foter+''''
--print @massege
declare @sql nvarchar(1000)
if(@sendTo=1)
set @sql='select tstudent.MobileFather as [to],'+@massege+' as Message,tstudent.fname+'' ''+tstudent.lname as name from #tmpmsg
   inner join tstudent on #tmpmsg.xstudent=tstudent.id'

else if(@sendTo=2)
set @sql='select tstudent.MobileMother as [to],'+@massege+' as Message,tstudent.fname+'' ''+tstudent.lname as name from #tmpmsg
   inner join tstudent on #tmpmsg.xstudent=tstudent.id'
else if(@sendTo=0)
 set @sql='select tstudent.MobileFather as [to],'+@massege+' as Message ,tstudent.fname+'' ''+tstudent.lname as name from #tmpmsg
   inner join tstudent on #tmpmsg.xstudent=tstudent.id 
 union
 select tstudent.MobileMother as [to],'+@massege+' as Message,tstudent.fname+'' ''+tstudent.lname as name from #tmpmsg
  inner join tstudent on #tmpmsg.xstudent=tstudent.id'

print @sqlexec (@sql)
drop table #tmpMark1
drop table #tmpmsg