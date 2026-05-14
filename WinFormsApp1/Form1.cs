using System.Data;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FetchProducts();
        }

        private void FetchProducts()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("StockQuantity");
            dataTable.Columns.Add("IsActive");
            dataTable.Columns.Add("Discount");
            dataTable.Columns.Add("CreatedAt");
            dataTable.Columns.Add("UpdatedAt");


            var repo = new ProductRepository();
            var products = repo.GetProducts();

            foreach (var product in products)
            {
                var row = dataTable.NewRow();

                row["ID"] = product.Id;
                row["Name"] = product.Name;
                row["Description"] = product.Description;
                row["Category"] = product.Category;
                row["Price"] = product.Price;
                row["StockQuantity"] = product.StockQuantity;
                row["IsActive"] = product.IsActive;
                row["Discount"] = product.Discount;
                row["CreatedAt"] = product.CreatedAt;
                row["UpdatedAt"] = product.UpdatedAt;

                dataTable.Rows.Add(row);
            }

            this.productsTable.DataSource = dataTable;
        }

        private void btn_editClient_Click(object sender, EventArgs e)
        {
            if (productsTable.CurrentRow == null)
                return;

            int id = Convert.ToInt32(productsTable.CurrentRow.Cells["ID"].Value);

            var repo = new ProductRepository();
            var product = repo.GetProduct(id);

            if (product == null)
                return;

            CreateEditForm form = new CreateEditForm();
            form.EditProduct(product);

            if (form.ShowDialog() == DialogResult.OK)
            {
                FetchProducts();
            }
        }
        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            CreateEditForm form = new CreateEditForm();
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    FetchProducts();
                }
            }
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            var row = productsTable.SelectedRows[0];

            if (row.Cells["ID"].Value == null)
                return;

            int productId = Convert.ToInt32(row.Cells["ID"].Value);

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            var repo = new ProductRepository();
            repo.DeleteProduct(productId);

            FetchProducts();
        }
    }
}
