--- how to use where clause---
SElect * from Orders where CustomerId>34;    --- where clause for customerId having graeter than 34
SElect * from Orders where OrdersDate>'2014-02-27 00:00:00.000'; -- where clause for Ordersdate having graeter than 2014-02-27 00:00:00.000

--- how to use orders by clause with the help of Select query---
Select * from Orders order by OrdersDate Desc  ---- Odersdate in descinding 
Select * from Orders order by OrdersDate  Asc ---- Odersdate in ascending 
Select * from Orders order by CustomerId   ---CustomerId in ascending

--- how to use group by clause---
SElect MAX(Orders.CustomerId) as OrdersId CustomerId as CustomerId from Orders group by Orders.OrdersNumber
