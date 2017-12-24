namespace WindowsFormsApplication9
{
    partial class RecordSupplyOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordSupplyOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_on = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_sid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_in = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_sub = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_gross = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_logprop = new System.Windows.Forms.Label();
            this.dataOrg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(395, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record supplier order";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(256, 70);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(35, 15);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "date";
            // 
            // lbl_on
            // 
            this.lbl_on.AutoSize = true;
            this.lbl_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_on.Location = new System.Drawing.Point(345, 114);
            this.lbl_on.Name = "lbl_on";
            this.lbl_on.Size = new System.Drawing.Size(19, 15);
            this.lbl_on.TabIndex = 2;
            this.lbl_on.Text = "lb\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = " supplier_id";
            // 
            // cmb_sid
            // 
            this.cmb_sid.FormattingEnabled = true;
            this.cmb_sid.Location = new System.Drawing.Point(348, 170);
            this.cmb_sid.Name = "cmb_sid";
            this.cmb_sid.Size = new System.Drawing.Size(121, 21);
            this.cmb_sid.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "item name";
            // 
            // cmb_in
            // 
            this.cmb_in.FormattingEnabled = true;
            this.cmb_in.Location = new System.Drawing.Point(348, 241);
            this.cmb_in.Name = "cmb_in";
            this.cmb_in.Size = new System.Drawing.Size(121, 21);
            this.cmb_in.TabIndex = 7;
            this.cmb_in.SelectedIndexChanged += new System.EventHandler(this.cmb_in_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "quantity";
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(623, 243);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(98, 20);
            this.txt_q.TabIndex = 9;
            this.txt_q.TextChanged += new System.EventHandler(this.txt_q_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(760, 237);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 29);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(228, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 105);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "update";
            this.Column1.Name = "Column1";
            // 
            // btn_sub
            // 
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(857, 352);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(79, 30);
            this.btn_sub.TabIndex = 12;
            this.btn_sub.Text = "submit";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gross total       ";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(12, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 42);
            this.btn_back.TabIndex = 14;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "order number";
            // 
            // lbl_gross
            // 
            this.lbl_gross.AutoSize = true;
            this.lbl_gross.Location = new System.Drawing.Point(661, 460);
            this.lbl_gross.Name = "lbl_gross";
            this.lbl_gross.Size = new System.Drawing.Size(35, 13);
            this.lbl_gross.TabIndex = 18;
            this.lbl_gross.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(757, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Proprietor_Id";
            // 
            // lbl_logprop
            // 
            this.lbl_logprop.AutoSize = true;
            this.lbl_logprop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logprop.Location = new System.Drawing.Point(898, 70);
            this.lbl_logprop.Name = "lbl_logprop";
            this.lbl_logprop.Size = new System.Drawing.Size(51, 16);
            this.lbl_logprop.TabIndex = 20;
            this.lbl_logprop.Text = "label4";
            // 
            // dataOrg
            // 
            this.dataOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrg.Location = new System.Drawing.Point(213, 307);
            this.dataOrg.Name = "dataOrg";
            this.dataOrg.Size = new System.Drawing.Size(616, 117);
            this.dataOrg.TabIndex = 15;
            this.dataOrg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOrg_CellContentClick);
            // 
            // RecordSupplyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 607);
            this.Controls.Add(this.lbl_logprop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_gross);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataOrg);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_q);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_in);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_sid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_on);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label1);
            this.Name = "RecordSupplyOrder";
            this.Text = "Record Supplier order";
            this.Load += new System.EventHandler(this.RecordSupplyOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_on;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_sid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_gross;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_logprop;
        private System.Windows.Forms.DataGridView dataOrg;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}