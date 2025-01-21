namespace Assessment_1
{
    partial class frmReceipt
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
            this.lstbxReceipt = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxReceipt
            // 
            this.lstbxReceipt.FormattingEnabled = true;
            this.lstbxReceipt.ItemHeight = 16;
            this.lstbxReceipt.Location = new System.Drawing.Point(47, 181);
            this.lstbxReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxReceipt.Name = "lstbxReceipt";
            this.lstbxReceipt.Size = new System.Drawing.Size(1093, 292);
            this.lstbxReceipt.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(871, 581);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(257, 69);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipt.ForeColor = System.Drawing.Color.White;
            this.lblReceipt.Location = new System.Drawing.Point(352, 37);
            this.lblReceipt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(429, 76);
            this.lblReceipt.TabIndex = 2;
            this.lblReceipt.Text = "Your receipt: ";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment_1.Properties.Resources.wp7795859_abstract_dark_4k_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 688);
            this.Controls.Add(this.lblReceipt);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lstbxReceipt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReceipt";
            this.Text = "frmReceipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblReceipt;
        public System.Windows.Forms.ListBox lstbxReceipt;
    }
}