namespace Assessment_1
{
    partial class frmStaff
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtSearchQuantity = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtDeleteOrderId = new System.Windows.Forms.TextBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtSearchProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(47, 32);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1092, 315);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(43, 405);
            this.btnAddItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(192, 55);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Location = new System.Drawing.Point(43, 497);
            this.btnDeleteItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(192, 55);
            this.btnDeleteItems.TabIndex = 2;
            this.btnDeleteItems.Text = "Delete";
            this.btnDeleteItems.UseVisualStyleBackColor = true;
            this.btnDeleteItems.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(545, 422);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(179, 20);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Search with Quantity:  ";
            // 
            // txtSearchQuantity
            // 
            this.txtSearchQuantity.Location = new System.Drawing.Point(753, 422);
            this.txtSearchQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchQuantity.Name = "txtSearchQuantity";
            this.txtSearchQuantity.Size = new System.Drawing.Size(219, 22);
            this.txtSearchQuantity.TabIndex = 4;
            this.txtSearchQuantity.TextChanged += new System.EventHandler(this.txtSearchQuantity_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(545, 529);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(170, 20);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Search with Product: ";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(919, 582);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(219, 65);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDeleteOrderId
            // 
            this.txtDeleteOrderId.Location = new System.Drawing.Point(311, 530);
            this.txtDeleteOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeleteOrderId.Name = "txtDeleteOrderId";
            this.txtDeleteOrderId.Size = new System.Drawing.Size(95, 22);
            this.txtDeleteOrderId.TabIndex = 8;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.White;
            this.lblDelete.Location = new System.Drawing.Point(275, 497);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(193, 20);
            this.lblDelete.TabIndex = 9;
            this.lblDelete.Text = "Enter Order ID to delete:";
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Location = new System.Drawing.Point(753, 530);
            this.txtSearchProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Size = new System.Drawing.Size(219, 22);
            this.txtSearchProd.TabIndex = 10;
            this.txtSearchProd.TextChanged += new System.EventHandler(this.txtSearchProd_TextChanged);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment_1.Properties.Resources.wp7795859_abstract_dark_4k_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 667);
            this.Controls.Add(this.txtSearchProd);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.txtDeleteOrderId);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtSearchQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnDeleteItems);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.dataGridViewOrders);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtSearchQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtDeleteOrderId;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtSearchProd;
    }
}