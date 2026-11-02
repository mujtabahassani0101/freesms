create procedure dbo.sp_tStudent_insert_FromXls  
@xYear int,    
@xPaye int ,    
@xClass int ,    
@Code bigint ,    
@FName nvarchar(100),    
@LName nvarchar(100),    
@PName nvarchar(100),    
@MobileFather nvarchar(11),    
@MobileMother nvarchar(11),    
@Jens smallint,     
@NumberAsas int ,
@Sort int ,    
    
@RegDate nvarchar(10),    


  
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
@CodeOut int outPut    with encryption
as    
declare @id int 

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
    BEGIN TRANSACTION --beginning a transaction.

       INSERT INTO tStudent    
                      (Code, FName, LName, PName, MobileFather, MobileMother,Jens, Mazhab, NumberAsas, RegDate)    
       VALUES     (@Code, @FName,@LName,@PName,@MobileFather,@MobileMother,@Jens,-1,@NumberAsas,@RegDate)  
       set @id=@@identity  
      IF @@ERROR != 0 --check @@ERROR variable after each DML statements..
      BEGIN
	        ROLLBACK TRANSACTION --RollBack Transaction if Error..
	        set @CodeOut=-1000
	        RETURN
      END  
      ELSE
        BEGIN
	      
	       INSERT INTO tYear_Student    
	
	                      (xYear, xStudent, xPaye, xClass,Sort,Status, shaghe, hazer, mali, dakhle, uniform,    
	                       komakdarsi, ketab, transport, robotic, maghnae,  
	                       Fee1,Fee2,Fee3,Fee4, Fee5,Fee6,Fee7,Fee8,Fee9, SumFee ,xTakhfif,xDriver)    
	       VALUES      (@xYear, @id, @xPaye, @xClass,@Sort,1, 1, 1, 1, 0, 0,
	                       0, 0, 0, 0, 0,  
	                      @Fee1,@Fee2,@Fee3,@Fee4, @Fee5,@Fee6,@Fee7,@Fee8,@Fee9,@SumFee, @xTakhfif,0)        
              IF @@ERROR != 0 --check @@ERROR variable after each DML statements..
              BEGIN
                ROLLBACK TRANSACTION --RollBack Transaction if Error..
                set @code=-1000
                RETURN
              END 
	    COMMIT TRANSACTION --finally, Commit the transaction if Success..
            set @CodeOut=@id
            RETURN 
        END