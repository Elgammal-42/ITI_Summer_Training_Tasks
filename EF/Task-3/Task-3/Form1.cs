using static Azure.Core.HttpHeader;
using Task_3.Entities;
using Task_3.Data;
using Microsoft.EntityFrameworkCore;

namespace Task_3
{
    public partial class Form1 : Form
    {
        private Employee GetEmp()
        {
            var emp = new Employee();
            //int Id = int.Parse(EmpIdTB.Text);
            int Salary = int.Parse(EmpSalaryTB.Text);
            string Name = EmpNameTB.Text;
            int DepNo = int.Parse(EmpDepNoTB.Text);
            //emp.Id = Id;
            emp.Salary = Salary;
            emp.Name = Name;
            emp.DepartmentId = DepNo;
            return emp;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayButton_Click(sender, e);
        }

        private void EmpInsertButton_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var emps = context.Employees;
            var emp = GetEmp();
            if (emp.Name == null)
                MessageBox.Show("Enter your name");
            emps.Add(emp);
            context.SaveChanges();
            DisplayButton_Click(sender, e);
        }

        private void EmpUpdateButton_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var emps = context.Employees;
            var id = int.Parse(EmpIdTB.Text);
            var emp = emps.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                emp.Salary = GetEmp().Salary;
                emp.Name = GetEmp().Name;
                emps.Update(emp);
            }
            else
                MessageBox.Show("Id not found");
            context.SaveChanges();
            DisplayButton_Click(sender, e);
        }

        private void EmpDeleteButton_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var emps = context.Employees;
            var id = int.Parse(EmpIdTB.Text);
            var emp = emps.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {

                emps.Remove(emp);
            }
            else
                MessageBox.Show("Id not found");
            context.SaveChanges();
            DisplayButton_Click(sender, e);
        }





        private void DepInsertButton_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var deps = context.Departments;
            var dep = new Department { Name = DepNameTB.Text };
            if (dep.Name == null)
                MessageBox.Show("Enter your name");
            deps.Add(dep);
            context.SaveChanges();
            DisplayButton_Click(sender, e);
        }

        private void DepUpdateButton_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var deps = context.Departments;
            var id = int.Parse(DepIdTB.Text);
            var dep = deps.FirstOrDefault(x => x.Id == id);
            if (dep != null)
            {
                dep.Name = DepNameTB.Text;
                deps.Update(dep);
            }
            else
                MessageBox.Show("Id not found");
            context.SaveChanges();
            DisplayButton_Click(sender, e);
        }

        private void DepDeleteButton_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var deps = context.Departments;
            var id = int.Parse(DepIdTB.Text);
            var dep = deps.FirstOrDefault(x => x.Id == id);
            if (dep != null)
            {
                deps.Remove(dep);
            }
            else
                MessageBox.Show("Id not found");
            context.SaveChanges();
            DisplayButton_Click(sender, e);
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();

            var emps = context.Employees.Select(x => new
            {
                x.Id,
                x.Name,
                x.Salary,
                x.DepartmentId,
            }).ToList();
            dataGridView1.DataSource = emps;

            var Deps = context.Departments.ToList();
            dataGridView2.DataSource = Deps;
        }
    }
}
