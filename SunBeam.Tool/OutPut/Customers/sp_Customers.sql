SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  proc [dbo].[sp_Customers]
(
@Id		int = null,
@Code		nvarchar(20) = null,
@Name		nvarchar(200) = null,
@CountryId		int = null,
@DivisionId		int = null,
@DistrictId		int = null,
@Mobile		nvarchar(20) = null,
@PermanentAddress		nvarchar(500) = null,
@PresentAddress		nvarchar(500) = null,
@PABX		nvarchar(100) = null,
@Email		nvarchar(100) = null,
@FAX		nvarchar(100) = null,
@Remarks		nvarchar(500) = null,
@IsActive		bit = null,
@IsArchive		bit = null,
@CreatedBy		nvarchar(50) = null,
@CreatedAt		nvarchar(50) = null,
@CreatedFrom		nvarchar(50) = null,
@LastUpdateBy		nvarchar(50) = null,
@LastUpdateAt		nvarchar(50) = null,
@LastUpdateFrom		nvarchar(50) = null,

@Msg				nvarchar(MAX)=null OUT ,
@pOptions			int 
)
AS
--Save Customers
if(@pOptions=1)
begin
INSERT INTO Customers
(
Id,
Code,
Name,
CountryId,
DivisionId,
DistrictId,
Mobile,
PermanentAddress,
PresentAddress,
PABX,
Email,
FAX,
Remarks,
IsActive,
IsArchive,
CreatedBy,
CreatedAt,
CreatedFrom,
LastUpdateBy,
LastUpdateAt,
LastUpdateFrom

)
VALUES
(	
@Id,
@Code,
@Name,
@CountryId,
@DivisionId,
@DistrictId,
@Mobile,
@PermanentAddress,
@PresentAddress,
@PABX,
@Email,
@FAX,
@Remarks,
@IsActive,
@IsArchive,
@CreatedBy,
@CreatedAt,
@CreatedFrom,
@LastUpdateBy,
@LastUpdateAt,
@LastUpdateFrom

)
IF @@ROWCOUNT = 0
Begin
SET @Msg='Warning: No rows were Inserted';	
End
Else
Begin
SET @Msg='Data Saved Successfully';	
End					
end
--End of Save Customers



--Update Customers 
if(@pOptions=2)
begin
UPDATE	Customers 
SET
Code	=	@Code ,
Name	=	@Name ,
CountryId	=	@CountryId ,
DivisionId	=	@DivisionId ,
DistrictId	=	@DistrictId ,
Mobile	=	@Mobile ,
PermanentAddress	=	@PermanentAddress ,
PresentAddress	=	@PresentAddress ,
PABX	=	@PABX ,
Email	=	@Email ,
FAX	=	@FAX ,
Remarks	=	@Remarks ,
IsActive	=	@IsActive ,
IsArchive	=	@IsArchive ,
CreatedBy	=	@CreatedBy ,
CreatedAt	=	@CreatedAt ,
CreatedFrom	=	@CreatedFrom ,
LastUpdateBy	=	@LastUpdateBy ,
LastUpdateAt	=	@LastUpdateAt ,
LastUpdateFrom	=	@LastUpdateFrom 




WHERE	Id	=	@Id;



IF @@ROWCOUNT = 0
Begin
SET @Msg='Warning: No rows were Updated';	
End
Else
Begin
SET @Msg='Data Updated Successfully';
End
End
--End of Update Customers 



--Delete Customers



if(@pOptions=3)
begin
Delete from Customers Where Id=@Id;
SET @Msg='Data Deleted Successfully';
end



--End of Delete Customers 



--Select All Customers 



if(@pOptions=4)
begin	        
select * from Customers;
if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end



--End of Select All Customers 



--Select Customers By Id 
if(@pOptions=5)
begin
select * from Customers Where Id=@Id;



if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end
--End of Select Customers By Id 
