
namespace MyMarket
{
    partial class SellingForm
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
            this.button_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.TextBox_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_quantity = new System.Windows.Forms.TextBox();
            this.labelphone = new System.Windows.Forms.Label();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.label_sellername = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView_SelList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelList)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.Chocolate;
            this.button_logout.Location = new System.Drawing.Point(12, 669);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(59, 295);
            this.button_logout.TabIndex = 24;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView_SelList);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.comboBox_category);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_sellername);
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.dataGridView_orders);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_print);
            this.panel1.Controls.Add(this.button_addOrder);
            this.panel1.Controls.Add(this.TextBox_price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_quantity);
            this.panel1.Controls.Add(this.labelphone);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(87, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 972);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.ProdPrice,
            this.ProdQty,
            this.Total});
            this.dataGridView_orders.Location = new System.Drawing.Point(413, 88);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.RowHeadersWidth = 40;
            this.dataGridView_orders.RowTemplate.Height = 33;
            this.dataGridView_orders.Size = new System.Drawing.Size(908, 274);
            this.dataGridView_orders.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 15;
            this.label6.Text = "SELLİNG";
            // 
            // button_add
            // 
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(804, 867);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(125, 61);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_print
            // 
            this.button_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_print.Location = new System.Drawing.Point(1000, 867);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(125, 61);
            this.button_print.TabIndex = 11;
            this.button_print.Text = "PRİNT";
            this.button_print.UseVisualStyleBackColor = true;
            // 
            // button_addOrder
            // 
            this.button_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addOrder.Location = new System.Drawing.Point(179, 342);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(125, 61);
            this.button_addOrder.TabIndex = 10;
            this.button_addOrder.Text = "Add Order";
            this.button_addOrder.UseVisualStyleBackColor = true;
            this.button_addOrder.Click += new System.EventHandler(this.button_addOrder_Click);
            // 
            // TextBox_price
            // 
            this.TextBox_price.Location = new System.Drawing.Point(164, 217);
            this.TextBox_price.Name = "TextBox_price";
            this.TextBox_price.ReadOnly = true;
            this.TextBox_price.Size = new System.Drawing.Size(140, 31);
            this.TextBox_price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // TextBox_quantity
            // 
            this.TextBox_quantity.Location = new System.Drawing.Point(164, 288);
            this.TextBox_quantity.Name = "TextBox_quantity";
            this.TextBox_quantity.Size = new System.Drawing.Size(140, 31);
            this.TextBox_quantity.TabIndex = 5;
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.Location = new System.Drawing.Point(42, 285);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(116, 31);
            this.labelphone.TabIndex = 4;
            this.labelphone.Text = "Quantity";
            // 
            // TextBox_name
            // 
            this.TextBox_name.Location = new System.Drawing.Point(164, 155);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.ReadOnly = true;
            this.TextBox_name.Size = new System.Drawing.Size(140, 31);
            this.TextBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TextBox_id
            // 
            this.TextBox_id.Location = new System.Drawing.Point(164, 88);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.Size = new System.Drawing.Size(140, 31);
            this.TextBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(27, 504);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersWidth = 82;
            this.dataGridView_product.RowTemplate.Height = 33;
            this.dataGridView_product.Size = new System.Drawing.Size(430, 433);
            this.dataGridView_product.TabIndex = 17;
            this.dataGridView_product.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // label_sellername
            // 
            this.label_sellername.AutoSize = true;
            this.label_sellername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sellername.Location = new System.Drawing.Point(60, 10);
            this.label_sellername.Name = "label_sellername";
            this.label_sellername.Size = new System.Drawing.Size(155, 31);
            this.label_sellername.TabIndex = 18;
            this.label_sellername.Text = "SellerName";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.Location = new System.Drawing.Point(1230, 38);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(72, 31);
            this.label_date.TabIndex = 19;
            this.label_date.Text = "Date";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(16, 457);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(239, 33);
            this.comboBox_category.TabIndex = 20;
            this.comboBox_category.Text = "Select Category";
            // 
            // button_refresh
            // 
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(269, 447);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(188, 51);
            this.button_refresh.TabIndex = 21;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView_SelList
            // 
            this.dataGridView_SelList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_SelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SelList.Location = new System.Drawing.Point(523, 567);
            this.dataGridView_SelList.Name = "dataGridView_SelList";
            this.dataGridView_SelList.RowHeadersWidth = 82;
            this.dataGridView_SelList.RowTemplate.Height = 33;
            this.dataGridView_SelList.Size = new System.Drawing.Size(798, 274);
            this.dataGridView_SelList.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Sells List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(980, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "KS";
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 10;
            this.ProdId.Name = "ProdId";
            this.ProdId.Width = 200;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 10;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 200;
            // 
            // ProdPrice
            // 
            this.ProdPrice.HeaderText = "ProdPrice";
            this.ProdPrice.MinimumWidth = 10;
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Width = 200;
            // 
            // ProdQty
            // 
            this.ProdQty.HeaderText = "ProdQty";
            this.ProdQty.MinimumWidth = 10;
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Width = 200;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 10;
            this.Total.Name = "Total";
            this.Total.Width = 200;
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 1020);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel1);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_addOrder;
        private System.Windows.Forms.TextBox TextBox_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_quantity;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.TextBox TextBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_sellername;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_SelList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}