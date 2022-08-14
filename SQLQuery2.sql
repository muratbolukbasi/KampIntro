--SELECT
--ANSIN
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--Case intensitive büyük harf kücük harf farketmez
select * from Products where CategoryID =1 or CategoryID=3

select * from Products where CategoryID =1 and UnitPrice>10

select * from Products order by UnitPrice asc    --ascending artan demek
select * from Products order by UnitPrice desc    --descending azalan demek

select count(*) from Products where CategoryID = 2 --product tablosunda kaç ürün olduğunu gösterir

select CategoryID,count(*) from products where UnitPrice>20 
group by CategoryID having count(*)<10

