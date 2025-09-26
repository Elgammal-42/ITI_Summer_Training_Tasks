using System.ComponentModel;
using Task_2.Models;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Employee GetEmp()
        {
            var emp = new Employee();
            int Id = int.Parse(IdTB.Text);
            int Salary = int.Parse(SalaryTB.Text);
            string Name = NameTB.Text;
            emp.Id = Id;
            emp.Salary = Salary;
            emp.Name = Name;
            return emp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var context = new EfDay2Context();
            var emps = context.Employees;
            var emp = GetEmp();
            if (emp.Name == null)
                MessageBox.Show("Enter your name");
            emps.Add(emp);
            context.SaveChanges();
            UpdateGrid();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var context = new EfDay2Context();
            var emps = context.Employees;
            var id = GetEmp().Id;
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
            UpdateGrid();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var context = new EfDay2Context();
            var emps = context.Employees;
            var id = GetEmp().Id;
            var emp = emps.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                emps.Remove(emp);
            }
            else
                MessageBox.Show("Id not found");
            context.SaveChanges();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            var context = new EfDay2Context();

            var emps = context.Employees.ToList();
            dataGridView1.DataSource = emps;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
