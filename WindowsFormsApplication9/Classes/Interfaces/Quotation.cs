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
using WindowsFormsApplication9.Classes;

namespace WindowsFormsApplication9
{
    public partial class Quotation : Form
    {
        SqlConnection con;

        public Quotation()
        {
            InitializeComponent();

            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
             con = new SqlConnection(conString);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m6 = new MainMenu();
            m6.Show();
            Hide();
        }

        private void Quotation_Load(object sender, EventArgs e)
        {
            
            lbl_currentDate.Text = DateTime.Now.ToString();

            


            SqlCommand cmd = new SqlCommand("select top 2 itemName from Item order by itemName desc", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            string itemName = (rdr[0].ToString());
            rdr.Close();
            con.Close();

            cmd = new SqlCommand("select top 1 QuotationNumber from QuotationHeaderFile order by QuotationNumber desc", con);
            con.Open();
            rdr = cmd.ExecuteReader();


            rdr.Read();
            int num = Convert.ToInt32(rdr[0].ToString());
            lbl_qn.Text = Convert.ToInt32(++num).ToString();
            rdr.Close();
            con.Close();

            cmd = new SqlCommand("select  itemName from Item", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_in.Items.Add(row.Field<string>(0));
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (cmb_in.SelectedItem == null)
            {

                MessageBox.Show("Select an item");
            }
            else { 

                String name = cmb_in.SelectedItem.ToString();
                Quotations sas = new Quotations();
                DataTable dt = sas.addQuot(name);
                dataGridView1.DataSource = dt;
            }
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {

            Quotations abcd = new Quotations()
            {

                quotationCreateDate = (lbl_currentDate.Text),
                quotExpDate = dateTimePicker1.Value.ToString()


            };
            abcd.quotMenu(abcd);      
        
            MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Open();
            SqlCommand cd = new SqlCommand("select itemCode from Item", con);
            SqlDataReader dr = cd.ExecuteReader();
            dr.Read();
            
            
            Quotations we = new Quotations()
            {

                Item1 = new Item()
                {

                    ItemCode = Convert.ToInt32(dr[0].ToString())


                },
         

            };
           we.quotMenu1(we);
            dr.Close();
            con.Close();
            Quotation sd = new Quotation();
            sd.Show();
           }

        private void btn_serch_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_can.Text))
                {
                    MessageBox.Show("insert a correct Quotationnumber");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from QuotationHeaderFile where QuotationNumber='" + txt_can.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            } 

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_can.Text))
            {

                MessageBox.Show("insert a correct Quotationumber");
            }
            else
            {
                Quotations wrt = new Quotations()
                {
                    quotNumber = Convert.ToInt32(txt_can.Text)


                };
                wrt.cancelQuot(wrt);
                MessageBox.Show("deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    