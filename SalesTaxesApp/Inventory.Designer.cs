namespace SalesTaxesApp
{
    partial class Inventory
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
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.mskPrice = new System.Windows.Forms.MaskedTextBox();
            this.chkImportedGood = new System.Windows.Forms.CheckBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInventory
            // 
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Location = new System.Drawing.Point(12, 240);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.Size = new System.Drawing.Size(657, 292);
            this.dgInventory.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(23, 28);
            this.txtCode.MaxLength = 15;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(64, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(23, 87);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(310, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 9);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 7;
            this.lblCode.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 131);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 211);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(363, 87);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(194, 21);
            this.cmbProductType.Sorted = true;
            this.cmbProductType.TabIndex = 11;
            // 
            // mskPrice
            // 
            this.mskPrice.Location = new System.Drawing.Point(23, 147);
            this.mskPrice.Mask = "#####9.99";
            this.mskPrice.Name = "mskPrice";
            this.mskPrice.Size = new System.Drawing.Size(64, 20);
            this.mskPrice.TabIndex = 13;
            // 
            // chkImportedGood
            // 
            this.chkImportedGood.AutoSize = true;
            this.chkImportedGood.Location = new System.Drawing.Point(363, 150);
            this.chkImportedGood.Name = "chkImportedGood";
            this.chkImportedGood.Size = new System.Drawing.Size(96, 17);
            this.chkImportedGood.TabIndex = 15;
            this.chkImportedGood.Text = "Imported Good";
            this.chkImportedGood.UseVisualStyleBackColor = true;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(360, 71);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(71, 13);
            this.lblProductType.TabIndex = 16;
            this.lblProductType.Text = "Product Type";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(93, 211);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveProduct.TabIndex = 17;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 544);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.chkImportedGood);
            this.Controls.Add(this.mskPrice);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dgInventory);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbProductType;        
        private System.Windows.Forms.MaskedTextBox mskPrice;
        private System.Windows.Forms.CheckBox chkImportedGood;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Button btnRemoveProduct;
    }
}