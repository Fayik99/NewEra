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
    public partial class ProprietorReg : Form
    {
        SqlConnection con;

        public ProprietorReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu l = new MainMenu();
            l.Show();
            Hide();
        }

        private void ProprietorReg_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
             con = new SqlConnection(conString);


            SqlCommand cmd = new SqlCommand("select top 1 ProprietorId from Proprietor order by ProprietorId desc", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            int propid = Convert.ToInt32(rdr[0].ToString());
            propid++;
            lbl_id.Text =  propid.ToString();
            rdr.Close();
            con.Close();

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_name.Text)|| string.IsNullOrEmpty(txt_uname.Text)|| string.IsNullOrEmpty(txt_pass.Text))
            {

                MessageBox.Show("fill the fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }
            else
            {
                con.Open();
                SqlCommand fg = new SqlCommand("insert into Proprietor values('"+txt_name.Text+"','"+txt_uname.Text+"','"+txt_pass.Text+"')",con);
                fg.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registered Successfully","proprietor register",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ProprietorReg tr = new ProprietorReg();
                tr.Show();


            }
        }
    }
}
