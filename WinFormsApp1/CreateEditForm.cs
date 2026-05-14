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
        }

        private Product _editingProduct = null;

        public void EditProduct(Product product)
        {
            _editingProduct = product;

            this.Text = "Edit Product";
            this.label_title.Text = "Edit Product";

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
