namespace KitchenStaff
{
    partial class Stock
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
            this.listBoxExpire = new System.Windows.Forms.ListBox();
            this.lblStockHeading = new System.Windows.Forms.Label();
            this.lblExpireHeading = new System.Windows.Forms.Label();
            this.tabControlStock = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.textBoxQuant = new System.Windows.Forms.TextBox();
            this.textBoxExpire = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.lblAddQuantity = new System.Windows.Forms.Label();
            this.lblAddExpire = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddHeading = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxLow = new System.Windows.Forms.ListBox();
            this.lblLowHeading = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.lblSubHeadingDelete = new System.Windows.Forms.Label();
            this.lblDeleteHeading = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxUpQuant = new System.Windows.Forms.TextBox();
            this.textBoxUpExpire = new System.Windows.Forms.TextBox();
            this.textBoxUpCost = new System.Windows.Forms.TextBox();
            this.lblQuantityUp = new System.Windows.Forms.Label();
            this.lblExpireUp = new System.Windows.Forms.Label();
            this.lblCostUp = new System.Windows.Forms.Label();
            this.lblStockID = new System.Windows.Forms.Label();
            this.comboBoxStockID = new System.Windows.Forms.ComboBox();
            this.textBoxUpName = new System.Windows.Forms.TextBox();
            this.lblNameStockUp = new System.Windows.Forms.Label();
            this.btnConfirmUp = new System.Windows.Forms.Button();
            this.lblUpdateHeading = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControlStock.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxExpire
            // 
            this.listBoxExpire.FormattingEnabled = true;
            this.listBoxExpire.ItemHeight = 16;
            this.listBoxExpire.Location = new System.Drawing.Point(136, 79);
            this.listBoxExpire.Name = "listBoxExpire";
            this.listBoxExpire.Size = new System.Drawing.Size(120, 84);
            this.listBoxExpire.TabIndex = 0;
            // 
            // lblStockHeading
            // 
            this.lblStockHeading.AutoSize = true;
            this.lblStockHeading.Location = new System.Drawing.Point(13, 13);
            this.lblStockHeading.Name = "lblStockHeading";
            this.lblStockHeading.Size = new System.Drawing.Size(43, 17);
            this.lblStockHeading.TabIndex = 1;
            this.lblStockHeading.Text = "Stock";
            // 
            // lblExpireHeading
            // 
            this.lblExpireHeading.AutoSize = true;
            this.lblExpireHeading.Location = new System.Drawing.Point(133, 45);
            this.lblExpireHeading.Name = "lblExpireHeading";
            this.lblExpireHeading.Size = new System.Drawing.Size(47, 17);
            this.lblExpireHeading.TabIndex = 2;
            this.lblExpireHeading.Text = "Expire";
            // 
            // tabControlStock
            // 
            this.tabControlStock.Controls.Add(this.tabPageAdd);
            this.tabControlStock.Controls.Add(this.tabPage2);
            this.tabControlStock.Controls.Add(this.tabPage3);
            this.tabControlStock.Controls.Add(this.tabPage4);
            this.tabControlStock.Location = new System.Drawing.Point(16, 33);
            this.tabControlStock.Name = "tabControlStock";
            this.tabControlStock.SelectedIndex = 0;
            this.tabControlStock.Size = new System.Drawing.Size(772, 405);
            this.tabControlStock.TabIndex = 3;
            this.tabControlStock.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.textBoxQuant);
            this.tabPageAdd.Controls.Add(this.textBoxExpire);
            this.tabPageAdd.Controls.Add(this.textBoxCost);
            this.tabPageAdd.Controls.Add(this.lblAddQuantity);
            this.tabPageAdd.Controls.Add(this.lblAddExpire);
            this.tabPageAdd.Controls.Add(this.lblAddCost);
            this.tabPageAdd.Controls.Add(this.textBoxName);
            this.tabPageAdd.Controls.Add(this.btnConfirmAdd);
            this.tabPageAdd.Controls.Add(this.lblAddName);
            this.tabPageAdd.Controls.Add(this.lblAddHeading);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(764, 376);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "tabPage1";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.Location = new System.Drawing.Point(224, 173);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuant.TabIndex = 9;
            // 
            // textBoxExpire
            // 
            this.textBoxExpire.Location = new System.Drawing.Point(224, 136);
            this.textBoxExpire.Name = "textBoxExpire";
            this.textBoxExpire.Size = new System.Drawing.Size(100, 22);
            this.textBoxExpire.TabIndex = 8;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(224, 98);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 22);
            this.textBoxCost.TabIndex = 7;
            // 
            // lblAddQuantity
            // 
            this.lblAddQuantity.AutoSize = true;
            this.lblAddQuantity.Location = new System.Drawing.Point(64, 173);
            this.lblAddQuantity.Name = "lblAddQuantity";
            this.lblAddQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblAddQuantity.TabIndex = 6;
            this.lblAddQuantity.Text = "Qauntity";
            // 
            // lblAddExpire
            // 
            this.lblAddExpire.AutoSize = true;
            this.lblAddExpire.Location = new System.Drawing.Point(61, 136);
            this.lblAddExpire.Name = "lblAddExpire";
            this.lblAddExpire.Size = new System.Drawing.Size(102, 17);
            this.lblAddExpire.TabIndex = 5;
            this.lblAddExpire.Text = "Expiration date";
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(64, 98);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(36, 17);
            this.lblAddCost.TabIndex = 4;
            this.lblAddCost.Text = "Cost";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(224, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(67, 300);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAdd.TabIndex = 2;
            this.btnConfirmAdd.Text = "confirm";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(64, 60);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(45, 17);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Name";
            // 
            // lblAddHeading
            // 
            this.lblAddHeading.AutoSize = true;
            this.lblAddHeading.Location = new System.Drawing.Point(36, 19);
            this.lblAddHeading.Name = "lblAddHeading";
            this.lblAddHeading.Size = new System.Drawing.Size(37, 17);
            this.lblAddHeading.TabIndex = 0;
            this.lblAddHeading.Text = "ADD";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxLow);
            this.tabPage2.Controls.Add(this.lblLowHeading);
            this.tabPage2.Controls.Add(this.lblExpireHeading);
            this.tabPage2.Controls.Add(this.listBoxExpire);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxLow
            // 
            this.listBoxLow.FormattingEnabled = true;
            this.listBoxLow.ItemHeight = 16;
            this.listBoxLow.Location = new System.Drawing.Point(406, 79);
            this.listBoxLow.Name = "listBoxLow";
            this.listBoxLow.Size = new System.Drawing.Size(120, 84);
            this.listBoxLow.TabIndex = 4;
            // 
            // lblLowHeading
            // 
            this.lblLowHeading.AutoSize = true;
            this.lblLowHeading.Location = new System.Drawing.Point(403, 45);
            this.lblLowHeading.Name = "lblLowHeading";
            this.lblLowHeading.Size = new System.Drawing.Size(33, 17);
            this.lblLowHeading.TabIndex = 3;
            this.lblLowHeading.Text = "Low";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxDelete);
            this.tabPage3.Controls.Add(this.btnConfirmDelete);
            this.tabPage3.Controls.Add(this.lblSubHeadingDelete);
            this.tabPage3.Controls.Add(this.lblDeleteHeading);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(39, 111);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDelete.TabIndex = 4;
            this.comboBoxDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxDelete_SelectedIndexChanged);
            this.comboBoxDelete.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.Location = new System.Drawing.Point(39, 195);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(89, 52);
            this.btnConfirmDelete.TabIndex = 3;
            this.btnConfirmDelete.Text = "Confrim Delete";
            this.btnConfirmDelete.UseVisualStyleBackColor = true;
            this.btnConfirmDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSubHeadingDelete
            // 
            this.lblSubHeadingDelete.AutoSize = true;
            this.lblSubHeadingDelete.Location = new System.Drawing.Point(36, 81);
            this.lblSubHeadingDelete.Name = "lblSubHeadingDelete";
            this.lblSubHeadingDelete.Size = new System.Drawing.Size(143, 17);
            this.lblSubHeadingDelete.TabIndex = 1;
            this.lblSubHeadingDelete.Text = "StockID to be deleted";
            // 
            // lblDeleteHeading
            // 
            this.lblDeleteHeading.AutoSize = true;
            this.lblDeleteHeading.Location = new System.Drawing.Point(6, 3);
            this.lblDeleteHeading.Name = "lblDeleteHeading";
            this.lblDeleteHeading.Size = new System.Drawing.Size(49, 17);
            this.lblDeleteHeading.TabIndex = 0;
            this.lblDeleteHeading.Text = "Delete";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxUpQuant);
            this.tabPage4.Controls.Add(this.textBoxUpExpire);
            this.tabPage4.Controls.Add(this.textBoxUpCost);
            this.tabPage4.Controls.Add(this.lblQuantityUp);
            this.tabPage4.Controls.Add(this.lblExpireUp);
            this.tabPage4.Controls.Add(this.lblCostUp);
            this.tabPage4.Controls.Add(this.lblStockID);
            this.tabPage4.Controls.Add(this.comboBoxStockID);
            this.tabPage4.Controls.Add(this.textBoxUpName);
            this.tabPage4.Controls.Add(this.lblNameStockUp);
            this.tabPage4.Controls.Add(this.btnConfirmUp);
            this.tabPage4.Controls.Add(this.lblUpdateHeading);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(764, 376);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxUpQuant
            // 
            this.textBoxUpQuant.Location = new System.Drawing.Point(349, 208);
            this.textBoxUpQuant.Name = "textBoxUpQuant";
            this.textBoxUpQuant.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpQuant.TabIndex = 11;
            // 
            // textBoxUpExpire
            // 
            this.textBoxUpExpire.Location = new System.Drawing.Point(349, 170);
            this.textBoxUpExpire.Name = "textBoxUpExpire";
            this.textBoxUpExpire.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpExpire.TabIndex = 10;
            // 
            // textBoxUpCost
            // 
            this.textBoxUpCost.Location = new System.Drawing.Point(349, 136);
            this.textBoxUpCost.Name = "textBoxUpCost";
            this.textBoxUpCost.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpCost.TabIndex = 9;
            // 
            // lblQuantityUp
            // 
            this.lblQuantityUp.AutoSize = true;
            this.lblQuantityUp.Location = new System.Drawing.Point(262, 211);
            this.lblQuantityUp.Name = "lblQuantityUp";
            this.lblQuantityUp.Size = new System.Drawing.Size(61, 17);
            this.lblQuantityUp.TabIndex = 8;
            this.lblQuantityUp.Text = "Quantity";
            // 
            // lblExpireUp
            // 
            this.lblExpireUp.AutoSize = true;
            this.lblExpireUp.Location = new System.Drawing.Point(248, 173);
            this.lblExpireUp.Name = "lblExpireUp";
            this.lblExpireUp.Size = new System.Drawing.Size(75, 17);
            this.lblExpireUp.TabIndex = 7;
            this.lblExpireUp.Text = "Expiredate";
            // 
            // lblCostUp
            // 
            this.lblCostUp.AutoSize = true;
            this.lblCostUp.Location = new System.Drawing.Point(287, 139);
            this.lblCostUp.Name = "lblCostUp";
            this.lblCostUp.Size = new System.Drawing.Size(36, 17);
            this.lblCostUp.TabIndex = 6;
            this.lblCostUp.Text = "Cost";
            // 
            // lblStockID
            // 
            this.lblStockID.AutoSize = true;
            this.lblStockID.Location = new System.Drawing.Point(249, 44);
            this.lblStockID.Name = "lblStockID";
            this.lblStockID.Size = new System.Drawing.Size(63, 17);
            this.lblStockID.TabIndex = 5;
            this.lblStockID.Text = "StockIDs";
            // 
            // comboBoxStockID
            // 
            this.comboBoxStockID.FormattingEnabled = true;
            this.comboBoxStockID.Location = new System.Drawing.Point(349, 37);
            this.comboBoxStockID.Name = "comboBoxStockID";
            this.comboBoxStockID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStockID.TabIndex = 4;
            this.comboBoxStockID.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // textBoxUpName
            // 
            this.textBoxUpName.Location = new System.Drawing.Point(349, 104);
            this.textBoxUpName.Name = "textBoxUpName";
            this.textBoxUpName.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpName.TabIndex = 3;
            // 
            // lblNameStockUp
            // 
            this.lblNameStockUp.AutoSize = true;
            this.lblNameStockUp.Location = new System.Drawing.Point(225, 107);
            this.lblNameStockUp.Name = "lblNameStockUp";
            this.lblNameStockUp.Size = new System.Drawing.Size(98, 17);
            this.lblNameStockUp.TabIndex = 2;
            this.lblNameStockUp.Text = "Name of stock";
            this.lblNameStockUp.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnConfirmUp
            // 
            this.btnConfirmUp.Location = new System.Drawing.Point(9, 205);
            this.btnConfirmUp.Name = "btnConfirmUp";
            this.btnConfirmUp.Size = new System.Drawing.Size(83, 53);
            this.btnConfirmUp.TabIndex = 1;
            this.btnConfirmUp.Text = "Confirm Update";
            this.btnConfirmUp.UseVisualStyleBackColor = true;
            this.btnConfirmUp.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblUpdateHeading
            // 
            this.lblUpdateHeading.AutoSize = true;
            this.lblUpdateHeading.Location = new System.Drawing.Point(6, 3);
            this.lblUpdateHeading.Name = "lblUpdateHeading";
            this.lblUpdateHeading.Size = new System.Drawing.Size(54, 17);
            this.lblUpdateHeading.TabIndex = 0;
            this.lblUpdateHeading.Text = "Update";
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(20, 456);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(73, 44);
            this.btnOrders.TabIndex = 4;
            this.btnOrders.Text = "Orders manage";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(708, 468);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 512);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.tabControlStock);
            this.Controls.Add(this.lblStockHeading);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.tabControlStock.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxExpire;
        private System.Windows.Forms.Label lblStockHeading;
        private System.Windows.Forms.Label lblExpireHeading;
        private System.Windows.Forms.TabControl tabControlStock;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddHeading;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.Label lblSubHeadingDelete;
        private System.Windows.Forms.Label lblDeleteHeading;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxUpName;
        private System.Windows.Forms.Label lblNameStockUp;
        private System.Windows.Forms.Button btnConfirmUp;
        private System.Windows.Forms.Label lblUpdateHeading;
        private System.Windows.Forms.ListBox listBoxLow;
        private System.Windows.Forms.Label lblLowHeading;
        private System.Windows.Forms.Label lblStockID;
        private System.Windows.Forms.ComboBox comboBoxStockID;
        private System.Windows.Forms.TextBox textBoxUpQuant;
        private System.Windows.Forms.TextBox textBoxUpExpire;
        private System.Windows.Forms.TextBox textBoxUpCost;
        private System.Windows.Forms.Label lblQuantityUp;
        private System.Windows.Forms.Label lblExpireUp;
        private System.Windows.Forms.Label lblCostUp;
        private System.Windows.Forms.TextBox textBoxQuant;
        private System.Windows.Forms.TextBox textBoxExpire;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label lblAddQuantity;
        private System.Windows.Forms.Label lblAddExpire;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.ComboBox comboBoxDelete;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnLogout;
    }
}