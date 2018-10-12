namespace MarketProgram
{
    partial class BuyProduct
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_buyer = new System.Windows.Forms.DataGridView();
            this.cmbx_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_currency = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_buyer = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dateTime_buying = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider_shop = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_stc_count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_shop)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_buyer
            // 
            this.dataGridView_buyer.AllowUserToOrderColumns = true;
            this.dataGridView_buyer.AllowUserToResizeColumns = false;
            this.dataGridView_buyer.AllowUserToResizeRows = false;
            this.dataGridView_buyer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_buyer.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView_buyer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_buyer.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView_buyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buyer.Location = new System.Drawing.Point(72, 70);
            this.dataGridView_buyer.Name = "dataGridView_buyer";
            this.dataGridView_buyer.ReadOnly = true;
            this.dataGridView_buyer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView_buyer.RowTemplate.Height = 24;
            this.dataGridView_buyer.Size = new System.Drawing.Size(964, 400);
            this.dataGridView_buyer.TabIndex = 0;
            // 
            // cmbx_category
            // 
            this.cmbx_category.FormattingEnabled = true;
            this.cmbx_category.Location = new System.Drawing.Point(1090, 67);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(225, 24);
            this.cmbx_category.TabIndex = 1;
            this.cmbx_category.SelectedValueChanged += new System.EventHandler(this.cmbx_category_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1087, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1087, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // cmbx_Name
            // 
            this.cmbx_Name.FormattingEnabled = true;
            this.cmbx_Name.Location = new System.Drawing.Point(1090, 135);
            this.cmbx_Name.Name = "cmbx_Name";
            this.cmbx_Name.Size = new System.Drawing.Size(225, 24);
            this.cmbx_Name.TabIndex = 3;
            this.cmbx_Name.SelectedValueChanged += new System.EventHandler(this.cmbx_Name_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1087, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // txt_Count
            // 
            this.txt_Count.CausesValidation = false;
            this.txt_Count.Location = new System.Drawing.Point(1090, 395);
            this.txt_Count.Multiline = true;
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(225, 27);
            this.txt_Count.TabIndex = 9;
            this.txt_Count.TextChanged += new System.EventHandler(this.txt_Count_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1087, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count";
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.CausesValidation = false;
            this.txt_totalPrice.Enabled = false;
            this.txt_totalPrice.Location = new System.Drawing.Point(1090, 464);
            this.txt_totalPrice.Multiline = true;
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.Size = new System.Drawing.Size(225, 27);
            this.txt_totalPrice.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1087, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Price";
            // 
            // txt_currency
            // 
            this.txt_currency.CausesValidation = false;
            this.txt_currency.Enabled = false;
            this.txt_currency.Location = new System.Drawing.Point(1090, 340);
            this.txt_currency.Multiline = true;
            this.txt_currency.Name = "txt_currency";
            this.txt_currency.Size = new System.Drawing.Size(225, 27);
            this.txt_currency.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1087, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Currency";
            // 
            // btn_buy
            // 
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_buy.Location = new System.Drawing.Point(1090, 572);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(162, 49);
            this.btn_buy.TabIndex = 17;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Buyer";
            // 
            // txt_buyer
            // 
            this.txt_buyer.CausesValidation = false;
            this.txt_buyer.Enabled = false;
            this.txt_buyer.Location = new System.Drawing.Point(121, 36);
            this.txt_buyer.Multiline = true;
            this.txt_buyer.Name = "txt_buyer";
            this.txt_buyer.Size = new System.Drawing.Size(225, 27);
            this.txt_buyer.TabIndex = 19;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(72, 504);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(106, 39);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dateTime_buying
            // 
            this.dateTime_buying.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTime_buying.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_buying.Location = new System.Drawing.Point(1090, 526);
            this.dateTime_buying.Name = "dateTime_buying";
            this.dateTime_buying.Size = new System.Drawing.Size(225, 22);
            this.dateTime_buying.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1087, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Buying Time";
            // 
            // txt_weight
            // 
            this.txt_weight.CausesValidation = false;
            this.txt_weight.Enabled = false;
            this.txt_weight.Location = new System.Drawing.Point(1090, 189);
            this.txt_weight.Multiline = true;
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(225, 27);
            this.txt_weight.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1088, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Weight";
            // 
            // errorProvider_shop
            // 
            this.errorProvider_shop.ContainerControl = this;
            // 
            // txt_Price
            // 
            this.txt_Price.CausesValidation = false;
            this.txt_Price.Enabled = false;
            this.txt_Price.Location = new System.Drawing.Point(1090, 239);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(225, 27);
            this.txt_Price.TabIndex = 25;
            // 
            // txt_stc_count
            // 
            this.txt_stc_count.CausesValidation = false;
            this.txt_stc_count.Enabled = false;
            this.txt_stc_count.Location = new System.Drawing.Point(1091, 290);
            this.txt_stc_count.Multiline = true;
            this.txt_stc_count.Name = "txt_stc_count";
            this.txt_stc_count.Size = new System.Drawing.Size(225, 27);
            this.txt_stc_count.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1088, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stock Count";
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 652);
            this.Controls.Add(this.txt_stc_count);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTime_buying);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_buyer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.txt_currency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_totalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_category);
            this.Controls.Add(this.dataGridView_buyer);
            this.Name = "BuyProduct";
            this.Text = "BuyProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuyProduct_FormClosed);
            this.Load += new System.EventHandler(this.BuyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_shop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_buyer;
        private System.Windows.Forms.ComboBox cmbx_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_currency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_buyer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTime_buying;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider_shop;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_stc_count;
        private System.Windows.Forms.Label label10;
    }
}