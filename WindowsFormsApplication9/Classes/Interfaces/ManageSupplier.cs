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
    public partial class ManageSupplier : Form
    {
        public int index = 0; 
        public ManageSupplier()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("select top 1 supID from Supplier order by supID desc", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            int supid = Convert.ToInt32(rdr[0].ToString());
            label2.Text = "Supplier ID: " + ++supid;
            rdr.Close();
            con.Close();


             cmd = new SqlCommand("select  supID from Supplier", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row.Field<int>(0));
            }

            
            
            con.Close();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Supplier s3 = new Supplier();
            s3.Show();
            Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name1.Text) || string.IsNullOrEmpty(txt_mob1.Text) || string.IsNullOrEmpty(txt_add11.Text) || string.IsNullOrEmpty(txt_add21.Text) || string.IsNullOrEmpty(txt_add31.Text))
            {
                MessageBox.Show("One or more fields are empty, please fill", "Add Error");
                return;
            }
            else
            {
                Suppliers suppliers = new Suppliers()
                {

                    supName = txt_name1.Text,
                    supAddress1 = txt_add11.Text,
                    supAddress2 = txt_add21.Text,
                    supAddress3 = txt_add31.Text,
                    supMobile = txt_mob1.Text
                };

                suppliers.addSup(suppliers);

                ManageSupplier refresh = new ManageSupplier();
                Hide();
                refresh.Show();
                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            //SqlConnection con = new SqlConnection(conString);

            int id = comboBox1.SelectedIndex;

            var sa = new Suppliers();
            var dt=sa.viewSup(id);

            updats.Text = comboBox1.SelectedItem.ToString();
            index = Convert.ToInt32(updats.Text);
            updats.Text = index.ToString();
            dataGridView1.DataSource = dt;
            

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name2.Text) || string.IsNullOrEmpty(txt_mob2.Text) || string.IsNullOrEmpty(txt_add12.Text) || string.IsNullOrEmpty(txt_add22.Text) || string.IsNullOrEmpty(txt_add32.Text))
            {
                MessageBox.Show("One or more fields are empty, please fill", "Add Error");
                return;
            }
            else
            {
                Suppliers s = new Suppliers()
                {
                    supId = index,
                    supName = txt_name2.Text,
                    supMobile = txt_mob2.Text,
                    supAddress1 = txt_add12.Text,
                    supAddress2 = txt_add22.Text,
                    supAddress3 = txt_add32.Text


                };
                s.updateSup(s);

                ManageSupplier refresh = new ManageSupplier();
                Hide();
                refresh.Show();
                MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("select a supplier Id");

            }
            else
            {
                Suppliers si = new Suppliers()
                {
                    supId = index


                };
                si.deleteSup(si);

                ManageSupplier refresh = new ManageSupplier();
                Hide();
                refresh.Show();
                MessageBox.Show("Successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
