namespace POS.Panels
{
    partial class PanelViewCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelViewCart));
            this.grdHoldTransactions = new MetroFramework.Controls.MetroGrid();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSACTIONNBR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECT = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoldTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHoldTransactions
            // 
            this.grdHoldTransactions.AllowUserToAddRows = false;
            this.grdHoldTransactions.AllowUserToDeleteRows = false;
            this.grdHoldTransactions.AllowUserToResizeRows = false;
            this.grdHoldTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdHoldTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdHoldTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdHoldTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHoldTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdHoldTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHoldTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.TRANSACTIONNBR,
            this.TOTAL,
            this.SELECT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdHoldTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdHoldTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHoldTransactions.EnableHeadersVisualStyles = false;
            this.grdHoldTransactions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdHoldTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdHoldTransactions.Location = new System.Drawing.Point(20, 60);
            this.grdHoldTransactions.MultiSelect = false;
            this.grdHoldTransactions.Name = "grdHoldTransactions";
            this.grdHoldTransactions.ReadOnly = true;
            this.grdHoldTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHoldTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdHoldTransactions.RowHeadersWidth = 51;
            this.grdHoldTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdHoldTransactions.RowTemplate.Height = 26;
            this.grdHoldTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHoldTransactions.Size = new System.Drawing.Size(497, 482);
            this.grdHoldTransactions.TabIndex = 12;
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
            // TRANSACTIONNBR
            // 
            this.TRANSACTIONNBR.HeaderText = "TRANSACTION NBR";
            this.TRANSACTIONNBR.MinimumWidth = 6;
            this.TRANSACTIONNBR.Name = "TRANSACTIONNBR";
            this.TRANSACTIONNBR.ReadOnly = true;
            this.TRANSACTIONNBR.Width = 250;
            // 
            // TOTAL
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.TOTAL.DefaultCellStyle = dataGridViewCellStyle2;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 125;
            // 
            // SELECT
            // 
            this.SELECT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SELECT.HeaderText = "";
            this.SELECT.Image = ((System.Drawing.Image)(resources.GetObject("SELECT.Image")));
            this.SELECT.MinimumWidth = 6;
            this.SELECT.Name = "SELECT";
            this.SELECT.ReadOnly = true;
            this.SELECT.Width = 6;
            // 
            // PanelViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 562);
            this.Controls.Add(this.grdHoldTransactions);
            this.Name = "PanelViewCart";
            this.Text = "HOLD TRANSACTIONS";
            this.Load += new System.EventHandler(this.PanelViewCart_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelViewCart_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdHoldTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroGrid grdHoldTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSACTIONNBR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewImageColumn SELECT;
    }
}