namespace POS.Panels
{
    partial class PanelSettlePayments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtTenderedAmt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL DUE:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(23, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHANGE:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(23, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 61);
            this.label3.TabIndex = 2;
            this.label3.Text = "TENDERED AMOUNT:";
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotalDue.Location = new System.Drawing.Point(862, 60);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(298, 61);
            this.lblTotalDue.TabIndex = 3;
            this.lblTotalDue.Text = "0.00";
            this.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblChange.Location = new System.Drawing.Point(862, 144);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(298, 61);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "0.00";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenderedAmt
            // 
            this.txtTenderedAmt.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenderedAmt.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtTenderedAmt.Location = new System.Drawing.Point(873, 218);
            this.txtTenderedAmt.MaxLength = 15;
            this.txtTenderedAmt.Name = "txtTenderedAmt";
            this.txtTenderedAmt.Size = new System.Drawing.Size(287, 71);
            this.txtTenderedAmt.TabIndex = 5;
            this.txtTenderedAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTenderedAmt.TextChanged += new System.EventHandler(this.txtTenderedAmt_TextChanged);
            this.txtTenderedAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenderedAmt_KeyDown);
            this.txtTenderedAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenderedAmt_KeyPress);
            // 
            // PanelSettlePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1183, 321);
            this.Controls.Add(this.txtTenderedAmt);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTotalDue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelSettlePayments";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "SETTLE PAYMENT";
            this.Load += new System.EventHandler(this.PanelSettlePayments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtTenderedAmt;
    }
}