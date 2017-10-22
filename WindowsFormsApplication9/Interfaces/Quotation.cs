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
       
        public Quotation()
        {
            InitializeComponent();
        }
       
        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m6 = new MainMenu();
            m6.Show();
            Hide();
        }

        private void Quotation_Load(object sender, EventArgs e)
        {
            string abc= DateTime.Today.ToString("dd-MM-yyyy");
            lbl_currentDate.Text = "Current date: " + abc;

            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select top 2 itemName from Item order by itemName desc", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            string itemName = (rdr[0].ToString());
            rdr.Close();


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
            
            String name = cmb_in.SelectedItem.ToString();
            Quotations sas = new Quotations();
            DataTable dt = sas.addQuot(name);    
            dataGridView1.DataSource = dt;
           
        }

        }
    }

