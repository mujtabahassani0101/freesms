CREATE procedure [dbo].[sp_tHozeh_InsertUpdate]   
@Code int output,  
@id bigint,  
@name nvarchar(100),  
@Capacity int,  
@commandType varchar(10)  with encryption
as  
  
if(@commandType='insert')  
  begin  
     
   if exists(select id from tHozeh where replace(name,' ','')= replace(@name,' ',''))  
    begin  
      set @Code='0'  
     return  
    end  
    select @id=isnull(max(id),0)+1 from tHozeh
    INSERT INTO tHozeh  
                       (ID, name, Capacity)  
    VALUES     (@id, @name, @Capacity)  
  end  
  
else if(@commandType='update')  
 begin  
     
   if exists(select id from tHozeh where id<>@id and replace(name,' ','')= replace(@name,' ',''))  
    begin  
      set @Code='0'  
     return  
    end  
      
   update tHozeh set name=@name,Capacity=@Capacity where id=@id  
     
 end