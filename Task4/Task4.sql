--1
select count(e.SSN)
from Employee e
group by e.Dno

--2/3
select min(salary), avg (salary)
from Employee e
group by e.Dno

--4
select e.Dno
from Employee e
group by e.Dno
having count(e.SSN)>1

--5
select p.Pname
from Employee e
inner join Works_for w on e.SSN = w.ESSn
inner join Project p on w.Pno = p.Pnumber
group by p.Pname
having count(w.ESSn)>2

--6
select e.Dno,max(e.Salary)
from Employee e
group by e.dno

--7
select *
from Employee e
where e.Salary >(select AVG(Salary)from Employee)

--8
select e.*
from Employee e
inner join Works_for w on e.SSN = w.ESSn
where w.Pno =
(
select w.Pno
from Employee e
inner join Works_for w on e.SSN = w.ESSn
where e.Fname+ ' ' + e.Lname = 'Ahmed Ali'
)

--9
select distinct d.Dname, d.Dnum
from Employee e
join Works_for w on e.SSN = w.ESSn
join Project p on p.Pnumber = w.Pno
join Departments d on p.Dnum = d.Dnum
where e.Fname = 'Kamel'




--10 
create view EmployeesDept as 
select e.Fname,e.Lname,e.Salary, d.Dname
from Employee e 
inner join Departments d on e.Dno = d.Dnum

--11
select * from EmployeesDept

--12
create view DeptProjects as 
select d.Dname,d.Dnum,p.Pnumber,p.Pname
from Project p 
inner join Departments d on p.Dnum = d.Dnum

--13
select *
from Employee
order by Salary desc

--14
select *
from Project
order by Project.Pname

--15
select top(3) e.*
from Employee e
order by e.Salary desc

--16
select top(2) d.Dname, count(e.SSN)
from Departments d
inner join Employee e on d.Dnum = e.Dno
group by d.Dname
order by count(e.SSN) desc

--17
select p.Pname, count(p.pname)
from Employee e 
inner join Works_for w on w.ESSn = e.SSN
inner join Project p on w.Pno = p.Pnumber
group by p.Pname

--18 
create view projectView as
select Pnumber
from Project

delete projectView
where Pnumber = 100

--19
create view empSalay as 
select Fname, Salary
from Employee

update empSalay
set Salary = salary + (select Salary from Employee where Fname = 'Kamel')/10
where Fname = 'Kamel'

select * from empSalay

--20
select * from Employee e1
where e1.Salary > (select AVG(e2.salary) from Employee e2 where e1.Dno = e2.Dno)


