
--CreateMsgTelegram 0,106,'30,40,44,45','14',1,1,1,1,N'',N'سلام',N'',1,1,1,1,1
create procedure dbo.CreateMsgTelegram
@sendTo smallint,
@test int,
@xbook varchar(200),
@xClass varchar(200),
@gBook  smallint,
@gBookClass  smallint,
@mKolli smallint,
@gkolli smallint,
@gkolliClass smallint,
@heder1 nvarchar(200),
@heder2 nvarchar(200),
@foter nvarchar(200),
@NameStd smallint,
@date nvarchar(10),	
@time nvarchar(10),
@SendTest bit with encryption
as

SELECT     tMark.xStudent, tBook.Name, ROUND(tMark.Mark, 2) AS mark,tMark.gClass,tMark.gkoll,typ, tBook.sort
into #tmpMark1
FROM         tMark INNER JOIN tstudent on tMark.xstudent=tstudent.id
                   INNER JOIN tBook ON tMark.xbook = tBook.id
WHERE tMark.mark is not null  and tstudent.xClass in( select * from SplitNumber(@xClass)) and  (tMark.Xtest = @test) and tMark.xbook in( select * from SplitNumber(@xbook))

if (@mKolli=1)
  insert into #tmpMark1  SELECT tMarkDoreh.xStudent,N'معدل ', ROUND(tMarkDoreh.MarkDoreh, 2) AS mark,null,null, tMarkDoreh.typ,1000 FROM tMarkDoreh INNER JOIN tstudent 
                on tMarkDoreh.xstudent=tstudent.id
   WHERE  tstudent.xClass in( select * from SplitNumber(@xClass)) and    tMarkDoreh.Xtest = @test and tMarkDoreh.typ=5
if (@gkolliClass=1)
  insert into #tmpMark1  SELECT tMarkDoreh.xStudent,N'رتبه در کلاس ', tMarkDoreh.gClass AS mark,null,null, tMarkDoreh.typ,1001 FROM tMarkDoreh INNER JOIN tstudent 
                on tMarkDoreh.xstudent=tstudent.id
   WHERE  tstudent.xClass in( select * from SplitNumber(@xClass)) and    tMarkDoreh.Xtest = @test and tMarkDoreh.typ=5
if (@gkolli=1)
  insert into #tmpMark1  SELECT tMarkDoreh.xStudent,N'رتبه در پايه ', tMarkDoreh.gPaye AS mark,null,null, tMarkDoreh.typ,1002 FROM tMarkDoreh INNER JOIN tstudent 
                on tMarkDoreh.xstudent=tstudent.id
   WHERE  tstudent.xClass in( select * from SplitNumber(@xClass)) and    tMarkDoreh.Xtest = @test and tMarkDoreh.typ=5


create table #tmpmsg(xStudent bigint,msg nvarchar(4000) COLLATE Arabic_CI_AS NULL)

declare @xTestStd bigint
declare @Tmp_xTestStd bigint
declare @mark float
declare @gkoll int
declare @gClass int
declare @book nvarchar(1000)
declare @book2 nvarchar(4000)

 if (@heder1<>'')
    set @heder1=@heder1+' '

    set @heder2=@heder2+CHAR(13)+CHAR(10)+N'ـــــــــــــــــــــــــــــــــــــــ'+CHAR(13)+CHAR(10)

 if (@foter<>'')
    set @foter=CHAR(13)+CHAR(10)+@foter

set @Tmp_xTestStd=-1

declare Book cursor for
 select xStudent,Name,mark,gkoll,gClass from #tmpMark1 order by xStudent ,sort


  open Book
    fetch next from Book into 
     @xTestStd,@book,@mark,@gkoll,@gClass

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
        begin
          set @book2=@book2+CHAR(13)+CHAR(10) 
        end
          set @book2=@book2+N'🔹'+@book+' '+cast(@mark as varchar)
   
	 if(@gBookClass=1 and @gClass is not null)
         begin
           set @book2=@book2+CHAR(13)+CHAR(10) +N'رتبه در کلاس '+cast(@gClass as varchar)
	   if (@gBook=0)
           set @book2=@book2+CHAR(13)+CHAR(10)+N'ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ'
         end
         if(@gBook=1 and @gkoll is not null)
         begin
          set @book2=@book2+CHAR(13)+CHAR(10)+N'رتبه در پايه '+cast(@gkoll as varchar)
 	  set @book2=@book2+CHAR(13)+CHAR(10)+N'ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ'
         end
      

       set @Tmp_xTestStd=@xTestStd

      fetch next from Book into 
      @xTestStd,@book,@mark,@gkoll,@gClass
   end
  close Book
 deallocate Book

   if(@Tmp_xTestStd>-1)
             begin
            
                insert into #tmpmsg(xStudent,msg) values(@Tmp_xTestStd,@book2)         
             end


declare @massege nvarchar (4000)
set @massege=''''+@heder1+''''
if(@NameStd=1)
  set @massege=@massege+' '+'+tstudent.fname+'' ''+tstudent.lname+'' '''
set @massege=@massege+CHAR(13)+CHAR(10) +'+'''+@heder2+'''+#tmpmsg.msg+CHAR(13)+CHAR(10)+'
set @massege=@massege+CHAR(13)+CHAR(10)+N'''ـــــــــــــــــــــــــــــــــــــــ''+'+CHAR(13)+CHAR(10)
set @massege=@massege+CHAR(13)+CHAR(10)+'+'''+@foter+CHAR(13)+CHAR(10)+'''+'+N'''ـــــــــــــــــــــــــــــــــــــــ'''
--print @massege
declare @sql nvarchar(4000)


create table #tmpmsgMain (id int,sentTo	int,msg nvarchar(4000) COLLATE Arabic_CI_AS NULL)
if(@sendTo=1)
set @sql='insert into	#tmpmsgMain select tstudent.id,1 as sentTo,'+@massege+' as Message from #tmpmsg
   inner join tstudent on #tmpmsg.xstudent=tstudent.id'

else if(@sendTo=2)
set @sql='insert into	#tmpmsgMain select  tstudent.id,2	as sentTo,'+@massege+' as Message from #tmpmsg
   inner join tstudent on #tmpmsg.xstudent=tstudent.id'
else if(@sendTo=0)
 set @sql='insert into	#tmpmsgMain select tstudent.id,1 as sentTo,'+@massege+' as Message  from #tmpmsg
   inner join tstudent on #tmpmsg.xstudent=tstudent.id 
 union
 select tstudent.id,2 as sentTo,'+@massege+' as Message from #tmpmsg
  inner join tstudent on #tmpmsg.xstudent=tstudent.id'

print (@sql)
exec (@sql)
if(@SendTest=1)
begin
	INSERT INTO tTelegramMessage
	                      (typMsg, xStudent, sentTo, dateTosend, TimeTosend, Message)
				select top 1  1 as typMsg,0,1,@date,@time,msg from #tmpmsgMain
end
else 
begin
	INSERT INTO tTelegramMessage
	                      (typMsg, xStudent, sentTo, dateTosend, TimeTosend, Message)
				select 1 as typMsg,id,sentTo,@date,@time,msg from #tmpmsgMain
end


drop table #tmpMark1
drop table #tmpmsg
drop table #tmpmsgMain

