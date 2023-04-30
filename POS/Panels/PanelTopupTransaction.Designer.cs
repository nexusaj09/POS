namespace POS.Panels
{
    partial class PanelTopupTransaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRefNbr = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopup = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblGCashBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRefNbr);
            this.panel1.Controls.Add(this.txtAmt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 125);
            this.panel1.TabIndex = 4;
            // 
            // txtRefNbr
            // 
            this.txtRefNbr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNbr.Location = new System.Drawing.Point(253, 70);
            this.txtRefNbr.Name = "txtRefNbr";
            this.txtRefNbr.Size = new System.Drawing.Size(267, 29);
            this.txtRefNbr.TabIndex = 5;
            // 
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmt.Location = new System.Drawing.Point(253, 21);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(267, 29);
            this.txtAmt.TabIndex = 3;
            this.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmt_KeyPress);
            this.txtAmt.Leave += new System.EventHandler(this.txtAmt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "REFERENCE NBR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMOUNT:";
            // 
            // btnTopup
            // 
            this.btnTopup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.btnTopup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopup.ForeColor = System.Drawing.Color.White;
            this.btnTopup.Location = new System.Drawing.Point(20, 339);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(540, 61);
            this.btnTopup.TabIndex = 7;
            this.btnTopup.Text = "TOP-UP";
            this.btnTopup.UseVisualStyleBackColor = false;
            this.btnTopup.Click += new System.EventHandler(this.btnTopup_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.metroPanel1.Controls.Add(this.lblGCashBalance);
            this.metroPanel1.Controls.Add(this.label8);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(534, 134);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblGCashBalance
            // 
            this.lblGCashBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGCashBalance.AutoSize = true;
            this.lblGCashBalance.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGCashBalance.ForeColor = System.Drawing.Color.White;
            this.lblGCashBalance.Location = new System.Drawing.Point(253, 53);
            this.lblGCashBalance.MinimumSize = new System.Drawing.Size(268, 71);
            this.lblGCashBalance.Name = "lblGCashBalance";
            this.lblGCashBalance.Size = new System.Drawing.Size(268, 71);
            this.lblGCashBalance.TabIndex = 4;
            this.lblGCashBalance.Text = "0.00";
            this.lblGCashBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 86);
            this.label8.TabIndex = 3;
            this.label8.Text = "₱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "AVAILABLE GCASH BALANCE";
            // 
            // PanelTopupTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(580, 420);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnTopup);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelTopupTransaction";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "GCASH CASH IN";
            this.Load += new System.EventHandler(this.PanelTopupTransaction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelTopupTransaction_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRefNbr;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTopup;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblGCashBalance;
    }
}