using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class CreateEditForm : Form
    {
        private readonly ProductRepository _repo = new();
        private Product? _editingProduct;

        public CreateEditForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            SetLabelFieldsVisible(false);
        }

        public void EditProduct(Product product)
        {
            _editingProduct = product;
            Text = label_title.Text = "Edit Product";

            SetLabelFieldsVisible(true);
            value_id.Text = product.Id.ToString();
            value_createdAt.Text = product.CreatedAt.ToString();
            value_updatedAt.Text = product.UpdatedAt.ToString();

            textBox_name.Text = product.Name;
            textBox_category.Text = product.Category;
            textBox_desc.Text = product.Description;
            textBox_price.Text = product.Price.ToString();
            textBox_stockQuantity.Text = product.StockQuantity.ToString();
            checkBox_isActive.Checked = product.IsActive;
            textBox_discount.Text = product.Discount.ToString();
        }

        private void SetLabelFieldsVisible(bool visible)
        {
            label_id.Visible = value_id.Visible = label_createdAt.Visible = value_createdAt.Visible = label_updatedAt.Visible = value_updatedAt.Visible = visible;
        }

        private void ApplyFormValuesToProduct(Product product, decimal price, int stock, decimal discount)
        {
            product.Name = textBox_name.Text;
            product.Description = textBox_desc.Text;
            product.Category = textBox_category.Text;
            product.Price = price;
            product.StockQuantity = stock;
            product.IsActive = checkBox_isActive.Checked;
            product.Discount = discount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                MessageBox.Show("Name field is required.");
                return;
            }

            if (!decimal.TryParse(textBox_price.Text, out decimal price) || !int.TryParse(textBox_stockQuantity.Text, out int stock) || !decimal.TryParse(textBox_discount.Text, out decimal discount))
            {
                MessageBox.Show("Invalid input. Price and Discount must be valid decimal numbers, while Stock Quantity must be a whole number.");
                return;
            }

            if (_editingProduct == null)
            {
                // create product logic
                Product product = new Product();
                ApplyFormValuesToProduct(product, price, stock, discount);
                _repo.CreateProduct(product);
            }
            else
            {
                // update product logic
                ApplyFormValuesToProduct(_editingProduct, price, stock, discount);
                _repo.UpdateProduct(_editingProduct);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
