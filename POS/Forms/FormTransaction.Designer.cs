namespace POS.Forms
{
    partial class FormTransaction
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaction));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPCName = new System.Windows.Forms.Label();
            this.lblTIME = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVatExempt = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdProductList = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnXReading = new System.Windows.Forms.Button();
            this.btnAdjustQty = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnHoldTransaction = new System.Windows.Forms.Button();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTransactionNbr = new System.Windows.Forms.Label();
            this.btnGcash = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblNbrOfItems = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ROW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.panel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGcash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.pictureBox2);
            this.metroPanel1.Controls.Add(this.lblRole);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.lblUser);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1920, 68);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 68);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(1688, 35);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(54, 21);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "USER:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1628, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "USER:";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1688, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "USER:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1628, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "ROLE:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(483, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(4, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "[F1] SCAN BARCODE HERE";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(511, 29);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "[F1] SCAN BARCODE HERE";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.White;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.lblPCName);
            this.metroPanel2.Controls.Add(this.lblTIME);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 989);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1920, 43);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblPCName
            // 
            this.lblPCName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPCName.AutoSize = true;
            this.lblPCName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCName.ForeColor = System.Drawing.Color.Black;
            this.lblPCName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPCName.Location = new System.Drawing.Point(46, 10);
            this.lblPCName.Name = "lblPCName";
            this.lblPCName.Size = new System.Drawing.Size(54, 21);
            this.lblPCName.TabIndex = 7;
            this.lblPCName.Text = "USER:";
            this.lblPCName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTIME
            // 
            this.lblTIME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTIME.AutoSize = true;
            this.lblTIME.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIME.ForeColor = System.Drawing.Color.Black;
            this.lblTIME.Location = new System.Drawing.Point(1521, 8);
            this.lblTIME.Name = "lblTIME";
            this.lblTIME.Size = new System.Drawing.Size(384, 25);
            this.lblTIME.TabIndex = 0;
            this.lblTIME.Text = "Saturday, 26 November 2022 12:00:00 am";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lblVatExempt);
            this.panel7.Controls.Add(this.lblVat);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.lblTotal);
            this.panel7.Controls.Add(this.lblDiscount);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(1148, 644);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(760, 180);
            this.panel7.TabIndex = 4;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(720, 3);
            this.label4.TabIndex = 13;
            // 
            // lblVatExempt
            // 
            this.lblVatExempt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatExempt.ForeColor = System.Drawing.Color.Black;
            this.lblVatExempt.Location = new System.Drawing.Point(610, 74);
            this.lblVatExempt.Name = "lblVatExempt";
            this.lblVatExempt.Size = new System.Drawing.Size(111, 25);
            this.lblVatExempt.TabIndex = 11;
            this.lblVatExempt.Text = "P10,000.00";
            this.lblVatExempt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVat
            // 
            this.lblVat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.ForeColor = System.Drawing.Color.Black;
            this.lblVat.Location = new System.Drawing.Point(610, 45);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(111, 25);
            this.lblVat.TabIndex = 10;
            this.lblVat.Text = "P10,000.00";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(451, 128);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(270, 40);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "P10,000.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.Location = new System.Drawing.Point(610, 14);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(111, 25);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "P10,000.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "VAT-EXEMPT SALE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "VATABLE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "DISCOUNT:";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDue.Location = new System.Drawing.Point(537, 11);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(184, 45);
            this.lblTotalDue.TabIndex = 12;
            this.lblTotalDue.Text = "P10,000.00";
            this.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 45);
            this.label8.TabIndex = 7;
            this.label8.Text = "TOTAL DUE:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdProductList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 527);
            this.panel1.TabIndex = 19;
            // 
            // grdProductList
            // 
            this.grdProductList.AllowUserToAddRows = false;
            this.grdProductList.AllowUserToDeleteRows = false;
            this.grdProductList.AllowUserToResizeRows = false;
            this.grdProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProductList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.grdProductList.ColumnHeadersHeight = 30;
            this.grdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ROW,
            this.PRODUCTCODE,
            this.Description,
            this.UNIT,
            this.PRICE,
            this.QTY,
            this.LESS,
            this.TOTAL});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductList.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdProductList.EnableHeadersVisualStyles = false;
            this.grdProductList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductList.Location = new System.Drawing.Point(12, 6);
            this.grdProductList.MultiSelect = false;
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.ReadOnly = true;
            this.grdProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdProductList.RowHeadersWidth = 51;
            this.grdProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductList.RowTemplate.Height = 26;
            this.grdProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductList.Size = new System.Drawing.Size(1896, 514);
            this.grdProductList.TabIndex = 19;
            this.grdProductList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdProductList_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(12, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 42);
            this.panel2.TabIndex = 20;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.lblTotalDue);
            this.metroPanel3.Controls.Add(this.label8);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(1148, 830);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(760, 67);
            this.metroPanel3.TabIndex = 21;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.btnSettlePayment);
            this.metroPanel4.Controls.Add(this.btnClose);
            this.metroPanel4.Controls.Add(this.btnShift);
            this.metroPanel4.Controls.Add(this.button9);
            this.metroPanel4.Controls.Add(this.btnXReading);
            this.metroPanel4.Controls.Add(this.btnAdjustQty);
            this.metroPanel4.Controls.Add(this.btnVoid);
            this.metroPanel4.Controls.Add(this.btnDiscount);
            this.metroPanel4.Controls.Add(this.btnViewCart);
            this.metroPanel4.Controls.Add(this.btnHoldTransaction);
            this.metroPanel4.Controls.Add(this.btnProductSearch);
            this.metroPanel4.Controls.Add(this.btnNewTransaction);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(12, 904);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1894, 79);
            this.metroPanel4.TabIndex = 22;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnSettlePayment.Image")));
            this.btnSettlePayment.Location = new System.Drawing.Point(1628, 0);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(266, 79);
            this.btnSettlePayment.TabIndex = 13;
            this.btnSettlePayment.Text = "SETTLE PAYMENTS";
            this.btnSettlePayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettlePayment.UseVisualStyleBackColor = true;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(1480, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 79);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShift
            // 
            this.btnShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShift.Image = ((System.Drawing.Image)(resources.GetObject("btnShift.Image")));
            this.btnShift.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShift.Location = new System.Drawing.Point(1332, 0);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(142, 79);
            this.btnShift.TabIndex = 11;
            this.btnShift.Text = "START SHIFT";
            this.btnShift.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(1184, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 79);
            this.button9.TabIndex = 10;
            this.button9.Text = "NEW TRANSACTION";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btnXReading
            // 
            this.btnXReading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXReading.Image = ((System.Drawing.Image)(resources.GetObject("btnXReading.Image")));
            this.btnXReading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXReading.Location = new System.Drawing.Point(1036, 0);
            this.btnXReading.Name = "btnXReading";
            this.btnXReading.Size = new System.Drawing.Size(142, 79);
            this.btnXReading.TabIndex = 9;
            this.btnXReading.Text = "X-READING";
            this.btnXReading.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXReading.UseVisualStyleBackColor = true;
            // 
            // btnAdjustQty
            // 
            this.btnAdjustQty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdjustQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjustQty.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjustQty.Image")));
            this.btnAdjustQty.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdjustQty.Location = new System.Drawing.Point(888, 0);
            this.btnAdjustQty.Name = "btnAdjustQty";
            this.btnAdjustQty.Size = new System.Drawing.Size(142, 79);
            this.btnAdjustQty.TabIndex = 8;
            this.btnAdjustQty.Text = "ADJUST QTY";
            this.btnAdjustQty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdjustQty.UseVisualStyleBackColor = true;
            this.btnAdjustQty.Click += new System.EventHandler(this.btnAdjustQty_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Image = ((System.Drawing.Image)(resources.GetObject("btnVoid.Image")));
            this.btnVoid.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoid.Location = new System.Drawing.Point(740, 0);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(142, 79);
            this.btnVoid.TabIndex = 7;
            this.btnVoid.Text = "VOID";
            this.btnVoid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoid.UseVisualStyleBackColor = true;
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiscount.Location = new System.Drawing.Point(592, 0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(142, 79);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "ADD DISCOUNT";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnViewCart
            // 
            this.btnViewCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCart.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCart.Image")));
            this.btnViewCart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewCart.Location = new System.Drawing.Point(444, 0);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(142, 79);
            this.btnViewCart.TabIndex = 5;
            this.btnViewCart.Text = "VIEW CART";
            this.btnViewCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnHoldTransaction
            // 
            this.btnHoldTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHoldTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoldTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnHoldTransaction.Image")));
            this.btnHoldTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHoldTransaction.Location = new System.Drawing.Point(296, 0);
            this.btnHoldTransaction.Name = "btnHoldTransaction";
            this.btnHoldTransaction.Size = new System.Drawing.Size(142, 79);
            this.btnHoldTransaction.TabIndex = 4;
            this.btnHoldTransaction.Text = "HOLD";
            this.btnHoldTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHoldTransaction.UseVisualStyleBackColor = true;
            this.btnHoldTransaction.Click += new System.EventHandler(this.btnHoldTransaction_Click);
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSearch.Image")));
            this.btnProductSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductSearch.Location = new System.Drawing.Point(148, 0);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(142, 79);
            this.btnProductSearch.TabIndex = 3;
            this.btnProductSearch.Text = "SEARCH PRODUCT";
            this.btnProductSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewTransaction.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransaction.Image")));
            this.btnNewTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(142, 79);
            this.btnNewTransaction.TabIndex = 2;
            this.btnNewTransaction.Text = "NEW TRANSACTION";
            this.btnNewTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(1165, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "TRANSACTION NBR:";
            this.label9.Visible = false;
            // 
            // lblTransactionNbr
            // 
            this.lblTransactionNbr.AutoSize = true;
            this.lblTransactionNbr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionNbr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            this.lblTransactionNbr.Location = new System.Drawing.Point(1365, 609);
            this.lblTransactionNbr.Name = "lblTransactionNbr";
            this.lblTransactionNbr.Size = new System.Drawing.Size(194, 25);
            this.lblTransactionNbr.TabIndex = 25;
            this.lblTransactionNbr.Text = "TRANSACTION NBR:";
            this.lblTransactionNbr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTransactionNbr.Visible = false;
            // 
            // btnGcash
            // 
            this.btnGcash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGcash.Image = ((System.Drawing.Image)(resources.GetObject("btnGcash.Image")));
            this.btnGcash.Location = new System.Drawing.Point(12, 650);
            this.btnGcash.Name = "btnGcash";
            this.btnGcash.Size = new System.Drawing.Size(523, 77);
            this.btnGcash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGcash.TabIndex = 26;
            this.btnGcash.TabStop = false;
            this.btnGcash.Click += new System.EventHandler(this.btnGcash_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 733);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(523, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 816);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(523, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(541, 602);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(601, 291);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 29;
            this.pictureBox6.TabStop = false;
            // 
            // lblNbrOfItems
            // 
            this.lblNbrOfItems.AutoSize = true;
            this.lblNbrOfItems.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrOfItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            this.lblNbrOfItems.Location = new System.Drawing.Point(1821, 609);
            this.lblNbrOfItems.Name = "lblNbrOfItems";
            this.lblNbrOfItems.Size = new System.Drawing.Size(23, 25);
            this.lblNbrOfItems.TabIndex = 31;
            this.lblNbrOfItems.Text = "0";
            this.lblNbrOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(1627, 609);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "NUMBER OF ITEMS:";
            // 
            // ROW
            // 
            this.ROW.HeaderText = "#";
            this.ROW.Name = "ROW";
            this.ROW.ReadOnly = true;
            // 
            // PRODUCTCODE
            // 
            this.PRODUCTCODE.HeaderText = "PRODUCT CODE";
            this.PRODUCTCODE.MinimumWidth = 6;
            this.PRODUCTCODE.Name = "PRODUCTCODE";
            this.PRODUCTCODE.ReadOnly = true;
            this.PRODUCTCODE.Width = 125;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // UNIT
            // 
            this.UNIT.HeaderText = "UNIT";
            this.UNIT.MinimumWidth = 6;
            this.UNIT.Name = "UNIT";
            this.UNIT.ReadOnly = true;
            this.UNIT.Width = 120;
            // 
            // PRICE
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PRICE.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 120;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 54;
            // 
            // LESS
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.LESS.DefaultCellStyle = dataGridViewCellStyle3;
            this.LESS.HeaderText = "LESS";
            this.LESS.Name = "LESS";
            this.LESS.ReadOnly = true;
            this.LESS.Width = 120;
            // 
            // TOTAL
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle4;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 120;
            // 
            // FormTransaction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1032);
            this.ControlBox = false;
            this.Controls.Add(this.lblNbrOfItems);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnGcash);
            this.Controls.Add(this.lblTransactionNbr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTransaction";
            this.Load += new System.EventHandler(this.FormTransaction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTransaction_KeyDown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGcash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTIME;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblVatExempt;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        public MetroFramework.Controls.MetroGrid grdProductList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPCName;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.Button btnXReading;
        private System.Windows.Forms.Button btnAdjustQty;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnHoldTransaction;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTransactionNbr;
        private System.Windows.Forms.PictureBox btnGcash;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblNbrOfItems;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSettlePayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROW;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}