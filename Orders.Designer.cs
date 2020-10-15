namespace KitchenStaff
{
    partial class Orders
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
            this.checkedListBoxOrders = new System.Windows.Forms.CheckedListBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxOrders
            // 
            this.checkedListBoxOrders.FormattingEnabled = true;
            this.checkedListBoxOrders.Items.AddRange(new object[] {
            "hello ",
            "okay"});
            this.checkedListBoxOrders.Location = new System.Drawing.Point(20, 63);
            this.checkedListBoxOrders.Name = "checkedListBoxOrders";
            this.checkedListBoxOrders.Size = new System.Drawing.Size(151, 157);
            this.checkedListBoxOrders.TabIndex = 0;
            this.checkedListBoxOrders.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(17, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(52, 17);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Orders";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(17, 263);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(28, 17);
            this.lblConfirm.TabIndex = 2;
            this.lblConfirm.Text = ".....";
            this.lblConfirm.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(199, 273);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 16;
            this.listBoxOrders.Location = new System.Drawing.Point(199, 63);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(296, 148);
            this.listBoxOrders.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(677, 395);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(20, 383);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(93, 55);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "Stock Manage";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.checkedListBoxOrders);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxOrders;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStock;
    }
}