
--3
SELECT d.Dname,
       MAX(e.Salary),
       MIN(e.Salary),
       AVG(e.Salary)
FROM Departments d inner join Employee e 
on d.Dnum = e.Dno
group by d.Dname

--4
select 'full name' = e.Fname + ' ' + e.Lname , d.Dependent_name
from Employee e left outer join Dependent d 
on e.Superssn = d.ESSN
where d.Dependent_name is null

--5
select d.Dnum, d.Dname, count(e.SSN)
from Departments d inner join Employee e 
on d.Dnum = e.Dno
group by d.Dnum, d.Dname
having avg(e.Salary) < (select avg(Salary) from Employee)

--6
select 'full name' = e.Fname+ ' ' + e.Lname, p.Pname, d.Dnum
from Employee e
inner join Works_for w on e.SSN = w.ESSn
inner join Project p on w.Pno = p.Pnumber
inner join Departments d on e.Dno = d.Dnum
order by d.Dnum , e.Fname, e.Lname

--7
INSERT INTO Departments (Dnum, Dname, MGRSSN, [MGRStart Date])
VALUES (100, 'DEPT IT', 112233, '2006-11-01');


--8 
insert into Employee(SSN, Dno)
values (102672 , 20);

update Departments
set MGRSSN = 968574
where Dnum  = 100;

update Departments
set MGRSSN = 102672
where Dnum = 20;

update Employee
set Dno =100
where SSN = 968574


--9
select d.Dnum , d.Dname, d.MGRSSN ,'full name' = e.Fname+ ' ' + e.Lname 
from Departments d
inner join Employee e on d.Dnum = e.Dno
where d.MGRSSN = e.SSN

--10
select Dname, p.Pname
from Departments d
inner join Project p on d.Dnum = p.Dnum

--11
select 'full name' = e.Fname+ ' ' + e.Lname , d.*
from Employee e
inner join Dependent d on e.SSN = d.ESSN

--12 
select p.Pnumber, p.Pname, p.Plocation
from Project p
where p.City in ('Cairo','Alex')

--13
select *
from Project p
where p.Pname like 'a%'

--14
select *
from Employee e
where e.Dno = 30 and Salary between 1000 and 2000

--15
select e.Fname
from Departments d
inner join Employee e on e.Dno = d.Dnum
join Works_for w on w.ESSn = e.SSN
join Project p on p.Pnumber = w.Pno
where d.Dnum =10 and w.Hours >= 10 and p.Pname = 'Al Rabwah'

--16 
select e.Fname
from Employee e , Employee s
where e.Superssn = s.SSN and s.Fname = 'Kamel'

--17
select e.Fname, p.Pname
from Employee e
inner join Works_for w on e.SSN = w.ESSn
inner join Project p on w.Pno = p.Pnumber
order by p.Pname

--18
select p.Pnumber, p.Pname, d.Dname,e.Fname, e.Address
from Employee e
inner join Departments d on e.Dno = d.Dnum
inner join Works_for w on w.ESSn = e.SSN
inner join Project p on p.Pnumber = w.Pno
where d.MGRSSN = e.SSN