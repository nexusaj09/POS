namespace POS.Forms
{
    partial class FormCreateCategory
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
            this.txtCategory = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtMarkUp = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORY NAME:";
            // 
            // txtCategory
            // 
            // 
            // 
            // 
            this.txtCategory.CustomButton.Image = null;
            this.txtCategory.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.txtCategory.CustomButton.Name = "";
            this.txtCategory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCategory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCategory.CustomButton.TabIndex = 1;
            this.txtCategory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCategory.CustomButton.UseSelectable = true;
            this.txtCategory.CustomButton.Visible = false;
            this.txtCategory.Lines = new string[0];
            this.txtCategory.Location = new System.Drawing.Point(151, 63);
            this.txtCategory.MaxLength = 32767;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategory.SelectedText = "";
            this.txtCategory.SelectionLength = 0;
            this.txtCategory.SelectionStart = 0;
            this.txtCategory.ShortcutsEnabled = true;
            this.txtCategory.Size = new System.Drawing.Size(387, 23);
            this.txtCategory.TabIndex = 1;
            this.txtCategory.UseSelectable = true;
            this.txtCategory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCategory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(429, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(314, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMarkUp
            // 
            // 
            // 
            // 
            this.txtMarkUp.CustomButton.Image = null;
            this.txtMarkUp.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtMarkUp.CustomButton.Name = "";
            this.txtMarkUp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMarkUp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMarkUp.CustomButton.TabIndex = 1;
            this.txtMarkUp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMarkUp.CustomButton.UseSelectable = true;
            this.txtMarkUp.CustomButton.Visible = false;
            this.txtMarkUp.Lines = new string[0];
            this.txtMarkUp.Location = new System.Drawing.Point(151, 92);
            this.txtMarkUp.MaxLength = 5;
            this.txtMarkUp.Name = "txtMarkUp";
            this.txtMarkUp.PasswordChar = '\0';
            this.txtMarkUp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMarkUp.SelectedText = "";
            this.txtMarkUp.SelectionLength = 0;
            this.txtMarkUp.SelectionStart = 0;
            this.txtMarkUp.ShortcutsEnabled = true;
            this.txtMarkUp.Size = new System.Drawing.Size(126, 23);
            this.txtMarkUp.TabIndex = 2;
            this.txtMarkUp.UseSelectable = true;
            this.txtMarkUp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMarkUp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMarkUp.Enter += new System.EventHandler(this.txtMarkUp_Enter);
            this.txtMarkUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarkUp_KeyPress);
            this.txtMarkUp.Leave += new System.EventHandler(this.txtMarkUp_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "MARK UP %:";
            // 
            // FormCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 171);
            this.ControlBox = false;
            this.Controls.Add(this.txtMarkUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateCategory";
            this.Resizable = false;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FormCreateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
        public MetroFramework.Controls.MetroTextBox txtCategory;
        public MetroFramework.Controls.MetroTextBox txtMarkUp;
        private System.Windows.Forms.Label label2;
    }
}