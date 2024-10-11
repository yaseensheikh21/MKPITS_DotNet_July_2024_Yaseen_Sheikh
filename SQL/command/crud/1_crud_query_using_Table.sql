--write a query to insert new record into a table
insert into EmployeeDetail(FirstName,LastName,Contact, Salary, deptID, Address) 
values
('Raj','kumar',987564123,33000,11,'mumbai'),('Mahesh','kutarmara',95786423173,50000,12,'bhadrawati'),('suraj','singh',8483834773,30000,12,'Nagpur'),('dheeraj','raj',8482331723,40000,12,'wardha'),
('ayush','sharma',75412688423,50000,12,'Nagpur'),('kaunain','sheikh',7543831723,10000,12,'majri'),('nilesh','mishra',8274831723,10000,12,'Nagpur'),
('Suraj','take',8874561723,22000,12,'Warora');

--how do you retrieve all records from a table
Select * From EmployeeDetail;

--update the salary pf an employee with ID 8 to  $5000
update EmployeeDetail set salary=5000 where EmpId=8;

--adding new column in the existing table
Alter table EmployeeDetail ADD Age int;

--retreiving particular column from the table
Select FirstName ,LastName From EmployeeDetail;

-- updating the salary of all employee by 10%
update EmployeeDetail set Salary=Salary*1.10;

--delete a sprcific record from the table using where condition
delete  from  EmployeeDetail  where deptID=11;


