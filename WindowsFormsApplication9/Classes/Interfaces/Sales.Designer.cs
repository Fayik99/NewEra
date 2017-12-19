namespace WindowsFormsApplication9
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_sell = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_cls = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_oi = new System.Windows.Forms.ComboBox();
            this.cmb_order = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_invoiceNumber = new System.Windows.Forms.Label();
            this.lbl_Invoicedate = new System.Windows.Forms.Label();
            this.lbl_grossTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_in = new System.Windows.Forms.Label();
            this.cmb_Code = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.itm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 605);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search Invoice";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(881, 596);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 32);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(747, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item Name\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sell Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(765, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(907, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total Value";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1024, 227);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 26);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_sell
            // 
            this.txt_sell.Location = new System.Drawing.Point(567, 236);
            this.txt_sell.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(132, 21);
            this.txt_sell.TabIndex = 17;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(730, 236);
            this.txt_q.Margin = new System.Windows.Forms.Padding(4);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(132, 21);
            this.txt_q.TabIndex = 18;
            this.txt_q.TextChanged += new System.EventHandler(this.txt_q_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itm,
            this.ItmName,
            this.SellPrice,
            this.Quantity,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(567, 333);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 112);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(730, 528);
            this.btn_sub.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(100, 27);
            this.btn_sub.TabIndex = 21;
            this.btn_sub.Text = "Submit";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_cls
            // 
            this.btn_cls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cls.Location = new System.Drawing.Point(855, 528);
            this.btn_cls.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(109, 27);
            this.btn_cls.TabIndex = 22;
            this.btn_cls.Text = "Close";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(747, 479);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "GrossTotal";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(23, 26);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(67, 51);
            this.btn_back.TabIndex = 29;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(728, 154);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(121, 23);
            this.cmb_item.TabIndex = 30;
            this.cmb_item.SelectedIndexChanged += new System.EventHandler(this.itmcmb_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(501, 333);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(10, 112);
            this.dataGridView2.TabIndex = 32;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(927, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "lbl_tv";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(69, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Customer ID";
            // 
            // cmb_oi
            // 
            this.cmb_oi.FormattingEnabled = true;
            this.cmb_oi.Location = new System.Drawing.Point(177, 166);
            this.cmb_oi.Name = "cmb_oi";
            this.cmb_oi.Size = new System.Drawing.Size(121, 23);
            this.cmb_oi.TabIndex = 35;
            this.cmb_oi.SelectedIndexChanged += new System.EventHandler(this.cmb_oi_SelectedIndexChanged);
            // 
            // cmb_order
            // 
            this.cmb_order.FormattingEnabled = true;
            this.cmb_order.Location = new System.Drawing.Point(177, 210);
            this.cmb_order.Name = "cmb_order";
            this.cmb_order.Size = new System.Drawing.Size(121, 23);
            this.cmb_order.TabIndex = 37;
            this.cmb_order.SelectedIndexChanged += new System.EventHandler(this.cmb_order_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 333);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(479, 112);
            this.dataGridView3.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Load Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "Orders";
            // 
            // lbl_invoiceNumber
            // 
            this.lbl_invoiceNumber.AutoSize = true;
            this.lbl_invoiceNumber.Location = new System.Drawing.Point(187, 98);
            this.lbl_invoiceNumber.Name = "lbl_invoiceNumber";
            this.lbl_invoiceNumber.Size = new System.Drawing.Size(55, 15);
            this.lbl_invoiceNumber.TabIndex = 42;
            this.lbl_invoiceNumber.Text = "label14";
            // 
            // lbl_Invoicedate
            // 
            this.lbl_Invoicedate.AutoSize = true;
            this.lbl_Invoicedate.Location = new System.Drawing.Point(187, 136);
            this.lbl_Invoicedate.Name = "lbl_Invoicedate";
            this.lbl_Invoicedate.Size = new System.Drawing.Size(55, 15);
            this.lbl_Invoicedate.TabIndex = 43;
            this.lbl_Invoicedate.Text = "label14";
            // 
            // lbl_grossTotal
            // 
            this.lbl_grossTotal.AutoSize = true;
            this.lbl_grossTotal.Location = new System.Drawing.Point(852, 480);
            this.lbl_grossTotal.Name = "lbl_grossTotal";
            this.lbl_grossTotal.Size = new System.Drawing.Size(55, 15);
            this.lbl_grossTotal.TabIndex = 44;
            this.lbl_grossTotal.Text = "label14";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(906, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Description";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_in
            // 
            this.lbl_in.AutoSize = true;
            this.lbl_in.Location = new System.Drawing.Point(917, 162);
            this.lbl_in.Name = "lbl_in";
            this.lbl_in.Size = new System.Drawing.Size(47, 15);
            this.lbl_in.TabIndex = 31;
            this.lbl_in.Text = "label5";
            this.lbl_in.Click += new System.EventHandler(this.lbl_in_Click);
            // 
            // cmb_Code
            // 
            this.cmb_Code.FormattingEnabled = true;
            this.cmb_Code.Location = new System.Drawing.Point(567, 154);
            this.cmb_Code.Name = "cmb_Code";
            this.cmb_Code.Size = new System.Drawing.Size(121, 23);
            this.cmb_Code.TabIndex = 46;
            this.cmb_Code.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(564, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 15);
            this.label14.TabIndex = 45;
            this.label14.Text = "Item Code\r\n";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(137, 525);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 110);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // itm
            // 
            this.itm.HeaderText = "item Code";
            this.itm.Name = "itm";
            // 
            // ItmName
            // 
            this.ItmName.HeaderText = "Item Name";
            this.ItmName.Name = "ItmName";
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Sell Price";
            this.SellPrice.Name = "SellPrice";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "subtotal";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "update";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1235, 682);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmb_Code);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_grossTotal);
            this.Controls.Add(this.lbl_Invoicedate);
            this.Controls.Add(this.lbl_invoiceNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.cmb_order);
            this.Controls.Add(this.cmb_oi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbl_in);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.txt_sell);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_sell;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmb_item;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_oi;
        private System.Windows.Forms.ComboBox cmb_order;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_invoiceNumber;
        private System.Windows.Forms.Label lbl_Invoicedate;
        private System.Windows.Forms.Label lbl_grossTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_in;
        private System.Windows.Forms.ComboBox cmb_Code;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}