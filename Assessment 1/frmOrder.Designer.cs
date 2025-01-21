namespace Assessment_1
{
    partial class frmOrder
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
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.cmbFoods = new System.Windows.Forms.ComboBox();
            this.lstbxOrders = new System.Windows.Forms.ListBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDrinkQua = new System.Windows.Forms.Label();
            this.lblFoodQua = new System.Windows.Forms.Label();
            this.cmbDrinksQuantity = new System.Windows.Forms.ComboBox();
            this.cmbFoodQuantity = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.Location = new System.Drawing.Point(216, 169);
            this.cmbDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(168, 24);
            this.cmbDrinks.TabIndex = 0;
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.BackColor = System.Drawing.Color.Transparent;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink.ForeColor = System.Drawing.Color.White;
            this.lblDrink.Location = new System.Drawing.Point(85, 169);
            this.lblDrink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(111, 20);
            this.lblDrink.TabIndex = 1;
            this.lblDrink.Text = "Select Drink: ";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Transparent;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.White;
            this.lblFood.Location = new System.Drawing.Point(572, 169);
            this.lblFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(103, 20);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "Select food: ";
            // 
            // cmbFoods
            // 
            this.cmbFoods.FormattingEnabled = true;
            this.cmbFoods.Location = new System.Drawing.Point(696, 169);
            this.cmbFoods.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFoods.Name = "cmbFoods";
            this.cmbFoods.Size = new System.Drawing.Size(168, 24);
            this.cmbFoods.TabIndex = 3;
            // 
            // lstbxOrders
            // 
            this.lstbxOrders.FormattingEnabled = true;
            this.lstbxOrders.ItemHeight = 16;
            this.lstbxOrders.Location = new System.Drawing.Point(75, 288);
            this.lstbxOrders.Margin = new System.Windows.Forms.Padding(4);
            this.lstbxOrders.Name = "lstbxOrders";
            this.lstbxOrders.Size = new System.Drawing.Size(979, 228);
            this.lstbxOrders.TabIndex = 4;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(835, 546);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(232, 58);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(324, 28);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(399, 76);
            this.lblHeading.TabIndex = 6;
            this.lblHeading.Text = "Your Order: ";
            // 
            // lblDrinkQua
            // 
            this.lblDrinkQua.AutoSize = true;
            this.lblDrinkQua.BackColor = System.Drawing.Color.Transparent;
            this.lblDrinkQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkQua.ForeColor = System.Drawing.Color.White;
            this.lblDrinkQua.Location = new System.Drawing.Point(85, 230);
            this.lblDrinkQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrinkQua.Name = "lblDrinkQua";
            this.lblDrinkQua.Size = new System.Drawing.Size(172, 20);
            this.lblDrinkQua.TabIndex = 7;
            this.lblDrinkQua.Text = "Enter drinks quantity: ";
            // 
            // lblFoodQua
            // 
            this.lblFoodQua.AutoSize = true;
            this.lblFoodQua.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodQua.ForeColor = System.Drawing.Color.White;
            this.lblFoodQua.Location = new System.Drawing.Point(572, 230);
            this.lblFoodQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoodQua.Name = "lblFoodQua";
            this.lblFoodQua.Size = new System.Drawing.Size(159, 20);
            this.lblFoodQua.TabIndex = 8;
            this.lblFoodQua.Text = "Enter food quantity: ";
            // 
            // cmbDrinksQuantity
            // 
            this.cmbDrinksQuantity.FormattingEnabled = true;
            this.cmbDrinksQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDrinksQuantity.Location = new System.Drawing.Point(289, 229);
            this.cmbDrinksQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDrinksQuantity.Name = "cmbDrinksQuantity";
            this.cmbDrinksQuantity.Size = new System.Drawing.Size(132, 24);
            this.cmbDrinksQuantity.TabIndex = 9;
            // 
            // cmbFoodQuantity
            // 
            this.cmbFoodQuantity.FormattingEnabled = true;
            this.cmbFoodQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbFoodQuantity.Location = new System.Drawing.Point(761, 230);
            this.cmbFoodQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFoodQuantity.Name = "cmbFoodQuantity";
            this.cmbFoodQuantity.Size = new System.Drawing.Size(132, 24);
            this.cmbFoodQuantity.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(49, 540);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 63);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(299, 540);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 62);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment_1.Properties.Resources.wp7795859_abstract_dark_4k_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 640);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbFoodQuantity);
            this.Controls.Add(this.cmbDrinksQuantity);
            this.Controls.Add(this.lblFoodQua);
            this.Controls.Add(this.lblDrinkQua);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lstbxOrders);
            this.Controls.Add(this.cmbFoods);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.cmbDrinks);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.ComboBox cmbFoods;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDrinkQua;
        private System.Windows.Forms.Label lblFoodQua;
        private System.Windows.Forms.ComboBox cmbDrinksQuantity;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListBox lstbxOrders;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.ComboBox cmbFoodQuantity;
    }
}