using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class invoice : Form
    {
        SqlConnection con;
        public invoice()
        {
            InitializeComponent();
           string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }

        private void invoice_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Sales m = new Sales();
            m.Show();
            Hide();
        }

        private void txt_no_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_no.Text) || !txt_no.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Enter Invoice number","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;

            }

            if(Convert.ToDouble(txt_no.Text) <= 0)
            {


                MessageBox.Show("cannot be a negative value", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from invoiceDetail where InvNm='" + txt_no.Text + "'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                lbl_grossTotal.Text = "0";
                cmd = new SqlCommand("select grossTot from invoiceHeader where invNo='" + Convert.ToInt32(txt_no.Text) + "'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                lbl_grossTotal.Text = rdr[0].ToString();
                rdr.Close();

                con.Close();
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
