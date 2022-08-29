namespace SalesTaxesApp
{
    partial class CashRegister
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
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.dgShoppingCart = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShoppingCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCart
            // 
            this.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCart.Location = new System.Drawing.Point(12, 86);
            this.dgCart.Name = "dgCart";
            this.dgCart.Size = new System.Drawing.Size(845, 302);
            this.dgCart.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(395, 32);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(12, 73);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(112, 23);
            this.btnRemoveFromCart.TabIndex = 3;
            this.btnRemoveFromCart.Text = "Remove from cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // cmbProductList
            // 
            this.cmbProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(12, 34);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(327, 21);
            this.cmbProductList.Sorted = true;
            this.cmbProductList.TabIndex = 4;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(844, 372);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(112, 23);
            this.btnPrintReceipt.TabIndex = 5;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // dgShoppingCart
            // 
            this.dgShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShoppingCart.Location = new System.Drawing.Point(12, 102);
            this.dgShoppingCart.Name = "dgShoppingCart";
            this.dgShoppingCart.ReadOnly = true;
            this.dgShoppingCart.Size = new System.Drawing.Size(944, 264);
            this.dgShoppingCart.TabIndex = 6;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(13, 15);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Product";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(345, 35);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(44, 20);
            this.numQuantity.TabIndex = 8;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(345, 19);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(12, 373);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(112, 23);
            this.btnInventory.TabIndex = 10;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 408);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dgShoppingCart);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.cmbProductList);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Name = "CashRegister";
            this.Text = "Cash Register";
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShoppingCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.DataGridView dgShoppingCart;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnInventory;
    }
}

