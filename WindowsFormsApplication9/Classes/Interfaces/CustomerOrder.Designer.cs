﻿namespace WindowsFormsApplication9
{
    partial class CustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cus = new System.Windows.Forms.Label();
            this.lbl_order = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_a1 = new System.Windows.Forms.TextBox();
            this.txt_A2 = new System.Windows.Forms.TextBox();
            this.txt_A3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_ic = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_po = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_on = new System.Windows.Forms.TextBox();
            this.btn_co = new System.Windows.Forms.Button();
            this.btn_vo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.cmb_ci = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expiry date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 21);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order ID";
            // 
            // lbl_cus
            // 
            this.lbl_cus.AutoSize = true;
            this.lbl_cus.Location = new System.Drawing.Point(276, 160);
            this.lbl_cus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cus.Name = "lbl_cus";
            this.lbl_cus.Size = new System.Drawing.Size(47, 15);
            this.lbl_cus.TabIndex = 4;
            this.lbl_cus.Text = "label4";
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Location = new System.Drawing.Point(675, 150);
            this.lbl_order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(47, 15);
            this.lbl_order.TabIndex = 5;
            this.lbl_order.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Address1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Address2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Address3";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(100, 49);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 21);
            this.txt_name.TabIndex = 11;
            // 
            // txt_tele
            // 
            this.txt_tele.Location = new System.Drawing.Point(100, 93);
            this.txt_tele.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(132, 21);
            this.txt_tele.TabIndex = 12;
            // 
            // txt_a1
            // 
            this.txt_a1.Location = new System.Drawing.Point(100, 137);
            this.txt_a1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a1.Name = "txt_a1";
            this.txt_a1.Size = new System.Drawing.Size(132, 21);
            this.txt_a1.TabIndex = 13;
            // 
            // txt_A2
            // 
            this.txt_A2.Location = new System.Drawing.Point(100, 180);
            this.txt_A2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A2.Name = "txt_A2";
            this.txt_A2.Size = new System.Drawing.Size(132, 21);
            this.txt_A2.TabIndex = 14;
            // 
            // txt_A3
            // 
            this.txt_A3.Location = new System.Drawing.Point(100, 224);
            this.txt_A3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_A3.Name = "txt_A3";
            this.txt_A3.Size = new System.Drawing.Size(132, 21);
            this.txt_A3.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 215);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "item name";
            // 
            // cmb_ic
            // 
            this.cmb_ic.FormattingEnabled = true;
            this.cmb_ic.Location = new System.Drawing.Point(647, 211);
            this.cmb_ic.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_ic.Name = "cmb_ic";
            this.cmb_ic.Size = new System.Drawing.Size(160, 23);
            this.cmb_ic.TabIndex = 17;
            this.cmb_ic.SelectedIndexChanged += new System.EventHandler(this.cmb_ic_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(880, 210);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "quantity";
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(947, 212);
            this.txt_q.Margin = new System.Windows.Forms.Padding(4);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(132, 21);
            this.txt_q.TabIndex = 19;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1116, 208);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 26);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 266);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 173);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_po
            // 
            this.btn_po.Location = new System.Drawing.Point(804, 456);
            this.btn_po.Margin = new System.Windows.Forms.Padding(4);
            this.btn_po.Name = "btn_po";
            this.btn_po.Size = new System.Drawing.Size(100, 26);
            this.btn_po.TabIndex = 22;
            this.btn_po.Text = "Place Order";
            this.btn_po.UseVisualStyleBackColor = true;
            this.btn_po.Click += new System.EventHandler(this.btn_po_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(666, 566);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Order number";
            // 
            // txt_on
            // 
            this.txt_on.Location = new System.Drawing.Point(805, 563);
            this.txt_on.Margin = new System.Windows.Forms.Padding(4);
            this.txt_on.Name = "txt_on";
            this.txt_on.Size = new System.Drawing.Size(132, 21);
            this.txt_on.TabIndex = 24;
            // 
            // btn_co
            // 
            this.btn_co.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_co.Location = new System.Drawing.Point(958, 557);
            this.btn_co.Margin = new System.Windows.Forms.Padding(4);
            this.btn_co.Name = "btn_co";
            this.btn_co.Size = new System.Drawing.Size(100, 26);
            this.btn_co.TabIndex = 25;
            this.btn_co.Text = "cancel order";
            this.btn_co.UseVisualStyleBackColor = true;
            this.btn_co.Click += new System.EventHandler(this.btn_co_Click);
            // 
            // btn_vo
            // 
            this.btn_vo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vo.Location = new System.Drawing.Point(804, 499);
            this.btn_vo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_vo.Name = "btn_vo";
            this.btn_vo.Size = new System.Drawing.Size(100, 26);
            this.btn_vo.TabIndex = 28;
            this.btn_vo.Text = "view order";
            this.btn_vo.UseVisualStyleBackColor = true;
            this.btn_vo.Click += new System.EventHandler(this.btn_vo_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(470, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(292, 29);
            this.label15.TabIndex = 29;
            this.label15.Text = "Record Customer Order";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btn_Reg
            // 
            this.btn_Reg.Location = new System.Drawing.Point(118, 268);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(81, 32);
            this.btn_Reg.TabIndex = 31;
            this.btn_Reg.Text = "Register";
            this.btn_Reg.UseVisualStyleBackColor = true;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(532, 124);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(86, 15);
            this.l.TabIndex = 32;
            this.l.Text = "Customer ID";
            // 
            // cmb_ci
            // 
            this.cmb_ci.FormattingEnabled = true;
            this.cmb_ci.Location = new System.Drawing.Point(678, 116);
            this.cmb_ci.Name = "cmb_ci";
            this.cmb_ci.Size = new System.Drawing.Size(121, 23);
            this.cmb_ci.TabIndex = 33;
            this.cmb_ci.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(37, 26);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(73, 51);
            this.btn_back.TabIndex = 30;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_Reg);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_tele);
            this.groupBox1.Controls.Add(this.txt_a1);
            this.groupBox1.Controls.Add(this.txt_A2);
            this.groupBox1.Controls.Add(this.txt_A3);
            this.groupBox1.Location = new System.Drawing.Point(91, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 317);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Register";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(1076, 476);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 35;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 695);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_ci);
            this.Controls.Add(this.l);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_vo);
            this.Controls.Add(this.btn_co);
            this.Controls.Add(this.txt_on);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_po);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_ic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_order);
            this.Controls.Add(this.lbl_cus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerOrder";
            this.Text = "Customer Order";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_cus;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_a1;
        private System.Windows.Forms.TextBox txt_A2;
        private System.Windows.Forms.TextBox txt_A3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_ic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_po;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_on;
        private System.Windows.Forms.Button btn_co;
        private System.Windows.Forms.Button btn_vo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ComboBox cmb_ci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
    }
}