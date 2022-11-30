namespace POS.Forms
{
    partial class FormCreateInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.lblTotalInvoice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.lblTotalQTY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new MetroFramework.Controls.MetroButton();
            this.txtSupplier = new MetroFramework.Controls.MetroTextBox();
            this.txtContactPerson = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTranDate = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreatedBy = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefNbr = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.grdInvoiceList = new MetroFramework.Controls.MetroGrid();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIERPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALINVOICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Controls.Add(this.metroPanel3);
            this.panel1.Controls.Add(this.metroPanel4);
            this.panel1.Controls.Add(this.btnSearchSupplier);
            this.panel1.Controls.Add(this.txtSupplier);
            this.panel1.Controls.Add(this.txtContactPerson);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtTranDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCreatedBy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRefNbr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1758, 175);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(180, 127);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(213, 30);
            this.btnSearchProduct.TabIndex = 19;
            this.btnSearchProduct.Text = "SEARCH PRODUCT";
            this.btnSearchProduct.UseCustomBackColor = true;
            this.btnSearchProduct.UseCustomForeColor = true;
            this.btnSearchProduct.UseSelectable = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.metroPanel3.Controls.Add(this.lblTotalInvoice);
            this.metroPanel3.Controls.Add(this.label4);
            this.metroPanel3.Controls.Add(this.label7);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(1547, 7);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(207, 79);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 13;
            // 
            // lblTotalInvoice
            // 
            this.lblTotalInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalInvoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoice.ForeColor = System.Drawing.Color.White;
            this.lblTotalInvoice.Location = new System.Drawing.Point(0, 33);
            this.lblTotalInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInvoice.Name = "lblTotalInvoice";
            this.lblTotalInvoice.Size = new System.Drawing.Size(207, 46);
            this.lblTotalInvoice.TabIndex = 5;
            this.lblTotalInvoice.Text = "0.00";
            this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOTAL PRODUCTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 33);
            this.label7.TabIndex = 3;
            this.label7.Text = "INVOICE TOTAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.metroPanel4.Controls.Add(this.lblTotalQTY);
            this.metroPanel4.Controls.Add(this.label8);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 12;
            this.metroPanel4.Location = new System.Drawing.Point(1547, 90);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(207, 79);
            this.metroPanel4.TabIndex = 7;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 13;
            // 
            // lblTotalQTY
            // 
            this.lblTotalQTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalQTY.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQTY.ForeColor = System.Drawing.Color.White;
            this.lblTotalQTY.Location = new System.Drawing.Point(0, 33);
            this.lblTotalQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalQTY.Name = "lblTotalQTY";
            this.lblTotalQTY.Size = new System.Drawing.Size(207, 46);
            this.lblTotalQTY.TabIndex = 3;
            this.lblTotalQTY.Text = "0";
            this.lblTotalQTY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 33);
            this.label8.TabIndex = 2;
            this.label8.Text = "TOTAL QTY";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSearchSupplier.Location = new System.Drawing.Point(1233, 12);
            this.btnSearchSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(168, 28);
            this.btnSearchSupplier.TabIndex = 18;
            this.btnSearchSupplier.Text = "SEARCH SUPPLIER";
            this.btnSearchSupplier.UseCustomBackColor = true;
            this.btnSearchSupplier.UseCustomForeColor = true;
            this.btnSearchSupplier.UseSelectable = true;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // txtSupplier
            // 
            // 
            // 
            // 
            this.txtSupplier.CustomButton.Image = null;
            this.txtSupplier.CustomButton.Location = new System.Drawing.Point(374, 2);
            this.txtSupplier.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplier.CustomButton.Name = "";
            this.txtSupplier.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplier.CustomButton.TabIndex = 1;
            this.txtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplier.CustomButton.UseSelectable = true;
            this.txtSupplier.CustomButton.Visible = false;
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Lines = new string[0];
            this.txtSupplier.Location = new System.Drawing.Point(825, 12);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplier.MaxLength = 32767;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.SelectionLength = 0;
            this.txtSupplier.SelectionStart = 0;
            this.txtSupplier.ShortcutsEnabled = true;
            this.txtSupplier.Size = new System.Drawing.Size(400, 28);
            this.txtSupplier.TabIndex = 11;
            this.txtSupplier.UseSelectable = true;
            this.txtSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplier.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContactPerson
            // 
            // 
            // 
            // 
            this.txtContactPerson.CustomButton.Image = null;
            this.txtContactPerson.CustomButton.Location = new System.Drawing.Point(374, 2);
            this.txtContactPerson.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactPerson.CustomButton.Name = "";
            this.txtContactPerson.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtContactPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactPerson.CustomButton.TabIndex = 1;
            this.txtContactPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactPerson.CustomButton.UseSelectable = true;
            this.txtContactPerson.CustomButton.Visible = false;
            this.txtContactPerson.Lines = new string[0];
            this.txtContactPerson.Location = new System.Drawing.Point(825, 48);
            this.txtContactPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactPerson.MaxLength = 32767;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.PasswordChar = '\0';
            this.txtContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactPerson.SelectedText = "";
            this.txtContactPerson.SelectionLength = 0;
            this.txtContactPerson.SelectionStart = 0;
            this.txtContactPerson.ShortcutsEnabled = true;
            this.txtContactPerson.Size = new System.Drawing.Size(400, 28);
            this.txtContactPerson.TabIndex = 9;
            this.txtContactPerson.UseSelectable = true;
            this.txtContactPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "CONTACT PERSON:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(671, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "SUPPLIER:";
            // 
            // dtTranDate
            // 
            this.dtTranDate.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTranDate.Location = new System.Drawing.Point(180, 84);
            this.dtTranDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtTranDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTranDate.Name = "dtTranDate";
            this.dtTranDate.Size = new System.Drawing.Size(408, 30);
            this.dtTranDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "TRANSACTION DATE:";
            // 
            // txtCreatedBy
            // 
            // 
            // 
            // 
            this.txtCreatedBy.CustomButton.Image = null;
            this.txtCreatedBy.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.txtCreatedBy.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreatedBy.CustomButton.Name = "";
            this.txtCreatedBy.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCreatedBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreatedBy.CustomButton.TabIndex = 1;
            this.txtCreatedBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreatedBy.CustomButton.UseSelectable = true;
            this.txtCreatedBy.CustomButton.Visible = false;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Lines = new string[0];
            this.txtCreatedBy.Location = new System.Drawing.Point(180, 48);
            this.txtCreatedBy.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreatedBy.MaxLength = 32767;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PasswordChar = '\0';
            this.txtCreatedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.SelectionLength = 0;
            this.txtCreatedBy.SelectionStart = 0;
            this.txtCreatedBy.ShortcutsEnabled = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(409, 28);
            this.txtCreatedBy.TabIndex = 3;
            this.txtCreatedBy.UseSelectable = true;
            this.txtCreatedBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreatedBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CREATED BY:";
            // 
            // txtRefNbr
            // 
            // 
            // 
            // 
            this.txtRefNbr.CustomButton.Image = null;
            this.txtRefNbr.CustomButton.Location = new System.Drawing.Point(383, 2);
            this.txtRefNbr.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefNbr.CustomButton.Name = "";
            this.txtRefNbr.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRefNbr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRefNbr.CustomButton.TabIndex = 1;
            this.txtRefNbr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRefNbr.CustomButton.UseSelectable = true;
            this.txtRefNbr.CustomButton.Visible = false;
            this.txtRefNbr.Enabled = false;
            this.txtRefNbr.Lines = new string[0];
            this.txtRefNbr.Location = new System.Drawing.Point(180, 12);
            this.txtRefNbr.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefNbr.MaxLength = 32767;
            this.txtRefNbr.Name = "txtRefNbr";
            this.txtRefNbr.PasswordChar = '\0';
            this.txtRefNbr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefNbr.SelectedText = "";
            this.txtRefNbr.SelectionLength = 0;
            this.txtRefNbr.SelectionStart = 0;
            this.txtRefNbr.ShortcutsEnabled = true;
            this.txtRefNbr.Size = new System.Drawing.Size(409, 28);
            this.txtRefNbr.TabIndex = 1;
            this.txtRefNbr.UseSelectable = true;
            this.txtRefNbr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefNbr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "REFERENCE NBR:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(27, 925);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1758, 49);
            this.panel3.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1609, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 37);
            this.btnCancel.TabIndex = 24;
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
            this.btnSave.Location = new System.Drawing.Point(1455, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 37);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdInvoiceList
            // 
            this.grdInvoiceList.AllowUserToAddRows = false;
            this.grdInvoiceList.AllowUserToDeleteRows = false;
            this.grdInvoiceList.AllowUserToResizeRows = false;
            this.grdInvoiceList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdInvoiceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdInvoiceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdInvoiceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.ID,
            this.PRODUCTCODE,
            this.DESCR,
            this.SUPPLIERPRICE,
            this.QTY,
            this.TOTALINVOICE,
            this.DELETE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInvoiceList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInvoiceList.EnableHeadersVisualStyles = false;
            this.grdInvoiceList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdInvoiceList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdInvoiceList.Location = new System.Drawing.Point(27, 249);
            this.grdInvoiceList.Margin = new System.Windows.Forms.Padding(4);
            this.grdInvoiceList.MultiSelect = false;
            this.grdInvoiceList.Name = "grdInvoiceList";
            this.grdInvoiceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdInvoiceList.RowHeadersWidth = 51;
            this.grdInvoiceList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdInvoiceList.RowTemplate.Height = 26;
            this.grdInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoiceList.Size = new System.Drawing.Size(1758, 676);
            this.grdInvoiceList.TabIndex = 12;
            this.grdInvoiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellContentClick);
            this.grdInvoiceList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellEndEdit);
            this.grdInvoiceList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdInvoiceList_EditingControlShowing);
            this.grdInvoiceList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdProductList_KeyDown);
            this.grdInvoiceList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdInvoiceList_KeyPress);
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Count.HeaderText = "#";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 39;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // PRODUCTCODE
            // 
            this.PRODUCTCODE.HeaderText = "PRODUCT CODE";
            this.PRODUCTCODE.MinimumWidth = 6;
            this.PRODUCTCODE.Name = "PRODUCTCODE";
            this.PRODUCTCODE.ReadOnly = true;
            this.PRODUCTCODE.Width = 250;
            // 
            // DESCR
            // 
            this.DESCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCR.HeaderText = "DESCRIPTION";
            this.DESCR.MinimumWidth = 6;
            this.DESCR.Name = "DESCR";
            this.DESCR.ReadOnly = true;
            // 
            // SUPPLIERPRICE
            // 
            this.SUPPLIERPRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SUPPLIERPRICE.HeaderText = "SUPPLIER PRICE";
            this.SUPPLIERPRICE.MinimumWidth = 6;
            this.SUPPLIERPRICE.Name = "SUPPLIERPRICE";
            this.SUPPLIERPRICE.Width = 112;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.Width = 54;
            // 
            // TOTALINVOICE
            // 
            this.TOTALINVOICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TOTALINVOICE.HeaderText = "TOTAL PER ITEM";
            this.TOTALINVOICE.MinimumWidth = 6;
            this.TOTALINVOICE.Name = "TOTALINVOICE";
            this.TOTALINVOICE.ReadOnly = true;
            this.TOTALINVOICE.Width = 88;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.Width = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(401, 127);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(188, 30);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "CREATE PRODUCT";
            this.btnCreate.UseCustomBackColor = true;
            this.btnCreate.UseCustomForeColor = true;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormCreateInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1812, 999);
            this.ControlBox = false;
            this.Controls.Add(this.grdInvoiceList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreateInvoice";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.FormCreateInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtRefNbr;
        private MetroFramework.Controls.MetroTextBox txtCreatedBy;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dtTranDate;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtContactPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtSupplier;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label lblTotalInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.Label lblTotalQTY;
        private System.Windows.Forms.Label label8;
        public MetroFramework.Controls.MetroButton btnSearchSupplier;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
        public MetroFramework.Controls.MetroGrid grdInvoiceList;
        private MetroFramework.Controls.MetroButton btnSearchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIERPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALINVOICE;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
        private MetroFramework.Controls.MetroButton btnCreate;
    }
}