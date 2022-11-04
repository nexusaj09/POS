namespace POS.Forms
{
    partial class FormCreateDiscount
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
            this.txtPercentage = new MetroFramework.Controls.MetroTextBox();
            this.txtDescr = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtPercentage
            // 
            // 
            // 
            // 
            this.txtPercentage.CustomButton.Image = null;
            this.txtPercentage.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.txtPercentage.CustomButton.Name = "";
            this.txtPercentage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPercentage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPercentage.CustomButton.TabIndex = 1;
            this.txtPercentage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPercentage.CustomButton.UseSelectable = true;
            this.txtPercentage.CustomButton.Visible = false;
            this.txtPercentage.Lines = new string[0];
            this.txtPercentage.Location = new System.Drawing.Point(126, 91);
            this.txtPercentage.MaxLength = 5;
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.PasswordChar = '\0';
            this.txtPercentage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPercentage.SelectedText = "";
            this.txtPercentage.SelectionLength = 0;
            this.txtPercentage.SelectionStart = 0;
            this.txtPercentage.ShortcutsEnabled = true;
            this.txtPercentage.Size = new System.Drawing.Size(131, 23);
            this.txtPercentage.TabIndex = 5;
            this.txtPercentage.UseSelectable = true;
            this.txtPercentage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPercentage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPercentage.Enter += new System.EventHandler(this.txtPercentage_Enter);
            this.txtPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentage_KeyPress);
            this.txtPercentage.Leave += new System.EventHandler(this.txtPercentage_Leave);
            // 
            // txtDescr
            // 
            // 
            // 
            // 
            this.txtDescr.CustomButton.Image = null;
            this.txtDescr.CustomButton.Location = new System.Drawing.Point(396, 1);
            this.txtDescr.CustomButton.Name = "";
            this.txtDescr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescr.CustomButton.TabIndex = 1;
            this.txtDescr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescr.CustomButton.UseSelectable = true;
            this.txtDescr.CustomButton.Visible = false;
            this.txtDescr.Lines = new string[0];
            this.txtDescr.Location = new System.Drawing.Point(126, 62);
            this.txtDescr.MaxLength = 32767;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.PasswordChar = '\0';
            this.txtDescr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescr.SelectedText = "";
            this.txtDescr.SelectionLength = 0;
            this.txtDescr.SelectionStart = 0;
            this.txtDescr.ShortcutsEnabled = true;
            this.txtDescr.Size = new System.Drawing.Size(418, 23);
            this.txtDescr.TabIndex = 4;
            this.txtDescr.UseSelectable = true;
            this.txtDescr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "PERCENTAGE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "DESCRIPTION:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(435, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(320, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormCreateDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(561, 171);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateDiscount";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.FormCreateDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox txtPercentage;
        public MetroFramework.Controls.MetroTextBox txtDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
    }
}