--13980701
UPDATE    tVer
SET              ver = N'VkFCV0FGSUFUZ0JPQUZVQU9RQkVBRThBU0FCa0FFOEFaUUJVQUdnQU13QlVBRllBUlFCeUFGRUFWUUJSQUhjQVVRQldBRUlBVWdCTUFGRUFQUUE5QUE9PQ=='
GO 
UPDATE    tItemSabtenamEnable
SET              name = N'txtEn_Fname'
WHERE     (name = N'En_Fname')
GO
UPDATE    tItemSabtenamEnable
SET              name = N'txtEn_Lname'
WHERE     (name = N'En_Lname')
GO
INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (30, N'txtLastName', N'تخلص', 1)
GO
INSERT INTO tItemSabtenamEnable
                      (id, name, lable, Enable)
VALUES     (31, N'txtEn_LastName', N'تخلص انگليسي', 1)
GO
alter table tStudent add LastName nvarchar(100),En_LastName nvarchar(100)
GO
alter procedure dbo.sp_tStudent_insertUpdate      
@id int,      
@xYear int,      
@xPaye int ,      
@xClass int ,      
@Code bigint ,      
@FName nvarchar(100),      
@LName nvarchar(100),      
@PName nvarchar(100),      
@Sh_Sh nvarchar(200),      
@bDate nvarchar(10),      
@MobileFather nvarchar(11),      
@MobileMother nvarchar(11),      
@NumberTelegram nvarchar(11),      
@NumberTelegram2 nvarchar(11),      
@Jens smallint,      
@Mazhab smallint,      
@NumberAsas int ,      
@RegDate nvarchar(10),      
@Adress nvarchar (200),      
@ExitDate nvarchar(10),      
@Status smallint,      
      
@shaghe bit,      
@hazer bit,      
@mali bit,      
@dakhle bit,      
@uniform bit,      
@komakdarsi bit,      
@ketab bit,      
@transport bit,      
@robotic bit,      
@maghnae bit,      
    
@Fee1 int,      
@Fee2 int,      
@Fee3 int,      
@Fee4 int,      
@Fee5 int,      
@Fee6 int,      
@Fee7 int,      
@Fee8 int,      
@Fee9 int,      
@SumFee int ,  
@xTakhfif smallint,  
@transport1 int,      
@transport2 int,      
@transport3 int,      
@transport4 int,      
@transport5 int,      
@transport6 int,      
@transport7 int,      
@transport8 int,      
@transport9 int,      
@Sumtransport int,      
@xDriver int,      
  
@xcity int,     
@En_Fname nvarchar (100), 
@En_Lname nvarchar (100),  
@LastName nvarchar(100),
@En_LastName nvarchar(100) ,      
@CodeOut int outPut      with encryption
as      
if(@id>0)      
  begin  
        if(@Code is not null)  
          begin     
           if exists(select id from tStudent where id<>@id and Code=@Code)        
    begin        
      set @CodeOut=-100        
      return        
    end   
          end   
       if(@NumberAsas is not null)  
          begin      
       if exists(select id from tStudent where id<>@id and NumberAsas=@NumberAsas )        
    begin        
      set @CodeOut=-200        
      return        
    end        
          end  
       UPDATE    tStudent      
       SET   Code =@Code, FName =@FName, LName =@LName, PName =@PName, Sh_Sh =@Sh_Sh, bDate=@bDate      
       , MobileFather =@MobileFather, MobileMother =@MobileMother, Jens =@Jens, Mazhab =@Mazhab,      
        NumberAsas =@NumberAsas, RegDate =@RegDate, Adress =@Adress, ExitDate =@ExitDate,       
       NumberTelegram=@NumberTelegram,NumberTelegram2=@NumberTelegram2 ,
       xcity=@xcity ,  En_Fname=@En_Fname, En_Lname=@En_Lname ,En_LastName=@En_LastName ,LastName=@LastName where id=@id      
            
      UPDATE    tYear_Student      
 SET              xPaye =@xPaye, xClass =@xClass,  Status =@Status, shaghe =@shaghe, hazer =@hazer, mali =@mali,       
                        dakhle =@dakhle, uniform =@uniform, komakdarsi =@komakdarsi, ketab =@ketab,      
                        transport =@transport, robotic =@robotic, maghnae =@maghnae,    
                        Fee1=@Fee1, Fee2=@Fee2, Fee3=@Fee3, Fee4=@Fee4, Fee5=@Fee5,    
    Fee6=@Fee6, Fee7=@Fee7, Fee8=@Fee8, Fee9=@Fee9,SumFee=@SumFee ,xTakhfif=@xTakhfif,    
   transport1=@transport1, transport2=@transport2, transport3=@transport3, transport4=@transport4, transport5=@transport5,    
    transport6=@transport6, transport7=@transport7,transport8=@transport8, transport9=@transport9, Sumtransport=@Sumtransport ,  
   xDriver =@xDriver  
 WHERE     (xYear = @xYear) AND (xStudent = @id)      
      
  end      
else      
  begin      
    if(@Code is not null)  
       begin     
         if exists(select id from tStudent where Code=@Code)        
    begin        
      set @CodeOut=-100        
      return        
    end   
       end   
    if(@NumberAsas is not null)  
      begin       
        if exists(select id from tStudent where  NumberAsas=@NumberAsas )        
   begin        
     set @CodeOut=-200        
     return        
   end    
      end     
 INSERT INTO tStudent      
                      (Code, FName, LName, PName, Sh_Sh,bDate, MobileFather, MobileMother, NumberTelegram, NumberTelegram2,      
                      Jens, Mazhab, NumberAsas, RegDate, Adress, xcity,  En_Fname, En_Lname,En_LastName,LastName)      
 VALUES     (@Code, @FName,@LName,@PName,@Sh_Sh,@bDate,@MobileFather,@MobileMother,@NumberTelegram,@NumberTelegram2,      
                     @Jens,@Mazhab,@NumberAsas,@RegDate,@Adress,@xcity,@En_Fname,@En_Lname,@En_LastName,@LastName)      
       set @id=@@identity      
       set @CodeOut=@id    
       INSERT INTO tYear_Student (xYear, xStudent, xPaye, xClass,Status, shaghe, hazer, mali, dakhle, uniform,      
                       komakdarsi, ketab, transport, robotic, maghnae,    
                       Fee1,Fee2,Fee3,Fee4, Fee5,Fee6,Fee7,Fee8,Fee9, SumFee ,xTakhfif,  
                      transport1,transport2,transport3,transport4, transport5,    
                      transport6,transport7,transport8,transport9,Sumtransport,xDriver)      
       VALUES      (@xYear, @id, @xPaye, @xClass,@Status, @shaghe, @hazer, @mali, @dakhle, @uniform,      
                       @komakdarsi, @ketab, @transport, @robotic, @maghnae,    
                      @Fee1,@Fee2,@Fee3,@Fee4, @Fee5,@Fee6,@Fee7,@Fee8,@Fee9,@SumFee, @xTakhfif,   
      @transport1,@transport2,@transport3,@transport4, @transport5,    
                    @transport6,@transport7,@transport8,@transport9,@Sumtransport,@xDriver)      
  end      
      

GO