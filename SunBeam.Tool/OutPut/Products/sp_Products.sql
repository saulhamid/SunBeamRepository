SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  proc [dbo].[sp_Products]
(
@Id		int = null,
@Name		nvarchar(200) = null,
@Code		nvarchar(20) = null,
@UOMId		int = null,
@ProductBrandId		int = null,
@ProductCatagoriesId		int = null,
@ProductColorId		int = null,
@ProductSizeId		int = null,
@ProductTypeId		int = null,
@SupplierId		int = null,
@MinimumStock		int = null,
@OtherCost		decimal = null,
@Discount		decimal = null,
@UnitePrice		decimal = null,
@Quantity		decimal = null,
@OpeningQuantity		decimal = null,
@Remarks		nvarchar(500) = null,
@IsActive		bit = null,
@IsArchive		bit = null,
@CreatedBy		nvarchar(20) = null,
@CreatedAt		nvarchar(14) = null,
@CreatedFrom		nvarchar(50) = null,
@LastUpdateBy		nvarchar(20) = null,
@LastUpdateAt		nvarchar(14) = null,
@LastUpdateFrom		nvarchar(50) = null,

@Msg				nvarchar(MAX)=null OUT ,
@pOptions			int 
)
AS
--Save Products
if(@pOptions=1)
begin
INSERT INTO Products
(
Id,
Name,
Code,
UOMId,
ProductBrandId,
ProductCatagoriesId,
ProductColorId,
ProductSizeId,
ProductTypeId,
SupplierId,
MinimumStock,
OtherCost,
Discount,
UnitePrice,
Quantity,
OpeningQuantity,
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
@Name,
@Code,
@UOMId,
@ProductBrandId,
@ProductCatagoriesId,
@ProductColorId,
@ProductSizeId,
@ProductTypeId,
@SupplierId,
@MinimumStock,
@OtherCost,
@Discount,
@UnitePrice,
@Quantity,
@OpeningQuantity,
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
--End of Save Products



--Update Products 
if(@pOptions=2)
begin
UPDATE	Products 
SET
Name	=	@Name ,
Code	=	@Code ,
UOMId	=	@UOMId ,
ProductBrandId	=	@ProductBrandId ,
ProductCatagoriesId	=	@ProductCatagoriesId ,
ProductColorId	=	@ProductColorId ,
ProductSizeId	=	@ProductSizeId ,
ProductTypeId	=	@ProductTypeId ,
SupplierId	=	@SupplierId ,
MinimumStock	=	@MinimumStock ,
OtherCost	=	@OtherCost ,
Discount	=	@Discount ,
UnitePrice	=	@UnitePrice ,
Quantity	=	@Quantity ,
OpeningQuantity	=	@OpeningQuantity ,
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
--End of Update Products 



--Delete Products



if(@pOptions=3)
begin
Delete from Products Where Id=@Id;
SET @Msg='Data Deleted Successfully';
end



--End of Delete Products 



--Select All Products 



if(@pOptions=4)
begin	        
select * from Products;
if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end



--End of Select All Products 



--Select Products By Id 
if(@pOptions=5)
begin
select * from Products Where Id=@Id;



if(@@ROWCOUNT=0)
SET @Msg='Data Not Found';
end
--End of Select Products By Id 
