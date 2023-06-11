namespace POS.Panels.GCashPanels
{
    partial class PanelCashOut
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblGCashBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSeparateFee = new MetroFramework.Controls.MetroRadioButton();
            this.chkDeductFeeOnAmount = new MetroFramework.Controls.MetroRadioButton();
            this.chkAmountIncludeFee = new MetroFramework.Controls.MetroRadioButton();
            this.txtRefNbr = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalCashOutAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.metroPanel1.TabIndex = 10;
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
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "AVAILABLE BALANCE";
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(23, 497);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(534, 61);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "PROCESS";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkSeparateFee);
            this.panel1.Controls.Add(this.chkDeductFeeOnAmount);
            this.panel1.Controls.Add(this.chkAmountIncludeFee);
            this.panel1.Controls.Add(this.txtRefNbr);
            this.panel1.Controls.Add(this.txtFee);
            this.panel1.Controls.Add(this.txtAmt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 230);
            this.panel1.TabIndex = 12;
            // 
            // chkSeparateFee
            // 
            this.chkSeparateFee.AutoSize = true;
            this.chkSeparateFee.Checked = true;
            this.chkSeparateFee.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSeparateFee.Location = new System.Drawing.Point(253, 143);
            this.chkSeparateFee.Name = "chkSeparateFee";
            this.chkSeparateFee.Size = new System.Drawing.Size(176, 19);
            this.chkSeparateFee.TabIndex = 2;
            this.chkSeparateFee.TabStop = true;
            this.chkSeparateFee.Text = "Does fee pay separately?";
            this.chkSeparateFee.UseSelectable = true;
            this.chkSeparateFee.CheckedChanged += new System.EventHandler(this.chkSeparateFee_CheckedChanged);
            // 
            // chkDeductFeeOnAmount
            // 
            this.chkDeductFeeOnAmount.AutoSize = true;
            this.chkDeductFeeOnAmount.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDeductFeeOnAmount.Location = new System.Drawing.Point(253, 193);
            this.chkDeductFeeOnAmount.Name = "chkDeductFeeOnAmount";
            this.chkDeductFeeOnAmount.Size = new System.Drawing.Size(225, 19);
            this.chkDeductFeeOnAmount.TabIndex = 4;
            this.chkDeductFeeOnAmount.Text = "Deduct fee on cash out amount?";
            this.chkDeductFeeOnAmount.UseSelectable = true;
            this.chkDeductFeeOnAmount.CheckedChanged += new System.EventHandler(this.chkDeductFeeOnAmount_CheckedChanged);
            // 
            // chkAmountIncludeFee
            // 
            this.chkAmountIncludeFee.AutoSize = true;
            this.chkAmountIncludeFee.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkAmountIncludeFee.Location = new System.Drawing.Point(253, 168);
            this.chkAmountIncludeFee.Name = "chkAmountIncludeFee";
            this.chkAmountIncludeFee.Size = new System.Drawing.Size(213, 19);
            this.chkAmountIncludeFee.TabIndex = 3;
            this.chkAmountIncludeFee.Text = "Does the amount includes fee?";
            this.chkAmountIncludeFee.UseSelectable = true;
            this.chkAmountIncludeFee.CheckedChanged += new System.EventHandler(this.chkAmountIncludeFee_CheckedChanged);
            // 
            // txtRefNbr
            // 
            this.txtRefNbr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNbr.Location = new System.Drawing.Point(253, 17);
            this.txtRefNbr.Name = "txtRefNbr";
            this.txtRefNbr.Size = new System.Drawing.Size(267, 29);
            this.txtRefNbr.TabIndex = 0;
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.Location = new System.Drawing.Point(253, 99);
            this.txtFee.Name = "txtFee";
            this.txtFee.ReadOnly = true;
            this.txtFee.Size = new System.Drawing.Size(267, 29);
            this.txtFee.TabIndex = 2;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmt.Location = new System.Drawing.Point(253, 58);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(267, 29);
            this.txtAmt.TabIndex = 1;
            this.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmt_KeyPress);
            this.txtAmt.Leave += new System.EventHandler(this.txtAmt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transaction Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference Number";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalCashOutAmount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(23, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 50);
            this.panel2.TabIndex = 13;
            // 
            // lblTotalCashOutAmount
            // 
            this.lblTotalCashOutAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCashOutAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCashOutAmount.Location = new System.Drawing.Point(253, 9);
            this.lblTotalCashOutAmount.Name = "lblTotalCashOutAmount";
            this.lblTotalCashOutAmount.Size = new System.Drawing.Size(267, 32);
            this.lblTotalCashOutAmount.TabIndex = 3;
            this.lblTotalCashOutAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cash Out Amount";
            // 
            // PanelCashOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(580, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.metroPanel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelCashOut";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "GCash Cash Out";
            this.Load += new System.EventHandler(this.PanelCashOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelCashOut_KeyDown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblGCashBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRefNbr;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroRadioButton chkDeductFeeOnAmount;
        private MetroFramework.Controls.MetroRadioButton chkAmountIncludeFee;
        private MetroFramework.Controls.MetroRadioButton chkSeparateFee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalCashOutAmount;
        private System.Windows.Forms.Label label4;
    }
}