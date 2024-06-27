use CollabApiDb;
go
delete from OrderLine;
delete from Items;
delete from Orders;
delete from Customers;
delete from Employees;
go

insert Employees (Email, Password) Values 
		('WholeFoods@apidb.com', '123abc'),
		('Walmart@apidb.com', 'wallyworld');
go

insert Customers (Name, City, State, Sales, Active) VALUES
					('Walmart', 'Cincinatti', 'OH', 2000000, 1),
					('WholeFoods', 'Columbus', 'OH', 156777, 1);
go


insert Items (Description, Price) VALUES
				('Electrolyte', 299),
				('Sushi', 500);
go

insert Orders(Date, Description, Status, Total, CustomerId ) VALUES
					('2024-12-05', 'New Order', 'NEW', 0, 13),
					('2024-11-22', 'New Order', 'NEW', 0, 14);

go

insert OrderLine (Quantity, ItemId, OrderId) Values
					(24, 15, 10),
					(10, 16, 11);



