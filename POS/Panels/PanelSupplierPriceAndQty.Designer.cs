namespace POS.Panels
{
    partial class PanelSupplierPriceAndQty
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
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.txtSupplierPrice = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(197, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "PROCEED";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(179, 96);
            this.txtQty.MaxLength = 5;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(242, 23);
            this.txtQty.TabIndex = 11;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // txtSupplierPrice
            // 
            // 
            // 
            // 
            this.txtSupplierPrice.CustomButton.Image = null;
            this.txtSupplierPrice.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.txtSupplierPrice.CustomButton.Name = "";
            this.txtSupplierPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierPrice.CustomButton.TabIndex = 1;
            this.txtSupplierPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierPrice.CustomButton.UseSelectable = true;
            this.txtSupplierPrice.CustomButton.Visible = false;
            this.txtSupplierPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSupplierPrice.Lines = new string[0];
            this.txtSupplierPrice.Location = new System.Drawing.Point(179, 65);
            this.txtSupplierPrice.MaxLength = 32767;
            this.txtSupplierPrice.Name = "txtSupplierPrice";
            this.txtSupplierPrice.PasswordChar = '\0';
            this.txtSupplierPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierPrice.SelectedText = "";
            this.txtSupplierPrice.SelectionLength = 0;
            this.txtSupplierPrice.SelectionStart = 0;
            this.txtSupplierPrice.ShortcutsEnabled = true;
            this.txtSupplierPrice.Size = new System.Drawing.Size(242, 23);
            this.txtSupplierPrice.TabIndex = 10;
            this.txtSupplierPrice.UseSelectable = true;
            this.txtSupplierPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSupplierPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierPrice_KeyPress);
            this.txtSupplierPrice.Leave += new System.EventHandler(this.txtSupplierPrice_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "QUANTITY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "SUPPLIER PRICE:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(313, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PanelSupplierPriceAndQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(445, 187);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtSupplierPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Movable = false;
            this.Name = "PanelSupplierPriceAndQty";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Enter Supplier Price and Qty";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelSupplierPriceAndQty_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroButton btnSave;
        public MetroFramework.Controls.MetroTextBox txtQty;
        public MetroFramework.Controls.MetroTextBox txtSupplierPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnCancel;
    }
}