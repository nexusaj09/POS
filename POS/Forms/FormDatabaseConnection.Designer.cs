namespace POS.Forms
{
    partial class FormDatabaseConnection
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
            this.txtServerName = new MetroFramework.Controls.MetroTextBox();
            this.txtDatabaseName = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnCheckConnection = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            // 
            // 
            // 
            this.txtServerName.CustomButton.Image = null;
            this.txtServerName.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtServerName.CustomButton.Name = "";
            this.txtServerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerName.CustomButton.TabIndex = 1;
            this.txtServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerName.CustomButton.UseSelectable = true;
            this.txtServerName.CustomButton.Visible = false;
            this.txtServerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtServerName.Lines = new string[0];
            this.txtServerName.Location = new System.Drawing.Point(23, 84);
            this.txtServerName.MaxLength = 32767;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.PromptText = "Server Name";
            this.txtServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerName.SelectedText = "";
            this.txtServerName.SelectionLength = 0;
            this.txtServerName.SelectionStart = 0;
            this.txtServerName.ShortcutsEnabled = true;
            this.txtServerName.Size = new System.Drawing.Size(298, 23);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtServerName.UseSelectable = true;
            this.txtServerName.WaterMark = "Server Name";
            this.txtServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDatabaseName
            // 
            // 
            // 
            // 
            this.txtDatabaseName.CustomButton.Image = null;
            this.txtDatabaseName.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtDatabaseName.CustomButton.Name = "";
            this.txtDatabaseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDatabaseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDatabaseName.CustomButton.TabIndex = 1;
            this.txtDatabaseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDatabaseName.CustomButton.UseSelectable = true;
            this.txtDatabaseName.CustomButton.Visible = false;
            this.txtDatabaseName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDatabaseName.Lines = new string[0];
            this.txtDatabaseName.Location = new System.Drawing.Point(23, 127);
            this.txtDatabaseName.MaxLength = 32767;
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.PasswordChar = '\0';
            this.txtDatabaseName.PromptText = "Database Name";
            this.txtDatabaseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatabaseName.SelectedText = "";
            this.txtDatabaseName.SelectionLength = 0;
            this.txtDatabaseName.SelectionStart = 0;
            this.txtDatabaseName.ShortcutsEnabled = true;
            this.txtDatabaseName.Size = new System.Drawing.Size(298, 23);
            this.txtDatabaseName.TabIndex = 1;
            this.txtDatabaseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDatabaseName.UseSelectable = true;
            this.txtDatabaseName.WaterMark = "Database Name";
            this.txtDatabaseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDatabaseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(23, 167);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(298, 23);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(23, 208);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(298, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCheckConnection.ForeColor = System.Drawing.Color.White;
            this.btnCheckConnection.Location = new System.Drawing.Point(23, 248);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(298, 45);
            this.btnCheckConnection.TabIndex = 4;
            this.btnCheckConnection.Text = "Check Connection";
            this.btnCheckConnection.UseCustomBackColor = true;
            this.btnCheckConnection.UseCustomForeColor = true;
            this.btnCheckConnection.UseSelectable = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(23, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(298, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormDatabaseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(344, 367);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckConnection);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.txtServerName);
            this.Name = "FormDatabaseConnection";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Setup Database Connection";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormDatabaseConnection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtServerName;
        private MetroFramework.Controls.MetroTextBox txtDatabaseName;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnCheckConnection;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}