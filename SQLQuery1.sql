use northwind
select employeeid, lastname, firstname, title
from employees
where employeeid =5
go

use northwind
select lastname, city
from employees
where country = 'USA'
go

use northwind
select companyname
from customers
where companyname like '%Restaurant%'
go

use northwind
select productid, productname, supplierid, unitprice
from Products 
where (productname like 'T%' or productid = 46)
and (unitprice > 16.00)
go

use northwind 

select productname, unitprice
from products
where unitprice between 10 and 20 
go 

use northwind 
select companyname, country
from suppliers
where country in ('japan'), 'italy'