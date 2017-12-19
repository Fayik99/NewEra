namespace WindowsFormsApplication9
{
    partial class SalesReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReport));
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewEraDBDataSet = new WindowsFormsApplication9.NewEraDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_gen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDS = new WindowsFormsApplication9.ReportDS();
            this.ItemTableAdapter = new WindowsFormsApplication9.ReportDSTableAdapters.ItemTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            this.invoiceDetailTableAdapter = new WindowsFormsApplication9.NewEraDBDataSetTableAdapters.invoiceDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewEraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "invoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.NewEraDBDataSet;
            // 
            // NewEraDBDataSet
            // 
            this.NewEraDBDataSet.DataSetName = "NewEraDBDataSet";
            this.NewEraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "From\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(623, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // btn_gen
            // 
            this.btn_gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gen.Location = new System.Drawing.Point(1056, 392);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(92, 30);
            this.btn_gen.TabIndex = 5;
            this.btn_gen.Text = "Generate";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.invoiceDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication9.Classes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(164, 183);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(875, 530);
            this.reportViewer1.TabIndex = 12;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ItemBindingSource
            // 
            this.ItemBindingSource.DataMember = "Item";
            this.ItemBindingSource.DataSource = this.ReportDS;
            // 
            // ReportDS
            // 
            this.ReportDS.DataSetName = "ReportDS";
            this.ReportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemTableAdapter
            // 
            this.ItemTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(22, 21);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(55, 49);
            this.btn_back.TabIndex = 7;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // invoiceDetailTableAdapter
            // 
            this.invoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 741);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_gen);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalesReport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewEraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private NewEraDBDataSet NewEraDBDataSet;
        private NewEraDBDataSetTableAdapters.invoiceDetailTableAdapter invoiceDetailTableAdapter;
        private System.Windows.Forms.BindingSource ItemBindingSource;
        private ReportDS ReportDS;
        private ReportDSTableAdapters.ItemTableAdapter ItemTableAdapter;
    }
}