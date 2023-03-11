namespace POS.Panels
{
    partial class PanelPettyCash
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
            this.txtPettyCash = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGCashPettyCash = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPettyCash
            // 
            this.txtPettyCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPettyCash.ForeColor = System.Drawing.Color.Black;
            this.txtPettyCash.Location = new System.Drawing.Point(288, 84);
            this.txtPettyCash.Name = "txtPettyCash";
            this.txtPettyCash.Size = new System.Drawing.Size(240, 29);
            this.txtPettyCash.TabIndex = 8;
            this.txtPettyCash.Text = "0.00";
            this.txtPettyCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPettyCash.Enter += new System.EventHandler(this.txtPettyCash_Enter);
            this.txtPettyCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPettyCash_KeyPress);
            this.txtPettyCash.Leave += new System.EventHandler(this.txtPettyCash_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 32);
            this.label7.TabIndex = 7;
            this.label7.Text = "PETTY CASH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "GCASH PETTY CASH:";
            // 
            // txtGCashPettyCash
            // 
            this.txtGCashPettyCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGCashPettyCash.ForeColor = System.Drawing.Color.Black;
            this.txtGCashPettyCash.Location = new System.Drawing.Point(288, 131);
            this.txtGCashPettyCash.Name = "txtGCashPettyCash";
            this.txtGCashPettyCash.Size = new System.Drawing.Size(240, 29);
            this.txtGCashPettyCash.TabIndex = 10;
            this.txtGCashPettyCash.Text = "0.00";
            this.txtGCashPettyCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGCashPettyCash.Enter += new System.EventHandler(this.txtGCashPettyCash_Enter);
            this.txtGCashPettyCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGCashPettyCash_KeyPress);
            this.txtGCashPettyCash.Leave += new System.EventHandler(this.txtGCashPettyCash_Leave);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(410, 172);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(118, 34);
            this.btnProcess.TabIndex = 11;
            this.btnProcess.Text = "PROCEED";
            this.btnProcess.UseVisualStyleBackColor = false;
            // 
            // PanelPettyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(543, 229);
            this.ControlBox = false;
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtGCashPettyCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPettyCash);
            this.Controls.Add(this.label7);
            this.Name = "PanelPettyCash";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "SHIFT PETTY CASH ";
            this.Load += new System.EventHandler(this.PanelPettyCash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPettyCash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGCashPettyCash;
        private System.Windows.Forms.Button btnProcess;
    }
}