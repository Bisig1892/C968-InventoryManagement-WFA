﻿namespace Tyler_Bisig___C968
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_productId = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_productInventory = new System.Windows.Forms.TextBox();
            this.tb_productMax = new System.Windows.Forms.TextBox();
            this.tb_productMin = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_productPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dg_candidateParts = new System.Windows.Forms.DataGridView();
            this.btn_AddPartToProduct = new System.Windows.Forms.Button();
            this.btn_SearchAddProduct = new System.Windows.Forms.Button();
            this.btn_DeletePartFromProduct = new System.Windows.Forms.Button();
            this.dg_associatedParts = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SaveProduct = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_SearchPartsTable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_candidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_associatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // tb_productId
            // 
            this.tb_productId.Enabled = false;
            this.tb_productId.Location = new System.Drawing.Point(103, 153);
            this.tb_productId.Name = "tb_productId";
            this.tb_productId.Size = new System.Drawing.Size(100, 20);
            this.tb_productId.TabIndex = 1;
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(103, 179);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(100, 20);
            this.tb_productName.TabIndex = 2;
            // 
            // tb_productInventory
            // 
            this.tb_productInventory.Location = new System.Drawing.Point(103, 205);
            this.tb_productInventory.Name = "tb_productInventory";
            this.tb_productInventory.Size = new System.Drawing.Size(100, 20);
            this.tb_productInventory.TabIndex = 3;
            this.tb_productInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitKeyPress);
            // 
            // tb_productMax
            // 
            this.tb_productMax.Location = new System.Drawing.Point(74, 257);
            this.tb_productMax.Name = "tb_productMax";
            this.tb_productMax.Size = new System.Drawing.Size(50, 20);
            this.tb_productMax.TabIndex = 5;
            this.tb_productMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitKeyPress);
            // 
            // tb_productMin
            // 
            this.tb_productMin.Location = new System.Drawing.Point(169, 257);
            this.tb_productMin.Name = "tb_productMin";
            this.tb_productMin.Size = new System.Drawing.Size(50, 20);
            this.tb_productMin.TabIndex = 6;
            this.tb_productMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitKeyPress);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(41, 156);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Min";
            // 
            // tb_productPrice
            // 
            this.tb_productPrice.Location = new System.Drawing.Point(103, 231);
            this.tb_productPrice.Name = "tb_productPrice";
            this.tb_productPrice.Size = new System.Drawing.Size(100, 20);
            this.tb_productPrice.TabIndex = 4;
            this.tb_productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "All Candidate Parts";
            // 
            // dg_candidateParts
            // 
            this.dg_candidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_candidateParts.Location = new System.Drawing.Point(292, 130);
            this.dg_candidateParts.Name = "dg_candidateParts";
            this.dg_candidateParts.Size = new System.Drawing.Size(633, 150);
            this.dg_candidateParts.TabIndex = 14;
            // 
            // btn_AddPartToProduct
            // 
            this.btn_AddPartToProduct.Location = new System.Drawing.Point(850, 293);
            this.btn_AddPartToProduct.Name = "btn_AddPartToProduct";
            this.btn_AddPartToProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_AddPartToProduct.TabIndex = 9;
            this.btn_AddPartToProduct.Text = "Add";
            this.btn_AddPartToProduct.UseVisualStyleBackColor = true;
            this.btn_AddPartToProduct.Click += new System.EventHandler(this.btn_AddPartToProduct_Click);
            // 
            // btn_SearchAddProduct
            // 
            this.btn_SearchAddProduct.Location = new System.Drawing.Point(606, 91);
            this.btn_SearchAddProduct.Name = "btn_SearchAddProduct";
            this.btn_SearchAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchAddProduct.TabIndex = 8;
            this.btn_SearchAddProduct.Text = "Search";
            this.btn_SearchAddProduct.UseVisualStyleBackColor = true;
            this.btn_SearchAddProduct.Click += new System.EventHandler(this.btn_SearchAddProduct_Click);
            // 
            // btn_DeletePartFromProduct
            // 
            this.btn_DeletePartFromProduct.Location = new System.Drawing.Point(850, 508);
            this.btn_DeletePartFromProduct.Name = "btn_DeletePartFromProduct";
            this.btn_DeletePartFromProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_DeletePartFromProduct.TabIndex = 10;
            this.btn_DeletePartFromProduct.Text = "Delete";
            this.btn_DeletePartFromProduct.UseVisualStyleBackColor = true;
            this.btn_DeletePartFromProduct.Click += new System.EventHandler(this.btn_DeletePartFromProduct_Click);
            // 
            // dg_associatedParts
            // 
            this.dg_associatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_associatedParts.Location = new System.Drawing.Point(292, 345);
            this.dg_associatedParts.Name = "dg_associatedParts";
            this.dg_associatedParts.Size = new System.Drawing.Size(633, 150);
            this.dg_associatedParts.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Parts Associated with this Product";
            // 
            // btn_SaveProduct
            // 
            this.btn_SaveProduct.Location = new System.Drawing.Point(752, 580);
            this.btn_SaveProduct.Name = "btn_SaveProduct";
            this.btn_SaveProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveProduct.TabIndex = 11;
            this.btn_SaveProduct.Text = "Save";
            this.btn_SaveProduct.UseVisualStyleBackColor = true;
            this.btn_SaveProduct.Click += new System.EventHandler(this.btn_SaveProduct_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(850, 580);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_SearchPartsTable
            // 
            this.tb_SearchPartsTable.Location = new System.Drawing.Point(687, 94);
            this.tb_SearchPartsTable.Name = "tb_SearchPartsTable";
            this.tb_SearchPartsTable.Size = new System.Drawing.Size(238, 20);
            this.tb_SearchPartsTable.TabIndex = 7;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 625);
            this.Controls.Add(this.tb_SearchPartsTable);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveProduct);
            this.Controls.Add(this.btn_DeletePartFromProduct);
            this.Controls.Add(this.dg_associatedParts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_SearchAddProduct);
            this.Controls.Add(this.btn_AddPartToProduct);
            this.Controls.Add(this.dg_candidateParts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_productPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.tb_productMin);
            this.Controls.Add(this.tb_productMax);
            this.Controls.Add(this.tb_productInventory);
            this.Controls.Add(this.tb_productName);
            this.Controls.Add(this.tb_productId);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dg_candidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_associatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_productId;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.TextBox tb_productInventory;
        private System.Windows.Forms.TextBox tb_productMax;
        private System.Windows.Forms.TextBox tb_productMin;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_productPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dg_candidateParts;
        private System.Windows.Forms.Button btn_AddPartToProduct;
        private System.Windows.Forms.Button btn_SearchAddProduct;
        private System.Windows.Forms.Button btn_DeletePartFromProduct;
        private System.Windows.Forms.DataGridView dg_associatedParts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SaveProduct;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_SearchPartsTable;
    }
}