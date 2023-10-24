using Lab2.Logics.IServices;
using Lab2.Models;
using System.Data;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        IOrderService orderService;
        IEmployeeService employeeService;
        ICustomerService customerService;
        IProductService productService;
        public Form2(IOrderService _orderService, IEmployeeService _empService,
            ICustomerService _cusService, IProductService _productService)
        {
            orderService = _orderService;
            employeeService = _empService;
            customerService = _cusService;
            productService = _productService;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbCustomers.DisplayMember = "CompanyName";
            cbCustomers.ValueMember = "CustomerId";
            List<Customer> customers = customerService.GetCustomers();
            customers.Insert(0, new Customer
            {
                CustomerId = String.Empty,
                CompanyName = "All customers"
            });
            cbCustomers.DataSource = customers;

            cbEmployees.DisplayMember = "FirstName";
            cbEmployees.ValueMember = "EmployeeId";
            List<Employee> employees = employeeService.GetEmployees();
            employees.Insert(0, new Employee
            {
                EmployeeId = 0,
                FirstName = "All employees"
            });
            cbEmployees.DataSource = employees;
            dtpDate.Value = DateTime.Now;
            LoadDataForDGV();
        }

        private void LoadDataForDGV()
        {
            var products = productService.GetProducts().
                Select(x => new
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName
                })
                .ToList();
            dataGridView1.DataSource = products;
        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        private void dataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa các control hiện tại trong flowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            // Lấy danh sách các hàng đã chọn
            var selectedRows = dataGridView1.SelectedRows;

            // Duyệt qua các hàng đã chọn và hiển thị thông tin trong flowLayoutPanel
            foreach (DataGridViewRow row in selectedRows)
            {
                string productId = row.Cells["ProductId"].Value.ToString();
                string productName = row.Cells["ProductName"].Value.ToString();

                // Tạo TextBox để hiển thị ProductId
                TextBox productIdTextBox = new TextBox();
                productIdTextBox.Text = productId;
                productIdTextBox.Name = "ProductIdTextBox"; // Đặt tên cho TextBox để bạn có thể tham chiếu đến nó sau này
                productIdTextBox.ReadOnly = true;

                // Tạo TextBox để hiển thị ProductName
                TextBox productNameTextBox = new TextBox();
                productNameTextBox.Text = productName;
                productNameTextBox.Name = "ProductNameTextBox"; // Đặt tên cho TextBox
                productNameTextBox.ReadOnly = true;

                // Tạo Numeric Control để nhập số lượng
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Minimum = 0;
                numericUpDown.ValueChanged += new EventHandler(tbTotal_TextChanged_1);

                // Thêm các TextBox vào flowLayoutPanel
                flowLayoutPanel1.Controls.Add(productIdTextBox);
                flowLayoutPanel1.Controls.Add(productNameTextBox);
                flowLayoutPanel1.Controls.Add(numericUpDown);
            }
        }

        private void tbTotal_TextChanged_1(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            // Duyệt qua tất cả các controls trong flowLayoutPanel
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    // Lấy giá trị số lượng từ Numeric control
                    int quantity = Convert.ToInt32(numericUpDown.Value);

                    // Lấy tên sản phẩm từ TextBox productNameTextBox
                    TextBox productNameTextBox = flowLayoutPanel1.Controls.OfType<TextBox>()
                        .FirstOrDefault(tb => tb.Name == "ProductNameTextBox");

                    if (productNameTextBox != null)
                    {
                        string productName = productNameTextBox.Text;

                        // Tìm sản phẩm tương ứng trong danh sách sản phẩm
                        var product = productService.GetProductByName(productName);

                        if (product != null)
                        {
                            // Tính tổng giá tiền cho sản phẩm này và cộng vào tổng giá tiền
                            totalPrice += (decimal)product.UnitPrice * quantity;
                        }
                    }
                }
            }
            tbTotal.Text = totalPrice.ToString();
        }
    }
}
