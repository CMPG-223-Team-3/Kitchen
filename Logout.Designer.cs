namespace KitchenStaff
{
    partial class Logout
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblOUT = new System.Windows.Forms.Label();
            this.textBoxIN = new System.Windows.Forms.TextBox();
            this.textBoxOUT = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrdderform = new System.Windows.Forms.Button();
            this.btnStockform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(82, 37);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(52, 17);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Logout";
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(35, 112);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(58, 17);
            this.lblIN.TabIndex = 1;
            this.lblIN.Text = "Time in ";
            // 
            // lblOUT
            // 
            this.lblOUT.AutoSize = true;
            this.lblOUT.Location = new System.Drawing.Point(35, 166);
            this.lblOUT.Name = "lblOUT";
            this.lblOUT.Size = new System.Drawing.Size(67, 17);
            this.lblOUT.TabIndex = 2;
            this.lblOUT.Text = "Time out ";
            // 
            // textBoxIN
            // 
            this.textBoxIN.Location = new System.Drawing.Point(116, 112);
            this.textBoxIN.Name = "textBoxIN";
            this.textBoxIN.Size = new System.Drawing.Size(100, 22);
            this.textBoxIN.TabIndex = 3;
            // 
            // textBoxOUT
            // 
            this.textBoxOUT.Location = new System.Drawing.Point(116, 166);
            this.textBoxOUT.Name = "textBoxOUT";
            this.textBoxOUT.Size = new System.Drawing.Size(100, 22);
            this.textBoxOUT.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(116, 248);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Confirm Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrdderform
            // 
            this.btnOrdderform.Location = new System.Drawing.Point(38, 385);
            this.btnOrdderform.Name = "btnOrdderform";
            this.btnOrdderform.Size = new System.Drawing.Size(79, 43);
            this.btnOrdderform.TabIndex = 6;
            this.btnOrdderform.Text = "Orders manage";
            this.btnOrdderform.UseVisualStyleBackColor = true;
            this.btnOrdderform.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStockform
            // 
            this.btnStockform.Location = new System.Drawing.Point(684, 385);
            this.btnStockform.Name = "btnStockform";
            this.btnStockform.Size = new System.Drawing.Size(78, 43);
            this.btnStockform.TabIndex = 7;
            this.btnStockform.Text = "Stock Manage";
            this.btnStockform.UseVisualStyleBackColor = true;
            this.btnStockform.Click += new System.EventHandler(this.button2_Click);
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStockform);
            this.Controls.Add(this.btnOrdderform);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.textBoxOUT);
            this.Controls.Add(this.textBoxIN);
            this.Controls.Add(this.lblOUT);
            this.Controls.Add(this.lblIN);
            this.Controls.Add(this.lblHeading);
            this.Name = "Logout";
            this.Text = "Logout";
            this.Load += new System.EventHandler(this.Logout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.Label lblOUT;
        private System.Windows.Forms.TextBox textBoxIN;
        private System.Windows.Forms.TextBox textBoxOUT;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOrdderform;
        private System.Windows.Forms.Button btnStockform;
    }
}