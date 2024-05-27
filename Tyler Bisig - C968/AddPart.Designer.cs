namespace Tyler_Bisig___C968
{
    partial class AddPart
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
            this.rb_inHouse = new System.Windows.Forms.RadioButton();
            this.rb_outsourced = new System.Windows.Forms.RadioButton();
            this.tb_partID = new System.Windows.Forms.TextBox();
            this.tb_partName = new System.Windows.Forms.TextBox();
            this.tb_partValue = new System.Windows.Forms.TextBox();
            this.tb_partInventory = new System.Windows.Forms.TextBox();
            this.tb_partMin = new System.Windows.Forms.TextBox();
            this.tb_partMax = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // rb_inHouse
            // 
            this.rb_inHouse.AutoSize = true;
            this.rb_inHouse.Location = new System.Drawing.Point(120, 12);
            this.rb_inHouse.Name = "rb_inHouse";
            this.rb_inHouse.Size = new System.Drawing.Size(68, 17);
            this.rb_inHouse.TabIndex = 1;
            this.rb_inHouse.TabStop = true;
            this.rb_inHouse.Text = "In-House";
            this.rb_inHouse.UseVisualStyleBackColor = true;
            this.rb_inHouse.CheckedChanged += new System.EventHandler(this.rb_inHouse_CheckedChanged);
            // 
            // rb_outsourced
            // 
            this.rb_outsourced.AutoSize = true;
            this.rb_outsourced.Location = new System.Drawing.Point(228, 12);
            this.rb_outsourced.Name = "rb_outsourced";
            this.rb_outsourced.Size = new System.Drawing.Size(80, 17);
            this.rb_outsourced.TabIndex = 2;
            this.rb_outsourced.TabStop = true;
            this.rb_outsourced.Text = "Outsourced";
            this.rb_outsourced.UseVisualStyleBackColor = true;
            this.rb_outsourced.CheckedChanged += new System.EventHandler(this.rb_outsourced_CheckedChanged);
            // 
            // tb_partID
            // 
            this.tb_partID.Location = new System.Drawing.Point(120, 69);
            this.tb_partID.Name = "tb_partID";
            this.tb_partID.Size = new System.Drawing.Size(100, 20);
            this.tb_partID.TabIndex = 3;
            // 
            // tb_partName
            // 
            this.tb_partName.Location = new System.Drawing.Point(120, 95);
            this.tb_partName.Name = "tb_partName";
            this.tb_partName.Size = new System.Drawing.Size(100, 20);
            this.tb_partName.TabIndex = 4;
            // 
            // tb_partValue
            // 
            this.tb_partValue.Location = new System.Drawing.Point(120, 147);
            this.tb_partValue.Name = "tb_partValue";
            this.tb_partValue.Size = new System.Drawing.Size(100, 20);
            this.tb_partValue.TabIndex = 6;
            // 
            // tb_partInventory
            // 
            this.tb_partInventory.Location = new System.Drawing.Point(120, 121);
            this.tb_partInventory.Name = "tb_partInventory";
            this.tb_partInventory.Size = new System.Drawing.Size(100, 20);
            this.tb_partInventory.TabIndex = 5;
            // 
            // tb_partMin
            // 
            this.tb_partMin.Location = new System.Drawing.Point(222, 173);
            this.tb_partMin.Name = "tb_partMin";
            this.tb_partMin.Size = new System.Drawing.Size(53, 20);
            this.tb_partMin.TabIndex = 8;
            // 
            // tb_partMax
            // 
            this.tb_partMax.Location = new System.Drawing.Point(120, 173);
            this.tb_partMax.Name = "tb_partMax";
            this.tb_partMax.Size = new System.Drawing.Size(53, 20);
            this.tb_partMax.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 199);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 9;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(89, 76);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(18, 13);
            this.lbl_Id.TabIndex = 10;
            this.lbl_Id.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(72, 98);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Location = new System.Drawing.Point(56, 124);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(51, 13);
            this.lbl_Inventory.TabIndex = 12;
            this.lbl_Inventory.Text = "Inventory";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(44, 150);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(63, 13);
            this.lbl_cost.TabIndex = 13;
            this.lbl_cost.Text = "Cost / Price";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(80, 180);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(27, 13);
            this.lbl_Max.TabIndex = 14;
            this.lbl_Max.Text = "Max";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(187, 176);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(24, 13);
            this.lbl_min.TabIndex = 15;
            this.lbl_min.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(171, 239);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(49, 23);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(226, 239);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(49, 23);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 299);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_Inventory);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tb_partMin);
            this.Controls.Add(this.tb_partMax);
            this.Controls.Add(this.tb_partValue);
            this.Controls.Add(this.tb_partInventory);
            this.Controls.Add(this.tb_partName);
            this.Controls.Add(this.tb_partID);
            this.Controls.Add(this.rb_outsourced);
            this.Controls.Add(this.rb_inHouse);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_inHouse;
        private System.Windows.Forms.RadioButton rb_outsourced;
        private System.Windows.Forms.TextBox tb_partID;
        private System.Windows.Forms.TextBox tb_partName;
        private System.Windows.Forms.TextBox tb_partValue;
        private System.Windows.Forms.TextBox tb_partInventory;
        private System.Windows.Forms.TextBox tb_partMin;
        private System.Windows.Forms.TextBox tb_partMax;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}