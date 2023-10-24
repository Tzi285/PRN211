using DemoEF.Logics;

namespace DemoEF
{
    public partial class Form1 : Form
    {
        ProductServices productServices = new ProductServices();
        CategoryServices categoryServices = new CategoryServices();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            ComboBox.DisplayMember = "CategoryName";
            ComboBox.ValueMember = "CategoryId";
            ComboBox.DataSource = categoryServices.GetCategories();

            DataGridView.AutoGenerateColumns = false;
            LoadDataFroDGV();
        }

        private void LoadDataFroDGV()
        {
            int CategoryId = Convert.ToInt32(ComboBox.SelectedValue);
            DataGridView.DataSource = productServices.GetProducts(CategoryId)
                .Select(p => new {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    SupplierId = p.SupplierId,
                    CategoryName = categoryServices.GetCategoryById(p.CategoryId.Value).CategoryName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitsInStock = p.UnitsInStock,
                    UnitsOnOrder = p.UnitsOnOrder,
                    UnitPrice = p.UnitPrice,
                    ReorderLevel = p.ReorderLevel,
                    Discontinued = p.Discontinued
                }).ToList();
        }
        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataFroDGV();
        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}