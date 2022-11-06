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
            this.grdProductList = new MetroFramework.Controls.MetroGrid();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIERPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALINVOICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 142);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(135, 103);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(160, 24);
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
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(1161, 6);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(155, 64);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // lblTotalInvoice
            // 
            this.lblTotalInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalInvoice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoice.ForeColor = System.Drawing.Color.White;
            this.lblTotalInvoice.Location = new System.Drawing.Point(0, 27);
            this.lblTotalInvoice.Name = "lblTotalInvoice";
            this.lblTotalInvoice.Size = new System.Drawing.Size(155, 37);
            this.lblTotalInvoice.TabIndex = 5;
            this.lblTotalInvoice.Text = "0.00";
            this.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 37);
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
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 27);
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
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(1161, 73);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(155, 64);
            this.metroPanel4.TabIndex = 7;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // lblTotalQTY
            // 
            this.lblTotalQTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalQTY.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQTY.ForeColor = System.Drawing.Color.White;
            this.lblTotalQTY.Location = new System.Drawing.Point(0, 27);
            this.lblTotalQTY.Name = "lblTotalQTY";
            this.lblTotalQTY.Size = new System.Drawing.Size(155, 37);
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
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "TOTAL QTY";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSearchSupplier.Location = new System.Drawing.Point(925, 10);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(126, 23);
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
            this.txtSupplier.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtSupplier.CustomButton.Name = "";
            this.txtSupplier.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplier.CustomButton.TabIndex = 1;
            this.txtSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplier.CustomButton.UseSelectable = true;
            this.txtSupplier.CustomButton.Visible = false;
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Lines = new string[0];
            this.txtSupplier.Location = new System.Drawing.Point(619, 10);
            this.txtSupplier.MaxLength = 32767;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.SelectionLength = 0;
            this.txtSupplier.SelectionStart = 0;
            this.txtSupplier.ShortcutsEnabled = true;
            this.txtSupplier.Size = new System.Drawing.Size(300, 23);
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
            this.txtContactPerson.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtContactPerson.CustomButton.Name = "";
            this.txtContactPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContactPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactPerson.CustomButton.TabIndex = 1;
            this.txtContactPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactPerson.CustomButton.UseSelectable = true;
            this.txtContactPerson.CustomButton.Visible = false;
            this.txtContactPerson.Lines = new string[0];
            this.txtContactPerson.Location = new System.Drawing.Point(619, 39);
            this.txtContactPerson.MaxLength = 32767;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.PasswordChar = '\0';
            this.txtContactPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactPerson.SelectedText = "";
            this.txtContactPerson.SelectionLength = 0;
            this.txtContactPerson.SelectionStart = 0;
            this.txtContactPerson.ShortcutsEnabled = true;
            this.txtContactPerson.Size = new System.Drawing.Size(300, 23);
            this.txtContactPerson.TabIndex = 9;
            this.txtContactPerson.UseSelectable = true;
            this.txtContactPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "CONTACT PERSON:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "SUPPLIER:";
            // 
            // dtTranDate
            // 
            this.dtTranDate.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTranDate.Location = new System.Drawing.Point(135, 68);
            this.dtTranDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTranDate.Name = "dtTranDate";
            this.dtTranDate.Size = new System.Drawing.Size(307, 29);
            this.dtTranDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
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
            this.txtCreatedBy.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txtCreatedBy.CustomButton.Name = "";
            this.txtCreatedBy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCreatedBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCreatedBy.CustomButton.TabIndex = 1;
            this.txtCreatedBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCreatedBy.CustomButton.UseSelectable = true;
            this.txtCreatedBy.CustomButton.Visible = false;
            this.txtCreatedBy.Enabled = false;
            this.txtCreatedBy.Lines = new string[0];
            this.txtCreatedBy.Location = new System.Drawing.Point(135, 39);
            this.txtCreatedBy.MaxLength = 32767;
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.PasswordChar = '\0';
            this.txtCreatedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCreatedBy.SelectedText = "";
            this.txtCreatedBy.SelectionLength = 0;
            this.txtCreatedBy.SelectionStart = 0;
            this.txtCreatedBy.ShortcutsEnabled = true;
            this.txtCreatedBy.Size = new System.Drawing.Size(307, 23);
            this.txtCreatedBy.TabIndex = 3;
            this.txtCreatedBy.UseSelectable = true;
            this.txtCreatedBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCreatedBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
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
            this.txtRefNbr.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txtRefNbr.CustomButton.Name = "";
            this.txtRefNbr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRefNbr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRefNbr.CustomButton.TabIndex = 1;
            this.txtRefNbr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRefNbr.CustomButton.UseSelectable = true;
            this.txtRefNbr.CustomButton.Visible = false;
            this.txtRefNbr.Enabled = false;
            this.txtRefNbr.Lines = new string[0];
            this.txtRefNbr.Location = new System.Drawing.Point(135, 10);
            this.txtRefNbr.MaxLength = 32767;
            this.txtRefNbr.Name = "txtRefNbr";
            this.txtRefNbr.PasswordChar = '\0';
            this.txtRefNbr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRefNbr.SelectedText = "";
            this.txtRefNbr.SelectionLength = 0;
            this.txtRefNbr.SelectionStart = 0;
            this.txtRefNbr.ShortcutsEnabled = true;
            this.txtRefNbr.Size = new System.Drawing.Size(307, 23);
            this.txtRefNbr.TabIndex = 1;
            this.txtRefNbr.UseSelectable = true;
            this.txtRefNbr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRefNbr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
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
            this.panel3.Location = new System.Drawing.Point(20, 752);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1319, 40);
            this.panel3.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1207, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
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
            this.btnSave.Location = new System.Drawing.Point(1091, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            // 
            // grdProductList
            // 
            this.grdProductList.AllowUserToAddRows = false;
            this.grdProductList.AllowUserToDeleteRows = false;
            this.grdProductList.AllowUserToResizeRows = false;
            this.grdProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
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
            this.grdProductList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductList.EnableHeadersVisualStyles = false;
            this.grdProductList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductList.Location = new System.Drawing.Point(20, 202);
            this.grdProductList.MultiSelect = false;
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductList.RowTemplate.Height = 26;
            this.grdProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductList.Size = new System.Drawing.Size(1319, 550);
            this.grdProductList.TabIndex = 12;
            this.grdProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellContentClick);
            this.grdProductList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellEndEdit);
            this.grdProductList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdProductList_KeyDown);
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Count.HeaderText = "#";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 39;
            // 
            // PRODUCTCODE
            // 
            this.PRODUCTCODE.HeaderText = "PRODUCT CODE";
            this.PRODUCTCODE.Name = "PRODUCTCODE";
            this.PRODUCTCODE.ReadOnly = true;
            this.PRODUCTCODE.Width = 250;
            // 
            // DESCR
            // 
            this.DESCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCR.HeaderText = "DESCRIPTION";
            this.DESCR.Name = "DESCR";
            this.DESCR.ReadOnly = true;
            // 
            // SUPPLIERPRICE
            // 
            this.SUPPLIERPRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SUPPLIERPRICE.HeaderText = "SUPPLIER PRICE";
            this.SUPPLIERPRICE.Name = "SUPPLIERPRICE";
            this.SUPPLIERPRICE.Width = 112;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.Width = 54;
            // 
            // TOTALINVOICE
            // 
            this.TOTALINVOICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TOTALINVOICE.HeaderText = "TOTAL PER ITEM";
            this.TOTALINVOICE.Name = "TOTALINVOICE";
            this.TOTALINVOICE.ReadOnly = true;
            this.TOTALINVOICE.Width = 88;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.Name = "DELETE";
            this.DELETE.Width = 5;
            // 
            // FormCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1359, 812);
            this.ControlBox = false;
            this.Controls.Add(this.grdProductList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormCreateInvoice";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.FormCreateInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
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
        public MetroFramework.Controls.MetroGrid grdProductList;
        private MetroFramework.Controls.MetroButton btnSearchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIERPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALINVOICE;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}