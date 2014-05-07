------------------------------------------------------------------------------------------------
--creates******************************************************************
-------------------------------------------------------------------------------------------------

IF OBJECT_ID ( 'SP_create_Beer', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_create_Beer;
go
create procedure SP_create_Beer
(
@beerid int output,
@name nvarchar(255),
@volume int
)
as
begin

	insert into Beer(name,volume) 
	values		(@name, @volume);

	set @beerid = @@IDENTITY;
end

------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
IF OBJECT_ID ( 'SP_create_Customer', 'P' ) IS NOT NULL 
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

------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

IF OBJECT_ID ( 'SP_create_DeliveryNote', 'P' ) IS NOT NULL 
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
------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
IF OBJECT_ID ( 'SP_create_DeliveryNoteLine', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_create_DeliveryNoteLine;
go
create procedure SP_create_DeliveryNoteLine
(
@DeliveryNoteLineID int output,
@DeliveryNoteId int,
@BeerId int,
@Amount int
)
as
begin

	insert into DeliverynoteLine(deliveryNoteId, beerId, amount)
	values		(@DeliveryNoteId, @BeerId, @Amount);

	set	@DeliveryNoteID = @@IDENTITY;
end

------------------------------------------------------------------------------------------------
--gets******************************************************************
-------------------------------------------------------------------------------------------------
IF OBJECT_ID ( 'SP_get_customer_by_id', 'P' ) IS NOT NULL 
    DROP PROCEDURE SP_get_customer_by_id;
go
create procedure SP_get_customers
(
@customerId int
)
as
begin
	
	select	customerId,FirstName,SurName,Addressline1,Postcode,Town,Telephone,Email
	from	Customer
	where	customerId = @customerId;

end 

------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
IF OBJECT_ID ( 'SP_get_customer_by_id', 'P' ) IS NOT NULL
    DROP PROCEDURE SP_get_customer_by_id;
go
create procedure SP_get_customer_by_id
(
@customerId int
)
as
begin
	
	select	customerId,FirstName,SurName,Addressline1,Postcode,Town,Telephone,Email
	from	Customer
	where	customerId = @customerId;

end