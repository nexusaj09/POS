namespace POS.Forms
{
    partial class PanelProductDiscountSelection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdProductDiscountSelection = new MetroFramework.Controls.MetroGrid();
            this.btnApply = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.productDiscountSelectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isSelectedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductDiscountSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDiscountSelectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductDiscountSelection
            // 
            this.grdProductDiscountSelection.AllowUserToAddRows = false;
            this.grdProductDiscountSelection.AllowUserToDeleteRows = false;
            this.grdProductDiscountSelection.AllowUserToResizeColumns = false;
            this.grdProductDiscountSelection.AllowUserToResizeRows = false;
            this.grdProductDiscountSelection.AutoGenerateColumns = false;
            this.grdProductDiscountSelection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductDiscountSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProductDiscountSelection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdProductDiscountSelection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(114)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductDiscountSelection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProductDiscountSelection.ColumnHeadersHeight = 36;
            this.grdProductDiscountSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdProductDiscountSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelectedDataGridViewCheckBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.unitAmountDataGridViewTextBoxColumn,
            this.discountAmountDataGridViewTextBoxColumn,
            this.lineAmountDataGridViewTextBoxColumn});
            this.grdProductDiscountSelection.DataSource = this.productDiscountSelectionBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProductDiscountSelection.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdProductDiscountSelection.EnableHeadersVisualStyles = false;
            this.grdProductDiscountSelection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdProductDiscountSelection.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdProductDiscountSelection.Location = new System.Drawing.Point(23, 63);
            this.grdProductDiscountSelection.Name = "grdProductDiscountSelection";
            this.grdProductDiscountSelection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProductDiscountSelection.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdProductDiscountSelection.RowHeadersWidth = 51;
            this.grdProductDiscountSelection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProductDiscountSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductDiscountSelection.Size = new System.Drawing.Size(1008, 482);
            this.grdProductDiscountSelection.TabIndex = 1;
            this.grdProductDiscountSelection.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdProductDiscountSelection_CellFormatting);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.SeaGreen;
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(795, 560);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(121, 30);
            this.btnApply.TabIndex = 19;
            this.btnApply.Text = "Apply Discount(s)";
            this.btnApply.UseCustomBackColor = true;
            this.btnApply.UseCustomForeColor = true;
            this.btnApply.UseSelectable = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(922, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // productDiscountSelectionBindingSource
            // 
            this.productDiscountSelectionBindingSource.DataSource = typeof(POS.Models.Product.EligibleProductDiscount);
            // 
            // isSelectedDataGridViewCheckBoxColumn
            // 
            this.isSelectedDataGridViewCheckBoxColumn.DataPropertyName = "IsSelected";
            this.isSelectedDataGridViewCheckBoxColumn.HeaderText = "";
            this.isSelectedDataGridViewCheckBoxColumn.Name = "isSelectedDataGridViewCheckBoxColumn";
            this.isSelectedDataGridViewCheckBoxColumn.Width = 50;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Product Code";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCodeDataGridViewTextBoxColumn.Width = 120;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitAmountDataGridViewTextBoxColumn
            // 
            this.unitAmountDataGridViewTextBoxColumn.DataPropertyName = "UnitAmount";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.unitAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitAmountDataGridViewTextBoxColumn.HeaderText = "Unit Amount";
            this.unitAmountDataGridViewTextBoxColumn.Name = "unitAmountDataGridViewTextBoxColumn";
            this.unitAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitAmountDataGridViewTextBoxColumn.Width = 120;
            // 
            // discountAmountDataGridViewTextBoxColumn
            // 
            this.discountAmountDataGridViewTextBoxColumn.DataPropertyName = "DiscountAmount";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.discountAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.discountAmountDataGridViewTextBoxColumn.HeaderText = "Discount Amount";
            this.discountAmountDataGridViewTextBoxColumn.Name = "discountAmountDataGridViewTextBoxColumn";
            this.discountAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountAmountDataGridViewTextBoxColumn.Width = 140;
            // 
            // lineAmountDataGridViewTextBoxColumn
            // 
            this.lineAmountDataGridViewTextBoxColumn.DataPropertyName = "LineAmount";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.lineAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.lineAmountDataGridViewTextBoxColumn.HeaderText = "Line Amount";
            this.lineAmountDataGridViewTextBoxColumn.Name = "lineAmountDataGridViewTextBoxColumn";
            this.lineAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineAmountDataGridViewTextBoxColumn.Width = 120;
            // 
            // PanelProductDiscountSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1054, 613);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grdProductDiscountSelection);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelProductDiscountSelection";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Select a product to apply discount";
            this.Load += new System.EventHandler(this.PanelProductDiscountSelection_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelProductDiscountSelection_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductDiscountSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDiscountSelectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdProductDiscountSelection;
        private System.Windows.Forms.BindingSource productDiscountSelectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountedUnitAmountDataGridViewTextBoxColumn;
        public MetroFramework.Controls.MetroButton btnApply;
        private MetroFramework.Controls.MetroButton btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelectedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineAmountDataGridViewTextBoxColumn;
    }
}