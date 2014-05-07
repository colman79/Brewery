create table Customer
(
customerId int identity primary key,
firstName nvarchar(255) not null,
surname nvarchar(255) not null,
addressLine1 nvarchar(255),
postcode nvarchar(255),
town nvarchar(255),
telephone nvarchar(255),
email nvarchar(266)
)

create table Beer
(
beerId int identity primary key,
name nvarchar(255) not null,
volume int,
unique(name)
)

create table DeliveryNote
(
deliveryNoteId int identity primary key,
[date] datetime not null,
customerId int foreign key references Customer(customerId)
)

create table deliveryNoteLine
(
deliveryNoteLineId int identity primary key,
deliveryNoteId int foreign key references DeliveryNote(deliveryNoteId),
beerId int foreign key references Beer(beerid),
amount int
)