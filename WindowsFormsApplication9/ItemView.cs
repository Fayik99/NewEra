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
    public partial class ItemView : Form
    {
        SqlConnection con;
        public ItemView()
        {
            InitializeComponent();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //item bv = new item();
            //bv.Show();
            //Hide();
            this.Close();
        }

        private void ItemView_Load(object sender, EventArgs e)
        {
            SqlCommand fv = new SqlCommand("select * from Item ", con);
            SqlDataAdapter dr = new SqlDataAdapter(fv);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
