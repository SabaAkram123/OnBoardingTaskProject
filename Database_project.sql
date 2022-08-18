 Create DATABASE ONBORADING_TASK_Demo
 USE  ONBORADING_TASK_Demo
CREATE TABLE Customer_Table(
Id INT PRIMARY KEY,
Name Varchar(100) unique,
Address varchar (100)

)
CREATE TABLE Product_Table(
Id INT PRIMARY KEY,
Name Varchar(100) unique,
Price int

)
CREATE TABLE Store_Table(
Id INT PRIMARY KEY,
Name Varchar(100) unique,
Address varchar (100)

)
CREATE TABLE Sales_Table(
Id int primary key,
CustomerId int foreign key references Customer_Table(ID),
ProductId int foreign key references Product_Table(ID),
StoreId int foreign key references Store_Table(ID),
DateSold date

)
select * from Customer_Table
select * from Product_Table
select * from Store_Table
select * from Sales_Table

insert into Customer_Table values(1,'Adrew','auburn')
insert into Customer_Table values(2,'Jone','CBD')
insert into Customer_Table values(3,'saba','Bankstown')
insert into Customer_Table values(4,'Yasin','Lidcome')
insert into Customer_Table values(5,'Afreen','Marryland')

insert into Product_Table values(1, 'Apple', 10)
insert into Product_Table values(2, 'Orange', 12)
insert into Product_Table values(3, 'Banna', 14)
insert into Product_Table values(4, 'Kiwi', 10)
insert into Product_Table values(5, 'Mango', 10)

insert into Store_Table values(1, 'store1', 'address1')
insert into Store_Table values(2, 'store2', 'address2')
insert into Store_Table values(3, 'store3', 'address3')
insert into Store_Table values(4, 'store4', 'address4')
insert into Store_Table values(5, 'store5', 'address5')


insert into Sales_Table values(1, 1, 2,3,'10-01-2012')
insert into Sales_Table values(2, 1, 1,2,'11-01-2012')
insert into Sales_Table values(3, 1, 3,2,'12-01-2012')
insert into Sales_Table values(4, 1, 1,2,'11-01-2012')

Drop table Customer_Table
Drop table Sales_Table

Drop table Product_Table
Drop table Store_Table