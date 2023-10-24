using DemoEF_1.Models;
using DemoEF_1.Service;

namespace DemoEF_1
{
    public partial class Form1 : Form
    {
        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataFroDGV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if the row index or the column index is negative or not
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Product selectedProduct = productService.getProductById(productId);
            tbProductName.Text = selectedProduct.ProductName;
            nudPrice.Value = Convert.ToDecimal(selectedProduct.UnitPrice);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
            comboBox1.DataSource = categoryService.GetCategories();
            //hien thi design cho datagridview
            dataGridView1.AutoGenerateColumns = false;

            LoadDataFroDGV();
        }

        private void LoadDataFroDGV()
        {
            int CategoryId = Convert.ToInt32(comboBox1.SelectedValue);

            dataGridView1.DataSource = productService.GetProductByCateId(CategoryId)
                .Select(p => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.SupplierId,
                    categoryService.GetCategoryById(p.CategoryId.Value).CategoryName,
                    p.QuantityPerUnit,
                    p.UnitsInStock,
                    p.UnitsOnOrder,
                    p.UnitPrice,
                    p.ReorderLevel,
                    p.Discontinued
                }).ToList();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void tbProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbProductCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}