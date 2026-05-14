namespace WinFormsApp1
{
    partial class CreateEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_title = new Label();
            label_id = new Label();
            value_id = new Label();
            label_name = new Label();
            textBox_name = new TextBox();
            textBox_desc = new TextBox();
            label_dec = new Label();
            textBox_category = new TextBox();
            label_category = new Label();
            textBox_price = new TextBox();
            label_price = new Label();
            textBox_stockQuantity = new TextBox();
            labelstockQuantity = new Label();
            label_isActive = new Label();
            textBox_discount = new TextBox();
            label_discount = new Label();
            label_createdAt = new Label();
            label_updatedAt = new Label();
            value_createdAt = new Label();
            value_updatedAt = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            checkBox_isActive = new CheckBox();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(12, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(776, 44);
            label_title.TabIndex = 1;
            label_title.Text = "Create Client";
            label_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(111, 81);
            label_id.Name = "label_id";
            label_id.Size = new Size(63, 15);
            label_id.TabIndex = 2;
            label_id.Text = "Product ID";
            // 
            // value_id
            // 
            value_id.AutoSize = true;
            value_id.Location = new Point(199, 81);
            value_id.Name = "value_id";
            value_id.Size = new Size(0, 15);
            value_id.TabIndex = 3;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(111, 116);
            label_name.Name = "label_name";
            label_name.Size = new Size(39, 15);
            label_name.TabIndex = 4;
            label_name.Text = "Name";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(199, 113);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(500, 23);
            textBox_name.TabIndex = 5;
            // 
            // textBox_desc
            // 
            textBox_desc.Location = new Point(199, 142);
            textBox_desc.Name = "textBox_desc";
            textBox_desc.Size = new Size(500, 23);
            textBox_desc.TabIndex = 7;
            // 
            // label_dec
            // 
            label_dec.AutoSize = true;
            label_dec.Location = new Point(111, 145);
            label_dec.Name = "label_dec";
            label_dec.Size = new Size(67, 15);
            label_dec.TabIndex = 6;
            label_dec.Text = "Description";
            // 
            // textBox_category
            // 
            textBox_category.Location = new Point(199, 171);
            textBox_category.Name = "textBox_category";
            textBox_category.Size = new Size(500, 23);
            textBox_category.TabIndex = 9;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Location = new Point(111, 174);
            label_category.Name = "label_category";
            label_category.Size = new Size(55, 15);
            label_category.TabIndex = 8;
            label_category.Text = "Category";
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(199, 200);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(500, 23);
            textBox_price.TabIndex = 11;
            // 
            // label_price
            // 
            label_price.AutoSize = true;
            label_price.Location = new Point(111, 203);
            label_price.Name = "label_price";
            label_price.Size = new Size(33, 15);
            label_price.TabIndex = 10;
            label_price.Text = "Price";
            // 
            // textBox_stockQuantity
            // 
            textBox_stockQuantity.Location = new Point(199, 229);
            textBox_stockQuantity.Name = "textBox_stockQuantity";
            textBox_stockQuantity.Size = new Size(500, 23);
            textBox_stockQuantity.TabIndex = 13;
            // 
            // labelstockQuantity
            // 
            labelstockQuantity.AutoSize = true;
            labelstockQuantity.Location = new Point(111, 232);
            labelstockQuantity.Name = "labelstockQuantity";
            labelstockQuantity.Size = new Size(85, 15);
            labelstockQuantity.TabIndex = 12;
            labelstockQuantity.Text = "Stock Quantity";
            // 
            // label_isActive
            // 
            label_isActive.AutoSize = true;
            label_isActive.Location = new Point(111, 261);
            label_isActive.Name = "label_isActive";
            label_isActive.Size = new Size(51, 15);
            label_isActive.TabIndex = 14;
            label_isActive.Text = "Is Active";
            // 
            // textBox_discount
            // 
            textBox_discount.Location = new Point(199, 287);
            textBox_discount.Name = "textBox_discount";
            textBox_discount.Size = new Size(500, 23);
            textBox_discount.TabIndex = 17;
            // 
            // label_discount
            // 
            label_discount.AutoSize = true;
            label_discount.Location = new Point(111, 290);
            label_discount.Name = "label_discount";
            label_discount.Size = new Size(54, 15);
            label_discount.TabIndex = 16;
            label_discount.Text = "Discount";
            // 
            // label_createdAt
            // 
            label_createdAt.AutoSize = true;
            label_createdAt.Location = new Point(111, 319);
            label_createdAt.Name = "label_createdAt";
            label_createdAt.Size = new Size(63, 15);
            label_createdAt.TabIndex = 18;
            label_createdAt.Text = "Created At";
            // 
            // label_updatedAt
            // 
            label_updatedAt.AutoSize = true;
            label_updatedAt.Location = new Point(111, 348);
            label_updatedAt.Name = "label_updatedAt";
            label_updatedAt.Size = new Size(67, 15);
            label_updatedAt.TabIndex = 20;
            label_updatedAt.Text = "Updated At";
            // 
            // value_createdAt
            // 
            value_createdAt.AutoSize = true;
            value_createdAt.Location = new Point(208, 316);
            value_createdAt.Name = "value_createdAt";
            value_createdAt.Size = new Size(0, 15);
            value_createdAt.TabIndex = 22;
            // 
            // value_updatedAt
            // 
            value_updatedAt.AutoSize = true;
            value_updatedAt.Location = new Point(199, 348);
            value_updatedAt.Name = "value_updatedAt";
            value_updatedAt.Size = new Size(0, 15);
            value_updatedAt.TabIndex = 23;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(111, 391);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(290, 23);
            btn_cancel.TabIndex = 24;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += button1_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(409, 391);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(290, 23);
            btn_save.TabIndex = 25;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isActive
            // 
            checkBox_isActive.AutoSize = true;
            checkBox_isActive.Location = new Point(202, 262);
            checkBox_isActive.Name = "checkBox_isActive";
            checkBox_isActive.Size = new Size(15, 14);
            checkBox_isActive.TabIndex = 26;
            checkBox_isActive.UseVisualStyleBackColor = true;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox_isActive);
            Controls.Add(btn_save);
            Controls.Add(btn_cancel);
            Controls.Add(value_updatedAt);
            Controls.Add(value_createdAt);
            Controls.Add(label_updatedAt);
            Controls.Add(label_createdAt);
            Controls.Add(textBox_discount);
            Controls.Add(label_discount);
            Controls.Add(label_isActive);
            Controls.Add(textBox_stockQuantity);
            Controls.Add(labelstockQuantity);
            Controls.Add(textBox_price);
            Controls.Add(label_price);
            Controls.Add(textBox_category);
            Controls.Add(label_category);
            Controls.Add(textBox_desc);
            Controls.Add(label_dec);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Controls.Add(value_id);
            Controls.Add(label_id);
            Controls.Add(label_title);
            Name = "CreateEditForm";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_id;
        private Label value_id;
        private Label label_name;
        private TextBox textBox_name;
        private TextBox textBox_desc;
        private Label label_dec;
        private TextBox textBox_category;
        private Label label_category;
        private TextBox textBox_price;
        private Label label_price;
        private TextBox textBox_stockQuantity;
        private Label labelstockQuantity;
        private Label label_isActive;
        private TextBox textBox_discount;
        private Label label_discount;
        private TextBox textBox_createdAt;
        private Label label_createdAt;
        private TextBox textBox_updatedAt;
        private Label label_updatedAt;
        private Label value_createdAt;
        private Label value_updatedAt;
        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isActive;
    }
}