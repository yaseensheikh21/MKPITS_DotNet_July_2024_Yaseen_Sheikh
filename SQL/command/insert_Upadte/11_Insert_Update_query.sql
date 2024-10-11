Insert into Customer (FirstName,LastName,City,Country,Phone)values('Yash','Kumar','Nagpur','INDIA',8483831723);
Insert into Customer (FirstName,LastName,City)values('Neeraj','Mishra','Lahore');
Insert into Customer (FirstName,LastName,City,Country,Phone)values('Niraj','Raj','Nagr','INDIA',9874583143),('Suraj','Rajbhar','Nagpur','INDIA',8483831723),('dheraj','Rajbhar','Nagpur','INDIA',9833831723),('Neeraj','Rajbhar','kanpur','INDIA',843353431723),('Neeraj','sinhg','Nagpur','INDIA',8483831723);
Insert into Customer (City,Country)values('Nagpur','INDIA');
ALTER TABLE Customer ADD Email VARCHAR(25);
ALTER TABLE Customer DROP COLUMN Email;
UPDATE Customer SET FirstName = 'daku' WHERE Id = 1;
ALTER TABLE Customer ADD CreatedAt TIMESTAMP 
UPDATE Customer SET City = 'nagpur', Country = 'India' WHERE Id = 6;
UPDATE Customer SET Phone = '896521347' WHERE City = 'Bhadrawati';
UPDATE Customer SET FirstName = 'Ayush', LastName = 'Yadav' WHERE Id = 94;
UPDATE Customer SET City = REPLACE(City, 'Dehli', 'Warora') WHERE City LIKE 'Dehli';









