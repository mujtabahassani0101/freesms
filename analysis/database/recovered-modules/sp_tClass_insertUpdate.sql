CREATE procedure dbo.sp_tClass_insertUpdate
@id int,
@xYear int,
@xpaye int,
@name nvarchar(50),
@answerable nvarchar(50),
@fee int ,
@shift smallint,
@sortRpt smallint,
@code int output  with encryption
as
if(@id>0)
  begin 
      if exists(select id from tClass where id<>@id and xYear=@xYear and replace(name,' ','')= replace(@name,' ',''))  
	 begin  
	   set @Code=-100  
	   return  
	 end  
      if exists(select id from tClass where id<>@id and xYear=@xYear and sortRpt=@sortRpt)  
	 begin  
	   set @Code=-200  
	   return  
	 end  
	
       UPDATE    tClass
       SET              name =@name, answerable =@answerable, fee =@fee, shift =@shift, sortRpt =@sortRpt
       where id=@id
  end
else
  begin
      if exists(select id from tClass where  xYear=@xYear and replace(name,' ','')= replace(@name,' ',''))  
	 begin  
	   set @Code=-100  
	   return  
	 end  
      if exists(select id from tClass where xYear=@xYear and sortRpt=@sortRpt)  
	 begin  
	   set @Code=-200  
	   return  
	 end  
     INSERT INTO tClass
                      (xYear, xpaye, name, answerable, fee, shift, sortRpt)
     VALUES     (@xYear, @xpaye, @name, @answerable, @fee, @shift, @sortRpt)
  end