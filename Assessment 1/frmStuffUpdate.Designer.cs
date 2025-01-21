
namespace Assessment_1
{
    partial class frmStuffUpdate
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
            this.txtDrink = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDrinkQua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoodQua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink:";
            // 
            // txtDrink
            // 
            this.txtDrink.Location = new System.Drawing.Point(190, 32);
            this.txtDrink.Name = "txtDrink";
            this.txtDrink.Size = new System.Drawing.Size(100, 22);
            this.txtDrink.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(379, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDrinkQua
            // 
            this.txtDrinkQua.Location = new System.Drawing.Point(190, 72);
            this.txtDrinkQua.Name = "txtDrinkQua";
            this.txtDrinkQua.Size = new System.Drawing.Size(100, 22);
            this.txtDrinkQua.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Drink Quantity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(190, 118);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(100, 22);
            this.txtFood.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(34, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Food:";
            // 
            // txtFoodQua
            // 
            this.txtFoodQua.Location = new System.Drawing.Point(190, 158);
            this.txtFoodQua.Name = "txtFoodQua";
            this.txtFoodQua.Size = new System.Drawing.Size(100, 22);
            this.txtFoodQua.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(34, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "FoodQuantity:";
            // 
            // frmStuffUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment_1.Properties.Resources.wp7795859_abstract_dark_4k_wallpapers;
            this.ClientSize = new System.Drawing.Size(534, 257);
            this.Controls.Add(this.txtFoodQua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDrinkQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDrink);
            this.Controls.Add(this.label1);
            this.Name = "frmStuffUpdate";
            this.Text = "frmStuffUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDrink;
        public System.Windows.Forms.TextBox txtDrinkQua;
        public System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtFoodQua;
        private System.Windows.Forms.Label label6;
    }
}