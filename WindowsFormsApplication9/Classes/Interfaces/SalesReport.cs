using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{     
    public partial class SalesReport : Form
    {
        SqlConnection con;
        public SalesReport()
        {
            InitializeComponent();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            reports r1 = new reports();
            r1.Show();
            Hide();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {


            this.invoiceDetailTableAdapter.Fill(this.NewEraDBDataSet.invoiceDetail,dateTimePicker1.Value,dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();


            //  con.Open();
            //  SqlCommand cmd = new SqlCommand("select itemCode,itemName,sellPrice,Qty,subTotal from [NewEraDB].[dbo].[invoiceHeader] ih inner join[NewEraDB].[dbo].[invoiceDetail] id on ih.invNo = id.InvNm  where ih.[date] >='" + dateTimePicker1.Value + "' and ih.[date] <='" + dateTimePicker2.Value + "' ", con);
            //  SqlDataAdapter da = new SqlDataAdapter(cmd);
            //  DataTable dt = new DataTable();
            //  da.Fill(dt);

            //dataGridView1.DataSource = dt;
            //  con.Close();                       

        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.Item' table. You can move, or remove it, as needed.
            this.ItemTableAdapter.Fill(this.ReportDS.Item);
            // TODO: This line of code loads data into the 'NewEraDBDataSet.invoiceDetail' table. You can move, or remove it, as needed.

        }

        private void btn_prnt_Click(object sender, EventArgs e)
        {
          
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
