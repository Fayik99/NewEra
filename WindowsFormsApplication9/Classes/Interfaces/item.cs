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

        SqlConnection con;
        public item()
        {
            InitializeComponent();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
             con = new SqlConnection(conString);
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
            
           

            SqlCommand cmd = new SqlCommand("select  supID from Supplier order by supID desc", con);
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
                cmb_sup1.Items.Add(row.Field<int>(0));
            }

            cmd = new SqlCommand("select  itemName from Item", con);
             ad = new SqlDataAdapter(cmd);
             dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_Name.Items.Add(row.Field<string>(0));
                
            }




            cmd = new SqlCommand("select top 1 itemCode from Item order by itemCode desc", con);
            
             rdr = cmd.ExecuteReader();

            rdr.Read();
            int itc = Convert.ToInt32(rdr[0].ToString());
            itc++;
            lbl_itemCode.Text =  itc.ToString();
            rdr.Close();
            con.Close();






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
                    ItemCode=Convert.ToInt32(lbl_itemCode.Text)
                    

                };

                a.addItm(a,Convert.ToInt32(cmb_sup.SelectedItem));
                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                item ab = new item();
                ab.Show();
                Dispose();
                
                
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
                    supId=Convert.ToInt32( cmb_sup1.SelectedItem.ToString())
                    
                };

                b.updateItem(b,Convert.ToInt32( cmb_order.SelectedItem));
                MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmb_ic.Items.Clear();
                cmb_ic.ResetText();
                cmb_sup1.Items.Clear();
                cmb_sup1.ResetText();
                //cmb_Name.Items.Clear();
                cmb_order.Items.Clear();
                cmb_order.ResetText();
                txt_name1.Clear();
                txt_price1.Clear();
                txt_q1.Clear();

                SqlCommand cmd = new SqlCommand("select  supID from Supplier", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                   
                    cmb_sup1.Items.Add(row.Field<int>(0));
                }




                cmd = new SqlCommand("select  PurchaseorderID from PurchaseOrderHeaderFile where supID='" + cmb_sup1.SelectedItem + "'", con);
                con.Open();
                 ad = new SqlDataAdapter(cmd);
                con.Close();
                dt = new DataTable();
                ad.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cmb_order.Items.Add(row.Field<int>(0));


                }

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (cmb_Name.SelectedIndex <0)
            {

                MessageBox.Show("select a item");
            }
            else
            {
                Item d = new Item()
                {
                    ItemName = cmb_Name.SelectedItem.ToString()
                };
                d.deleteItem(d);
                MessageBox.Show("Successfully deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void itemCode_Click(object sender, EventArgs e)
        {

        }

        private void cmb_sup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_order.Items.Clear();
            cmb_ic.Items.Clear();

            //            SqlCommand sd = new SqlCommand("select orderId from CusOrderHeader where CusId='"+cmb_oi.SelectedItem+"'",con);
            SqlCommand cmd = new SqlCommand("select  PurchaseorderID from PurchaseOrderHeaderFile where supID='" + cmb_sup1.SelectedItem + "'", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_order.Items.Add(row.Field<int>(0));


            }
        }

        private void cmb_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand("select * from PurchaseOrderDetailFile where PurchaseorderId='"+cmb_order.SelectedItem+"' and status=0 ",con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            

            //            SqlCommand sd = new SqlCommand("select orderId from CusOrderHeader where CusId='"+cmb_oi.SelectedItem+"'",con);
            cmd = new SqlCommand("select  itemCode from PurchaseOrderDetailFile where PurchaseorderId='" + cmb_order.SelectedItem + "' and status=0", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            con.Close();
             dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_ic.Items.Add(row.Field<int>(0));


            }

        }

        private void cmb_ic_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
           SqlCommand cd = new SqlCommand("select itemName,itemPrice from Item where itemCode='"+cmb_ic.SelectedItem+"'",con);
            SqlDataAdapter da = new SqlDataAdapter(cd);
            con.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);

            txt_name1.Text = dt.Rows[0][0].ToString();
            txt_price1.Text = dt.Rows[0][1].ToString();

           
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ItemView mn = new ItemView();
            mn.Show();
            
         

        }
    }
}