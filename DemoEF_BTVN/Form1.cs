using DemoEF_BTVN.Models;
using DemoEF_BTVN.Service;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoEF_BTVN
{
    public partial class Form1 : Form
    {
        private EmployeeService employeeService = new EmployeeService();
        private CustomerService customerService = new CustomerService();
        private OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCustomers.DisplayMember = "CustomerName";
            cbCustomers.ValueMember = "CustomerId";
            List<Customer> customers = customerService.GetAllCustomers();
            customers.Insert(0, new Customer
            {
                CustomerId = String.Empty,
                CompanyName = "All customers"
            });
            cbCustomers.DataSource = customers;

            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "Employee";
            List<Employee> employees = employeeService.GetAllEmployees();
            employees.Insert(0, new Employee
            {
                EmployeeId = 0,
                FirstName = "All employees"
            });
            cbEmployees.DataSource = employees;
            From.Value = new DateTime(1990, 1, 1);
            To.Value = DateTime.Now;
            LoadData();
        }

        private void LoadData()
        {
            string CustomerId = cbCustomers.SelectedValue.ToString();
            int EmployeeId = Convert.ToInt32(cbEmployees.SelectedValue);
            DateTime FromDate = From.Value;
            DateTime ToDate = To.Value;
            var orders = orderService
                .GetOrders(EmployeeId, CustomerId, FromDate, ToDate, "OrderId")
                .Select(x => new
                {
                    OrderId = x.OrderId,
                    Employee = (x.Employee is null) ? String.Empty : x.Employee.FirstName,
                    Customer = (x.Customer is null) ? String.Empty : x.Customer.CompanyName,
                    OrderDate = x.OrderDate,
                    Freight = x.Freight
                })
                .ToList();
            dataGridView1.DataSource = orders;
        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void From_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void To_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            //    Form2 form2 = new Form2();
            //    form2.Show();
        }
    }
}