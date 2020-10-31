-- UC 2
create table employee_payroll(
ID int NOT NULL identity(1, 1) PRIMARY KEY,
Name varchar(50) NOT NULL,
StartDate datetime NOT NULL,
Salary decimal (12, 2) NOT NULL
);

-- UC 3
insert into employee_payroll values('Mrunal', '2020-10-01', 20000);
insert into employee_payroll values('Abc', '2020-01-01', 30000);
insert into employee_payroll values('Sam', '2020-03-01', 15000);
insert into employee_payroll values('John', '2020-08-01', 20000);

-- UC 4
select * from employee_payroll;

-- UC 5
select Salary from employee_payroll where Name='Mrunal';

select Salary from employee_payroll where StartDate between CAST('2020-02-01' AS DATE) AND GETDATE();


-- UC 6
alter table employee_payroll  add Gender char(1);
update employee_payroll set Gender='F' where Name = 'Mrunal' or Name='Sam';
update employee_payroll set Gender='M' where Name = 'Abc' or Name='John';

-- UC 7
select SUM(Salary) from employee_payroll where Gender='F' group by Gender;
select AVG(Salary) from employee_payroll where Gender='M' group by Gender;
select COUNT(ID) from employee_payroll where Gender='F' group by Gender;

-- UC 8
alter table employee_payroll add PhoneNumber varchar(10);
alter table employee_payroll add Address varchar(30) NOT NULL default 'Mumbai';
alter table employee_payroll add Department varchar(30) NOT NULL default '';

update employee_payroll set PhoneNumber='9854785965' where Name = 'Mrunal';
update employee_payroll set PhoneNumber='7854785965' where Name = 'John';

update employee_payroll set Department='HR' where Name = 'Mrunal' or Name='John';
update employee_payroll set Department='R&D' where Name = 'Sam';
update employee_payroll set Department='Marketing' where Name = 'Abc';

--UC 9
alter table employee_payroll add BasicPay decimal(10, 2) NOT NULL default 0;
alter table employee_payroll add Deductions decimal(10, 2) NOT NULL default 0;
alter table employee_payroll add TaxablePay decimal(10, 2) NOT NULL default 0;
alter table employee_payroll add IncomeTax decimal(10, 2) NOT NULL default 0;
alter table employee_payroll add NetPay decimal(10, 2) NOT NULL default 0;


--update employee_payroll set BasicPay=20000 where Name='Mrunal' or Name='John';
--update employee_payroll set BasicPay=30000 where Name='Abc' or Name='Sam';

--update employee_payroll set Deductions=2000 where Name='Mrunal' or Name='Abc';
--update employee_payroll set Deductions=1500 where Name='John';
--update employee_payroll set Deductions=3000 where Name='Sam';

--update employee_payroll set TaxablePay=1000;

--update employee_payroll set IncomeTax=200;

--update employee_payroll set NetPay=18000 where Name='Mrunal';
--update employee_payroll set NetPay=28000 where Name='Abc';
--update employee_payroll set NetPay=27000 where Name='Sam';
--update employee_payroll set NetPay=15000 where Name='John';

-- UC 10
