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
            label1 = new Label();
            label_id = new Label();
            label2 = new Label();
            textBox_name = new TextBox();
            textBox_desc = new TextBox();
            label3 = new Label();
            textBox_category = new TextBox();
            label4 = new Label();
            textBox_price = new TextBox();
            label5 = new Label();
            textBox_stockQuantity = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox_discount = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label_createAt = new Label();
            label_updatedAt = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 81);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Product ID";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(199, 81);
            label_id.Name = "label_id";
            label_id.Size = new Size(0, 15);
            label_id.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 116);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 145);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // textBox_category
            // 
            textBox_category.Location = new Point(199, 171);
            textBox_category.Name = "textBox_category";
            textBox_category.Size = new Size(500, 23);
            textBox_category.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 174);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Category";
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(199, 200);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(500, 23);
            textBox_price.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 203);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // textBox_stockQuantity
            // 
            textBox_stockQuantity.Location = new Point(199, 229);
            textBox_stockQuantity.Name = "textBox_stockQuantity";
            textBox_stockQuantity.Size = new Size(500, 23);
            textBox_stockQuantity.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 232);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 12;
            label6.Text = "Stock Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 261);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Is Active";
            // 
            // textBox_discount
            // 
            textBox_discount.Location = new Point(199, 287);
            textBox_discount.Name = "textBox_discount";
            textBox_discount.Size = new Size(500, 23);
            textBox_discount.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 290);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 16;
            label8.Text = "Discount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(111, 319);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 18;
            label9.Text = "Created At";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(111, 348);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 20;
            label10.Text = "Updated At";
            // 
            // label_createAt
            // 
            label_createAt.AutoSize = true;
            label_createAt.Location = new Point(208, 316);
            label_createAt.Name = "label_createAt";
            label_createAt.Size = new Size(0, 15);
            label_createAt.TabIndex = 22;
            // 
            // label_updatedAt
            // 
            label_updatedAt.AutoSize = true;
            label_updatedAt.Location = new Point(199, 348);
            label_updatedAt.Name = "label_updatedAt";
            label_updatedAt.Size = new Size(0, 15);
            label_updatedAt.TabIndex = 23;
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
            Controls.Add(label_updatedAt);
            Controls.Add(label_createAt);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox_discount);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox_stockQuantity);
            Controls.Add(label6);
            Controls.Add(textBox_price);
            Controls.Add(label5);
            Controls.Add(textBox_category);
            Controls.Add(label4);
            Controls.Add(textBox_desc);
            Controls.Add(label3);
            Controls.Add(textBox_name);
            Controls.Add(label2);
            Controls.Add(label_id);
            Controls.Add(label1);
            Controls.Add(label_title);
            Name = "CreateEditForm";
            Text = "Create Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label1;
        private Label label_id;
        private Label label2;
        private TextBox textBox_name;
        private TextBox textBox_desc;
        private Label label3;
        private TextBox textBox_category;
        private Label label4;
        private TextBox textBox_price;
        private Label label5;
        private TextBox textBox_stockQuantity;
        private Label label6;
        private Label label7;
        private TextBox textBox_discount;
        private Label label8;
        private TextBox textBox_createdAt;
        private Label label9;
        private TextBox textBox_updatedAt;
        private Label label10;
        private Label label_createAt;
        private Label label_updatedAt;
        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isActive;
    }
}