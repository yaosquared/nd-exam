namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btn_addProduct = new Button();
            btn_editClient = new Button();
            btn_deleteProduct = new Button();
            productsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 44);
            label1.TabIndex = 0;
            label1.Text = "Products";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_addProduct
            // 
            btn_addProduct.Location = new Point(12, 56);
            btn_addProduct.Name = "btn_addProduct";
            btn_addProduct.Size = new Size(100, 30);
            btn_addProduct.TabIndex = 1;
            btn_addProduct.Text = "Add Product";
            btn_addProduct.UseVisualStyleBackColor = true;
            btn_addProduct.Click += btn_addProduct_Click;
            // 
            // btn_editClient
            // 
            btn_editClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editClient.Location = new Point(582, 56);
            btn_editClient.Name = "btn_editClient";
            btn_editClient.Size = new Size(100, 30);
            btn_editClient.TabIndex = 2;
            btn_editClient.Text = "Edit Product";
            btn_editClient.UseVisualStyleBackColor = true;
            btn_editClient.Click += btn_editClient_Click;
            // 
            // btn_deleteProduct
            // 
            btn_deleteProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_deleteProduct.Location = new Point(688, 56);
            btn_deleteProduct.Name = "btn_deleteProduct";
            btn_deleteProduct.Size = new Size(100, 30);
            btn_deleteProduct.TabIndex = 3;
            btn_deleteProduct.Text = "Delete Product";
            btn_deleteProduct.UseVisualStyleBackColor = true;
            btn_deleteProduct.Click += btn_deleteProduct_Click;
            // 
            // productsTable
            // 
            productsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Location = new Point(12, 92);
            productsTable.MultiSelect = false;
            productsTable.Name = "productsTable";
            productsTable.RowHeadersVisible = false;
            productsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsTable.Size = new Size(776, 346);
            productsTable.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productsTable);
            Controls.Add(btn_deleteProduct);
            Controls.Add(btn_editClient);
            Controls.Add(btn_addProduct);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ecommerce Manager";
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_addProduct;
        private Button btn_editClient;
        private Button btn_deleteProduct;
        private DataGridView productsTable;
    }
}
