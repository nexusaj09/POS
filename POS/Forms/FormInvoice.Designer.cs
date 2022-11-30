namespace POS.Forms
{
    partial class FormInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            this.grdInvoiceList = new MetroFramework.Controls.MetroGrid();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFNBR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACTPERSON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEDBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTIONDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALINVOICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIEW = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdInvoiceList.ColumnHeadersHeight = 29;
            this.grdInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.REFNBR,
            this.SUPPLIER,
            this.CONTACTPERSON,
            this.CREATEDBY,
            this.TRANSACTIONDATE,
            this.QTY,
            this.TOTALINVOICE,
            this.VIEW});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInvoiceList.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInvoiceList.EnableHeadersVisualStyles = false;
            this.grdInvoiceList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdInvoiceList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdInvoiceList.Location = new System.Drawing.Point(20, 97);
            this.grdInvoiceList.MultiSelect = false;
            this.grdInvoiceList.Name = "grdInvoiceList";
            this.grdInvoiceList.ReadOnly = true;
            this.grdInvoiceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInvoiceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdInvoiceList.RowHeadersWidth = 51;
            this.grdInvoiceList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdInvoiceList.RowTemplate.Height = 26;
            this.grdInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdInvoiceList.Size = new System.Drawing.Size(1340, 658);
            this.grdInvoiceList.TabIndex = 10;
            this.grdInvoiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdInvoiceList_CellContentClick);
            this.grdInvoiceList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdProductList_CellFormatting);
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
            // REFNBR
            // 
            this.REFNBR.HeaderText = "REFERENCE NBR";
            this.REFNBR.MinimumWidth = 6;
            this.REFNBR.Name = "REFNBR";
            this.REFNBR.ReadOnly = true;
            this.REFNBR.Width = 208;
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SUPPLIER.HeaderText = "SUPPLIER";
            this.SUPPLIER.MinimumWidth = 6;
            this.SUPPLIER.Name = "SUPPLIER";
            this.SUPPLIER.ReadOnly = true;
            // 
            // CONTACTPERSON
            // 
            this.CONTACTPERSON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CONTACTPERSON.HeaderText = "CONTACT PERSON";
            this.CONTACTPERSON.MinimumWidth = 6;
            this.CONTACTPERSON.Name = "CONTACTPERSON";
            this.CONTACTPERSON.ReadOnly = true;
            // 
            // CREATEDBY
            // 
            this.CREATEDBY.HeaderText = "CREATED BY";
            this.CREATEDBY.MinimumWidth = 6;
            this.CREATEDBY.Name = "CREATEDBY";
            this.CREATEDBY.ReadOnly = true;
            this.CREATEDBY.Width = 208;
            // 
            // TRANSACTIONDATE
            // 
            this.TRANSACTIONDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TRANSACTIONDATE.DefaultCellStyle = dataGridViewCellStyle8;
            this.TRANSACTIONDATE.HeaderText = "TRANSACTION DATE";
            this.TRANSACTIONDATE.MinimumWidth = 6;
            this.TRANSACTIONDATE.Name = "TRANSACTIONDATE";
            this.TRANSACTIONDATE.ReadOnly = true;
            this.TRANSACTIONDATE.Width = 151;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QTY.DefaultCellStyle = dataGridViewCellStyle9;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 54;
            // 
            // TOTALINVOICE
            // 
            this.TOTALINVOICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TOTALINVOICE.DefaultCellStyle = dataGridViewCellStyle10;
            this.TOTALINVOICE.HeaderText = "TOTAL INVOICE";
            this.TOTALINVOICE.MinimumWidth = 6;
            this.TOTALINVOICE.Name = "TOTALINVOICE";
            this.TOTALINVOICE.ReadOnly = true;
            this.TOTALINVOICE.Width = 119;
            // 
            // VIEW
            // 
            this.VIEW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VIEW.HeaderText = "";
            this.VIEW.Image = ((System.Drawing.Image)(resources.GetObject("VIEW.Image")));
            this.VIEW.MinimumWidth = 6;
            this.VIEW.Name = "VIEW";
            this.VIEW.ReadOnly = true;
            this.VIEW.Width = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 37);
            this.panel1.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(956, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "[F1] Search Here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(272, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "[F1] Search Here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1233, 7);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "STOCK IN";
            this.btnCreate.UseCustomBackColor = true;
            this.btnCreate.UseCustomForeColor = true;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1380, 775);
            this.Controls.Add(this.grdInvoiceList);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FormInvoice";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Stock Invoice";
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInvoice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoiceList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroGrid grdInvoiceList;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton btnCreate;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFNBR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACTPERSON;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEDBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTIONDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALINVOICE;
        private System.Windows.Forms.DataGridViewImageColumn VIEW;
    }
}