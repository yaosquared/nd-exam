using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;

            // hide id and date fields by default (add mode)
            label_id.Visible = false;
            value_id.Visible = false;
            label_createdAt.Visible = false;
            value_createdAt.Visible = false;
            label_updatedAt.Visible = false;
            value_updatedAt.Visible = false;
        }

        private Product _editingProduct = null;

        public void EditProduct(Product product)
        {
            _editingProduct = product;

            this.Text = "Edit Product";
            this.label_title.Text = "Edit Product";

            // show id and date fields
            label_id.Visible = true;
            value_id.Visible = true;
            label_createdAt.Visible = true;
            value_createdAt.Visible = true;
            label_updatedAt.Visible = true;
            value_updatedAt.Visible = true;

            // populate id and date fields
            value_id.Text = product.Id.ToString();
            value_createdAt.Text = product.CreatedAt.ToString();
            value_updatedAt.Text = product.UpdatedAt.ToString();

            this.textBox_name.Text = product.Name;
            this.textBox_category.Text = product.Category;
            this.textBox_desc.Text = product.Description;
            this.textBox_price.Text = product.Price.ToString();
            this.textBox_stockQuantity.Text = product.StockQuantity.ToString();
            this.checkBox_isActive.Checked = product.IsActive;
            this.textBox_discount.Text = product.Discount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            if (!decimal.TryParse(textBox_price.Text, out decimal price) ||
                !int.TryParse(textBox_stockQuantity.Text, out int stock) ||
                !decimal.TryParse(textBox_discount.Text, out decimal discount))
            {
                MessageBox.Show("Please enter valid values for Price, Stock, and Discount.");
                return;
            }

            var repo = new ProductRepository();

            if (_editingProduct == null)
            {
                // create product logic
                Product product = new Product
                {
                    Name = this.textBox_name.Text,
                    Description = this.textBox_desc.Text,
                    Category = this.textBox_category.Text,
                    Price = decimal.Parse(this.textBox_price.Text),
                    StockQuantity = int.Parse(this.textBox_stockQuantity.Text),
                    IsActive = this.checkBox_isActive.Checked,
                    Discount = decimal.Parse(this.textBox_discount.Text)
                };

                repo.CreateProduct(product);
            }
            else
            {
                // update product logic
                _editingProduct.Name = this.textBox_name.Text;
                _editingProduct.Description = this.textBox_desc.Text;
                _editingProduct.Category = this.textBox_category.Text;
                _editingProduct.Price = decimal.Parse(this.textBox_price.Text);
                _editingProduct.StockQuantity = int.Parse(this.textBox_stockQuantity.Text);
                _editingProduct.IsActive = this.checkBox_isActive.Checked;
                _editingProduct.Discount = decimal.Parse(this.textBox_discount.Text);

                repo.UpdateProduct(_editingProduct);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
