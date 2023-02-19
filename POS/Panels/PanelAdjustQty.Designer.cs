namespace POS.Panels
{
    partial class PanelAdjustQty
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
            this.txtAdjustQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAdjustQty
            // 
            this.txtAdjustQty.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustQty.Location = new System.Drawing.Point(23, 63);
            this.txtAdjustQty.Name = "txtAdjustQty";
            this.txtAdjustQty.Size = new System.Drawing.Size(388, 93);
            this.txtAdjustQty.TabIndex = 0;
            this.txtAdjustQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdjustQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdjustQty_KeyPress);
            // 
            // PanelAdjustQty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(434, 167);
            this.ControlBox = false;
            this.Controls.Add(this.txtAdjustQty);
            this.KeyPreview = true;
            this.Name = "PanelAdjustQty";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "ADJUST QTY";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelAdjustQty_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdjustQty;
    }
}