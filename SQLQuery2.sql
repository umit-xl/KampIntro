--Select
--ANSI
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

Select * from Products where categoryId = 1 or categoryId = 3

Select * from Products where categoryId = 1 and UnitPrice >=10

Select * from Products order by UnitPrice asc --ascendig ( defualtı ascending )
Select * from Products where categoryId = 1 order by UnitPrice desc --descending ( azalan, düşen )

Select count(*) from Products where CategoryID = 2


Select categoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10 


--DTO = Data Transformation object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o
on o.OrderID = od.OrderID


Select * from Customers c left join Orders o
on c.CustomerId = o.CustomerId
where o.CustomerID is null

