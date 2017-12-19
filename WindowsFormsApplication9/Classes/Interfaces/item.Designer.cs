namespace WindowsFormsApplication9
{
    partial class item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(item));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.cmb_sup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmb_ic = new System.Windows.Forms.ComboBox();
            this.lbl_itemCode = new System.Windows.Forms.Label();
            this.itemCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_name1 = new System.Windows.Forms.TextBox();
            this.txt_price1 = new System.Windows.Forms.TextBox();
            this.txt_q1 = new System.Windows.Forms.TextBox();
            this.cmb_sup1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_order = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier ID";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(249, 393);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 28);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(623, 393);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 28);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update Item";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(1054, 149);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(112, 28);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Delete Item";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(290, 172);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(148, 22);
            this.txt_name.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(290, 219);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(148, 22);
            this.txt_price.TabIndex = 11;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(290, 270);
            this.txt_q.Margin = new System.Windows.Forms.Padding(4);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(148, 22);
            this.txt_q.TabIndex = 12;
            // 
            // cmb_sup
            // 
            this.cmb_sup.FormattingEnabled = true;
            this.cmb_sup.Location = new System.Drawing.Point(290, 321);
            this.cmb_sup.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_sup.Name = "cmb_sup";
            this.cmb_sup.Size = new System.Drawing.Size(180, 24);
            this.cmb_sup.TabIndex = 13;
            this.cmb_sup.SelectedIndexChanged += new System.EventHandler(this.cmb_sup_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(515, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item Manager";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(33, 47);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 49);
            this.btn_back.TabIndex = 16;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cmb_ic
            // 
            this.cmb_ic.FormattingEnabled = true;
            this.cmb_ic.Location = new System.Drawing.Point(698, 182);
            this.cmb_ic.Name = "cmb_ic";
            this.cmb_ic.Size = new System.Drawing.Size(121, 24);
            this.cmb_ic.TabIndex = 17;
            this.cmb_ic.SelectedIndexChanged += new System.EventHandler(this.cmb_ic_SelectedIndexChanged);
            // 
            // lbl_itemCode
            // 
            this.lbl_itemCode.AutoSize = true;
            this.lbl_itemCode.Location = new System.Drawing.Point(309, 114);
            this.lbl_itemCode.Name = "lbl_itemCode";
            this.lbl_itemCode.Size = new System.Drawing.Size(37, 16);
            this.lbl_itemCode.TabIndex = 18;
            this.lbl_itemCode.Text = "item";
            this.lbl_itemCode.Click += new System.EventHandler(this.itemCode_Click);
            // 
            // itemCode
            // 
            this.itemCode.AutoSize = true;
            this.itemCode.Location = new System.Drawing.Point(582, 185);
            this.itemCode.Name = "itemCode";
            this.itemCode.Size = new System.Drawing.Size(78, 16);
            this.itemCode.TabIndex = 19;
            this.itemCode.Text = "Item Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Item Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Item Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(582, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Supplier ID";
            // 
            // txt_name1
            // 
            this.txt_name1.Location = new System.Drawing.Point(698, 222);
            this.txt_name1.Name = "txt_name1";
            this.txt_name1.Size = new System.Drawing.Size(100, 22);
            this.txt_name1.TabIndex = 24;
            // 
            // txt_price1
            // 
            this.txt_price1.Location = new System.Drawing.Point(698, 270);
            this.txt_price1.Name = "txt_price1";
            this.txt_price1.Size = new System.Drawing.Size(100, 22);
            this.txt_price1.TabIndex = 25;
            // 
            // txt_q1
            // 
            this.txt_q1.Location = new System.Drawing.Point(698, 315);
            this.txt_q1.Name = "txt_q1";
            this.txt_q1.Size = new System.Drawing.Size(100, 22);
            this.txt_q1.TabIndex = 26;
            // 
            // cmb_sup1
            // 
            this.cmb_sup1.FormattingEnabled = true;
            this.cmb_sup1.Location = new System.Drawing.Point(698, 112);
            this.cmb_sup1.Name = "cmb_sup1";
            this.cmb_sup1.Size = new System.Drawing.Size(121, 24);
            this.cmb_sup1.TabIndex = 27;
            this.cmb_sup1.SelectedIndexChanged += new System.EventHandler(this.cmb_sup1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Order Id";
            // 
            // cmb_order
            // 
            this.cmb_order.FormattingEnabled = true;
            this.cmb_order.Location = new System.Drawing.Point(698, 146);
            this.cmb_order.Name = "cmb_order";
            this.cmb_order.Size = new System.Drawing.Size(121, 24);
            this.cmb_order.TabIndex = 29;
            this.cmb_order.SelectedIndexChanged += new System.EventHandler(this.cmb_order_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 461);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 186);
            this.dataGridView1.TabIndex = 30;
            // 
            // cmb_Name
            // 
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(1054, 105);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(121, 24);
            this.cmb_Name.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(960, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Item Name";
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(963, 285);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(133, 52);
            this.btn_view.TabIndex = 33;
            this.btn_view.Text = "View Items";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1353, 720);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_order);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_sup1);
            this.Controls.Add(this.txt_q1);
            this.Controls.Add(this.txt_price1);
            this.Controls.Add(this.txt_name1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemCode);
            this.Controls.Add(this.lbl_itemCode);
            this.Controls.Add(this.cmb_ic);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_sup);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "item";
            this.Text = "Item Manager";
            this.Load += new System.EventHandler(this.item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.ComboBox cmb_sup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmb_ic;
        private System.Windows.Forms.Label lbl_itemCode;
        private System.Windows.Forms.Label itemCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_name1;
        private System.Windows.Forms.TextBox txt_price1;
        private System.Windows.Forms.TextBox txt_q1;
        private System.Windows.Forms.ComboBox cmb_sup1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_order;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_view;
    }
}