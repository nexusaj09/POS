namespace POS.Forms
{
    partial class FormCreateAdjustments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAdjustments));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdProductList = new MetroFramework.Controls.MetroGrid();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECT = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdjustmentNbr = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.cmbActions = new MetroFramework.Controls.MetroComboBox();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReasons = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imgBarcode = new System.Windows.Forms.PictureBox();
            this.txtQtyAdjust = new MetroFramework.Controls.MetroTextBox();
            this.txtQtyOnHand = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtProductCode = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdProductList);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTS";
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
            this.grdProductList.ColumnHeadersHeight = 29;
            this.grdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.PRODUCTCODE,
            this.BARCODE,
            this.DESCR,
            this.QTY,
            this.SELECT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProductList.EnableHeadersVisualStyles = false;
            this.grdProductList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProductList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductList.Location = new System.Drawing.Point(3, 50);
            this.grdProductList.Margin = new System.Windows.Forms.Padding(4);
            this.grdProductList.MultiSelect = false;
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.ReadOnly = true;
            this.grdProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdProductList.RowHeadersWidth = 51;
            this.grdProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductList.RowTemplate.Height = 24;
            this.grdProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductList.Size = new System.Drawing.Size(682, 494);
            this.grdProductList.TabIndex = 8;
            this.grdProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductList_CellDoubleClick);
            this.grdProductList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdProductList_KeyDown);
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Count.HeaderText = "#";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 39;
            // 
            // PRODUCTCODE
            // 
            this.PRODUCTCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRODUCTCODE.HeaderText = "PRODUCT CODE";
            this.PRODUCTCODE.Name = "PRODUCTCODE";
            this.PRODUCTCODE.ReadOnly = true;
            this.PRODUCTCODE.Width = 127;
            // 
            // BARCODE
            // 
            this.BARCODE.HeaderText = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.ReadOnly = true;
            this.BARCODE.Visible = false;
            // 
            // DESCR
            // 
            this.DESCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCR.HeaderText = "DESCRIPTION";
            this.DESCR.MinimumWidth = 6;
            this.DESCR.Name = "DESCR";
            this.DESCR.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 54;
            // 
            // SELECT
            // 
            this.SELECT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SELECT.HeaderText = "";
            this.SELECT.Image = ((System.Drawing.Image)(resources.GetObject("SELECT.Image")));
            this.SELECT.Name = "SELECT";
            this.SELECT.ReadOnly = true;
            this.SELECT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECT.Width = 5;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(658, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(3, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "[F1] Search Here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(682, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "[F1] Search Here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdjustmentNbr);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.cmbActions);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtReasons);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.imgBarcode);
            this.groupBox2.Controls.Add(this.txtQtyAdjust);
            this.groupBox2.Controls.Add(this.txtQtyOnHand);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtProductCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(716, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 547);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCT ADJUSTED DETAILS";
            // 
            // txtAdjustmentNbr
            // 
            this.txtAdjustmentNbr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtAdjustmentNbr.CustomButton.Image = null;
            this.txtAdjustmentNbr.CustomButton.Location = new System.Drawing.Point(431, 2);
            this.txtAdjustmentNbr.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdjustmentNbr.CustomButton.Name = "";
            this.txtAdjustmentNbr.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAdjustmentNbr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdjustmentNbr.CustomButton.TabIndex = 1;
            this.txtAdjustmentNbr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdjustmentNbr.CustomButton.UseSelectable = true;
            this.txtAdjustmentNbr.CustomButton.Visible = false;
            this.txtAdjustmentNbr.Enabled = false;
            this.txtAdjustmentNbr.Lines = new string[0];
            this.txtAdjustmentNbr.Location = new System.Drawing.Point(151, 44);
            this.txtAdjustmentNbr.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdjustmentNbr.MaxLength = 32767;
            this.txtAdjustmentNbr.Name = "txtAdjustmentNbr";
            this.txtAdjustmentNbr.PasswordChar = '\0';
            this.txtAdjustmentNbr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdjustmentNbr.SelectedText = "";
            this.txtAdjustmentNbr.SelectionLength = 0;
            this.txtAdjustmentNbr.SelectionStart = 0;
            this.txtAdjustmentNbr.ShortcutsEnabled = true;
            this.txtAdjustmentNbr.Size = new System.Drawing.Size(457, 28);
            this.txtAdjustmentNbr.TabIndex = 36;
            this.txtAdjustmentNbr.UseSelectable = true;
            this.txtAdjustmentNbr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdjustmentNbr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "ADJUSTMENT NBR:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(463, 440);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 37);
            this.btnCancel.TabIndex = 28;
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
            this.btnSave.Location = new System.Drawing.Point(310, 440);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 37);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbActions
            // 
            this.cmbActions.FormattingEnabled = true;
            this.cmbActions.ItemHeight = 23;
            this.cmbActions.Items.AddRange(new object[] {
            "Add To Stocks",
            "Remove From Stock"});
            this.cmbActions.Location = new System.Drawing.Point(151, 332);
            this.cmbActions.Name = "cmbActions";
            this.cmbActions.Size = new System.Drawing.Size(457, 29);
            this.cmbActions.TabIndex = 24;
            this.cmbActions.UseSelectable = true;
            this.cmbActions.SelectedIndexChanged += new System.EventHandler(this.cmbActions_SelectedIndexChanged);
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(431, 2);
            this.txtUser.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Enabled = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(151, 404);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(457, 28);
            this.txtUser.TabIndex = 26;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "ADJUSTED BY:";
            // 
            // txtReasons
            // 
            // 
            // 
            // 
            this.txtReasons.CustomButton.Image = null;
            this.txtReasons.CustomButton.Location = new System.Drawing.Point(431, 2);
            this.txtReasons.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtReasons.CustomButton.Name = "";
            this.txtReasons.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtReasons.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReasons.CustomButton.TabIndex = 1;
            this.txtReasons.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReasons.CustomButton.UseSelectable = true;
            this.txtReasons.CustomButton.Visible = false;
            this.txtReasons.Lines = new string[0];
            this.txtReasons.Location = new System.Drawing.Point(151, 368);
            this.txtReasons.Margin = new System.Windows.Forms.Padding(4);
            this.txtReasons.MaxLength = 32767;
            this.txtReasons.Name = "txtReasons";
            this.txtReasons.PasswordChar = '\0';
            this.txtReasons.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReasons.SelectedText = "";
            this.txtReasons.SelectionLength = 0;
            this.txtReasons.SelectionStart = 0;
            this.txtReasons.ShortcutsEnabled = true;
            this.txtReasons.Size = new System.Drawing.Size(457, 28);
            this.txtReasons.TabIndex = 25;
            this.txtReasons.UseSelectable = true;
            this.txtReasons.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReasons.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "REASON(S):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "ACTION:";
            // 
            // imgBarcode
            // 
            this.imgBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBarcode.Location = new System.Drawing.Point(151, 116);
            this.imgBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.imgBarcode.Name = "imgBarcode";
            this.imgBarcode.Size = new System.Drawing.Size(457, 99);
            this.imgBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBarcode.TabIndex = 29;
            this.imgBarcode.TabStop = false;
            // 
            // txtQtyAdjust
            // 
            // 
            // 
            // 
            this.txtQtyAdjust.CustomButton.Image = null;
            this.txtQtyAdjust.CustomButton.Location = new System.Drawing.Point(431, 2);
            this.txtQtyAdjust.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtyAdjust.CustomButton.Name = "";
            this.txtQtyAdjust.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtQtyAdjust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtyAdjust.CustomButton.TabIndex = 1;
            this.txtQtyAdjust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtyAdjust.CustomButton.UseSelectable = true;
            this.txtQtyAdjust.CustomButton.Visible = false;
            this.txtQtyAdjust.Lines = new string[0];
            this.txtQtyAdjust.Location = new System.Drawing.Point(151, 296);
            this.txtQtyAdjust.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtyAdjust.MaxLength = 32767;
            this.txtQtyAdjust.Name = "txtQtyAdjust";
            this.txtQtyAdjust.PasswordChar = '\0';
            this.txtQtyAdjust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtyAdjust.SelectedText = "";
            this.txtQtyAdjust.SelectionLength = 0;
            this.txtQtyAdjust.SelectionStart = 0;
            this.txtQtyAdjust.ShortcutsEnabled = true;
            this.txtQtyAdjust.Size = new System.Drawing.Size(457, 28);
            this.txtQtyAdjust.TabIndex = 23;
            this.txtQtyAdjust.UseSelectable = true;
            this.txtQtyAdjust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtyAdjust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQtyOnHand
            // 
            // 
            // 
            // 
            this.txtQtyOnHand.CustomButton.Image = null;
            this.txtQtyOnHand.CustomButton.Location = new System.Drawing.Point(431, 2);
            this.txtQtyOnHand.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtyOnHand.CustomButton.Name = "";
            this.txtQtyOnHand.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtQtyOnHand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtyOnHand.CustomButton.TabIndex = 1;
            this.txtQtyOnHand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtyOnHand.CustomButton.UseSelectable = true;
            this.txtQtyOnHand.CustomButton.Visible = false;
            this.txtQtyOnHand.Enabled = false;
            this.txtQtyOnHand.Lines = new string[0];
            this.txtQtyOnHand.Location = new System.Drawing.Point(151, 260);
            this.txtQtyOnHand.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtyOnHand.MaxLength = 32767;
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.PasswordChar = '\0';
            this.txtQtyOnHand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtyOnHand.SelectedText = "";
            this.txtQtyOnHand.SelectionLength = 0;
            this.txtQtyOnHand.SelectionStart = 0;
            this.txtQtyOnHand.ShortcutsEnabled = true;
            this.txtQtyOnHand.Size = new System.Drawing.Size(457, 28);
            this.txtQtyOnHand.TabIndex = 22;
            this.txtQtyOnHand.UseSelectable = true;
            this.txtQtyOnHand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtyOnHand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(431, 2);
            this.txtDescription.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Enabled = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(151, 225);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(457, 28);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProductCode
            // 
            this.txtProductCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtProductCode.CustomButton.Image = null;
            this.txtProductCode.CustomButton.Location = new System.Drawing.Point(431, 2);
            this.txtProductCode.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.CustomButton.Name = "";
            this.txtProductCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtProductCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductCode.CustomButton.TabIndex = 1;
            this.txtProductCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductCode.CustomButton.UseSelectable = true;
            this.txtProductCode.CustomButton.Visible = false;
            this.txtProductCode.Enabled = false;
            this.txtProductCode.Lines = new string[0];
            this.txtProductCode.Location = new System.Drawing.Point(151, 80);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.MaxLength = 32767;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.SelectionLength = 0;
            this.txtProductCode.SelectionStart = 0;
            this.txtProductCode.ShortcutsEnabled = true;
            this.txtProductCode.Size = new System.Drawing.Size(457, 28);
            this.txtProductCode.TabIndex = 18;
            this.txtProductCode.UseSelectable = true;
            this.txtProductCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "QTY ADJUSTED:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "QTY ON HAND:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "DESCRIPTION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "BARCODE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "PRODUCT CODE:";
            // 
            // FormCreateAdjustments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1368, 627);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "FormCreateAdjustments";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Adjust Stock";
            this.Load += new System.EventHandler(this.FormCreateAdjustments_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCreateAdjustments_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        public MetroFramework.Controls.MetroGrid grdProductList;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtReasons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgBarcode;
        private MetroFramework.Controls.MetroTextBox txtQtyAdjust;
        private MetroFramework.Controls.MetroTextBox txtQtyOnHand;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        public MetroFramework.Controls.MetroTextBox txtProductCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbActions;
        private MetroFramework.Controls.MetroButton btnCancel;
        public MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewImageColumn SELECT;
        public MetroFramework.Controls.MetroTextBox txtAdjustmentNbr;
        private System.Windows.Forms.Label label9;
    }
}