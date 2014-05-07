IF OBJECT_ID ( 'SP_create_Beer', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_create_Beer;
go
create procedure SP_create_Beer
(
@beerid int output,
@name nvarchar(255)
)
as
begin

	insert into Beer(name) 
	values		(@name);

	set @beerid = @@IDENTITY;
end

declare @beerid int;
exec SP_create_Beer @beerid out,  'AmericanPaleAle';

------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
IF OBJECT_ID ( 'Brewery.SP_create_Customer', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_create_Customer;
go
create procedure SP_create_Customer
(
@CustomerId int output,
@FirstName nvarchar(255),
@SurName nvarchar(255),
@Addressline1 nvarchar(255),
@Postcode nvarchar(255),
@Town nvarchar(255),
@Telephone nvarchar(255),
@Email nvarchar(255)
)
as

begin

	insert into Customer(FirstName,SurName,Addressline1,Postcode,Town,Telephone,Email)
	values		(@FirstName,@SurName,@Addressline1,@Postcode,@Town,@Telephone,@Email);

	set @CustomerId = @@IDENTITY;

end

declare @customerId int;
exec SP_create_Customer @beerid out;

------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
IF OBJECT_ID ( 'Brewery.SP_create_DeliveryNote', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_create_DeliveryNote;
go
create procedure SP_create_DeliveryNote
(
@DeliveryNoteID int output,
@date datetime,
@CustomerID int
)
as

begin

	insert into Deliverynote([date], customerId)
	values		(@date, @customerId);
	
	set	@DeliveryNoteID = @@IDENTITY;
end

declare @DeliveryNoteID int;
exec SP_create_Customer @DeliveryNoteID out;