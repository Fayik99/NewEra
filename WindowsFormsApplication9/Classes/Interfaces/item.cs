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
    public partial class item : Form
    {
        

        public item()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m2 = new MainMenu();
            m2.Show();
            Hide();
        }

        private void cmb_sup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void item_Load(object sender, EventArgs e)
        {
            
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("select top 1 supID from Supplier order by supID desc", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            int supId = Convert.ToInt32(rdr[0].ToString());
            rdr.Close();


            cmd = new SqlCommand("select  supID from Supplier", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_sup.Items.Add(row.Field<int>(0));
            }

            foreach (DataRow row in dt.Rows)
            {
                cmb_sup1.Items.Add(row.Field<int>(0));
            }






            cmd = new SqlCommand("select top 1 itemCode from Item order by itemCode desc", con);
            
             rdr = cmd.ExecuteReader();

            rdr.Read();
            int itemCode = Convert.ToInt32(rdr[0].ToString());
            lbl_itemCode.Text = (++itemCode).ToString();
            rdr.Close();


            cmd = new SqlCommand("select  itemCode from Item", con);
             ad = new SqlDataAdapter(cmd);
             dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_ic.Items.Add(row.Field<int>(0));
            }



            con.Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(txt_q.Text) || cmb_sup.SelectedIndex <0)
            {
                MessageBox.Show("Field cannot be blank");
                return;
            }
            else
            {
                Item a = new Item()
                {

                    ItemName = txt_name.Text,
                    ItemPrice = Convert.ToDouble(txt_price.Text),
                    ItemQuantity = Convert.ToInt32(txt_q.Text),
                    supId = Convert.ToInt32(cmb_sup.SelectedItem)

                };

                a.addItm(a);
                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            
            
        }
       

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name1.Text) || string.IsNullOrEmpty(txt_price1.Text) || string.IsNullOrEmpty(txt_q1.Text) || cmb_sup1.SelectedIndex <0)
            {

                MessageBox.Show("Fields cannot be blank");
                return;
            }
            else 
            {
                Item b = new Item()
                {
                    ItemCode = Convert.ToInt32(cmb_ic.SelectedItem),
                    ItemName = txt_name1.Text,
                    ItemPrice = Convert.ToDouble(txt_price1.Text),
                    ItemQuantity = Convert.ToInt32(txt_q1.Text),
                    supId = Convert.ToInt32(cmb_sup1.SelectedItem)

                };

                b.updateItem(b);
                MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (cmb_ic.SelectedIndex <0)
            {

                MessageBox.Show("select a item");
            }
            else
            {
                Item d = new Item()
                {
                    ItemCode = (int)cmb_ic.SelectedItem
                };
                d.deleteItem(d);
                MessageBox.Show("Successfully deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void itemCode_Click(object sender, EventArgs e)
        {

        }
    }
}