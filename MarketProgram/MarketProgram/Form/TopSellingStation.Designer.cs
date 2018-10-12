namespace MarketProgram
{
    partial class TopSellingStation
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
            this.dataGrid_allProduct = new System.Windows.Forms.DataGridView();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.cmbx_Currency = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbx_Usage = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.btn_go_main = new System.Windows.Forms.Button();
            this.cmbx_all_buyer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_percent = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.cmbx_Weight = new System.Windows.Forms.ComboBox();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.errorProvider_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_messageforuser = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.errorProvider_Percent = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_allProduct
            // 
            this.dataGrid_allProduct.AllowUserToOrderColumns = true;
            this.dataGrid_allProduct.AllowUserToResizeColumns = false;
            this.dataGrid_allProduct.AllowUserToResizeRows = false;
            this.dataGrid_allProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_allProduct.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGrid_allProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_allProduct.CausesValidation = false;
            this.dataGrid_allProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGrid_allProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_allProduct.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_allProduct.Location = new System.Drawing.Point(49, 62);
            this.dataGrid_allProduct.Name = "dataGrid_allProduct";
            this.dataGrid_allProduct.ReadOnly = true;
            this.dataGrid_allProduct.RowTemplate.Height = 24;
            this.dataGrid_allProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_allProduct.Size = new System.Drawing.Size(806, 765);
            this.dataGrid_allProduct.TabIndex = 0;
            this.dataGrid_allProduct.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_allProduct_CellMouseLeave);
            this.dataGrid_allProduct.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_allProduct_CellMouseMove);
            this.dataGrid_allProduct.DoubleClick += new System.EventHandler(this.dataGrid_allProduct_DoubleClick);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Name.Location = new System.Drawing.Point(885, 152);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(257, 31);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.Enter += new System.EventHandler(this.txt_Name_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(892, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Price.Location = new System.Drawing.Point(886, 230);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(257, 31);
            this.txt_Price.TabIndex = 3;
            this.txt_Price.Enter += new System.EventHandler(this.txt_Name_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(885, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(885, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Count";
            // 
            // txt_Count
            // 
            this.txt_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Count.Location = new System.Drawing.Point(886, 399);
            this.txt_Count.Multiline = true;
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(257, 29);
            this.txt_Count.TabIndex = 7;
            this.txt_Count.Enter += new System.EventHandler(this.txt_Name_Enter);
            // 
            // cmbx_Currency
            // 
            this.cmbx_Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_Currency.FormattingEnabled = true;
            this.cmbx_Currency.Location = new System.Drawing.Point(886, 320);
            this.cmbx_Currency.Name = "cmbx_Currency";
            this.cmbx_Currency.Size = new System.Drawing.Size(257, 26);
            this.cmbx_Currency.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(886, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(887, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sell-TIme";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(887, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usage";
            // 
            // cmbx_Usage
            // 
            this.cmbx_Usage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_Usage.FormattingEnabled = true;
            this.cmbx_Usage.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbx_Usage.Location = new System.Drawing.Point(886, 619);
            this.cmbx_Usage.Name = "cmbx_Usage";
            this.cmbx_Usage.Size = new System.Drawing.Size(258, 26);
            this.cmbx_Usage.TabIndex = 13;
            this.cmbx_Usage.Text = "True";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(885, 679);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 42);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(884, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(883, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(883, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Category";
            // 
            // txt_Category
            // 
            this.txt_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Category.Location = new System.Drawing.Point(885, 82);
            this.txt_Category.Multiline = true;
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(257, 31);
            this.txt_Category.TabIndex = 17;
            this.txt_Category.Enter += new System.EventHandler(this.txt_Name_Enter);
            // 
            // btn_go_main
            // 
            this.btn_go_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_go_main.Location = new System.Drawing.Point(49, 863);
            this.btn_go_main.Name = "btn_go_main";
            this.btn_go_main.Size = new System.Drawing.Size(145, 94);
            this.btn_go_main.TabIndex = 20;
            this.btn_go_main.Text = "Go to Main";
            this.btn_go_main.UseVisualStyleBackColor = true;
            this.btn_go_main.Click += new System.EventHandler(this.btn_go_main_Click);
            // 
            // cmbx_all_buyer
            // 
            this.cmbx_all_buyer.DisplayMember = "Name";
            this.cmbx_all_buyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_all_buyer.FormattingEnabled = true;
            this.cmbx_all_buyer.Location = new System.Drawing.Point(1309, 705);
            this.cmbx_all_buyer.Name = "cmbx_all_buyer";
            this.cmbx_all_buyer.Size = new System.Drawing.Size(257, 26);
            this.cmbx_all_buyer.TabIndex = 22;
            this.cmbx_all_buyer.ValueMember = "Id";
            this.cmbx_all_buyer.SelectedValueChanged += new System.EventHandler(this.cmbx_all_buyer_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1314, 682);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "All Buyer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1654, 682);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Percent";
            // 
            // txt_percent
            // 
            this.txt_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_percent.Location = new System.Drawing.Point(1648, 705);
            this.txt_percent.Multiline = true;
            this.txt_percent.Name = "txt_percent";
            this.txt_percent.Size = new System.Drawing.Size(257, 29);
            this.txt_percent.TabIndex = 24;
            this.txt_percent.Enter += new System.EventHandler(this.txt_percent_Enter);
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_apply.Location = new System.Drawing.Point(1309, 748);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(145, 42);
            this.btn_apply.TabIndex = 25;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // cmbx_Weight
            // 
            this.cmbx_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_Weight.FormattingEnabled = true;
            this.cmbx_Weight.Location = new System.Drawing.Point(886, 486);
            this.cmbx_Weight.Name = "cmbx_Weight";
            this.cmbx_Weight.Size = new System.Drawing.Size(257, 26);
            this.cmbx_Weight.TabIndex = 26;
            // 
            // date_time
            // 
            this.date_time.CustomFormat = "dd.MM.yyyy HH:mm";
            this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_time.Location = new System.Drawing.Point(885, 553);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(258, 22);
            this.date_time.TabIndex = 27;
            // 
            // errorProvider_Name
            // 
            this.errorProvider_Name.ContainerControl = this;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_delete.Location = new System.Drawing.Point(1022, 679);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(122, 42);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_messageforuser
            // 
            this.lbl_messageforuser.AutoSize = true;
            this.lbl_messageforuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_messageforuser.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_messageforuser.Location = new System.Drawing.Point(54, 39);
            this.lbl_messageforuser.Name = "lbl_messageforuser";
            this.lbl_messageforuser.Size = new System.Drawing.Size(0, 18);
            this.lbl_messageforuser.TabIndex = 29;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.Location = new System.Drawing.Point(954, 742);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 42);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // errorProvider_Percent
            // 
            this.errorProvider_Percent.ContainerControl = this;
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.AllowUserToOrderColumns = true;
            this.dataGridView_user.AllowUserToResizeColumns = false;
            this.dataGridView_user.AllowUserToResizeRows = false;
            this.dataGridView_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_user.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_user.CausesValidation = false;
            this.dataGridView_user.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_user.Location = new System.Drawing.Point(1309, 62);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.RowTemplate.Height = 24;
            this.dataGridView_user.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_user.Size = new System.Drawing.Size(607, 583);
            this.dataGridView_user.TabIndex = 31;
            // 
            // TopSellingStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 969);
            this.Controls.Add(this.dataGridView_user);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_messageforuser);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.cmbx_Weight);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_percent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbx_all_buyer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_go_main);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbx_Usage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbx_Currency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.dataGrid_allProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TopSellingStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopSellingStation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TopSellingStation_FormClosed);
            this.Load += new System.EventHandler(this.TopSellingStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_allProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_allProduct;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.ComboBox cmbx_Currency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx_Usage;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Button btn_go_main;
        private System.Windows.Forms.ComboBox cmbx_all_buyer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_percent;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.ComboBox cmbx_Weight;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.ErrorProvider errorProvider_Name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_messageforuser;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ErrorProvider errorProvider_Percent;
        private System.Windows.Forms.DataGridView dataGridView_user;
    }
}