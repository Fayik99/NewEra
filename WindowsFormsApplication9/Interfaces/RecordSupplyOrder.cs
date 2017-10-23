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
    public partial class RecordSupplyOrder : Form
    {
        SqlConnection con;
        public string conString = "";

        public RecordSupplyOrder()
        {
          
            InitializeComponent();
            conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
            

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Supplier s2 = new Supplier();
            s2.Show();
            Hide();
        }

        private void RecordSupplyOrder_Load(object sender, EventArgs e)
        {
            string a= DateTime.Today.ToString("dd-MM-yyyy");
            lbl_date.Text = "Current Date: " + a;



          SqlCommand  cmd = new SqlCommand("select  supID from Supplier", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            
            foreach (DataRow row in dt.Rows)
            {
                cmb_sid.Items.Add(row.Field<int>(0));
            }

            con.Close();

            cmd = new SqlCommand("select top 1 OrderNumber from CusOrderDetail order by OrderNumber desc", con);
            con.Open();
            
            var rdr = cmd.ExecuteReader();


            rdr.Read();
            int quotnum = Convert.ToInt32(rdr[0].ToString());
            lbl_on.Text = "Order Number: " + ++quotnum;
            rdr.Close();
            con.Close();

             cmd = new SqlCommand("select top 2 itemName from Item order by itemName desc", con);
            con.Open();
             rdr = cmd.ExecuteReader();

            rdr.Read();
            string itemName = (rdr[0].ToString());
            rdr.Close();
            

            cmd = new SqlCommand("select  itemName from Item", con);
             ad = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
               cmb_in .Items.Add(row.Field<string>(0));
            }

            con.Close();


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlCommand sa = new SqlCommand("select * from Item where itemname='" + cmb_in.SelectedItem+"' ", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sa);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            



            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("qty not available");
                return;
            }


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Item Code";
            dataGridView1.Columns[0].DataPropertyName = "itemCode";
            dataGridView1.Columns[1].HeaderText = "Item Name";
            dataGridView1.Columns[1].DataPropertyName = "itemName";
            dataGridView1.Columns[2].HeaderText = "Item Quantity";
            dataGridView1.Columns[2].DataPropertyName = "itemQty";
            dataGridView1.Columns[3].HeaderText = "Unit Price";
            dataGridView1.Columns[3].DataPropertyName = "itemPrice";
            dataGridView1.Columns[4].HeaderText = "Sub Total";
            dataGridView1.Columns[4].DataPropertyName = "subTotal";
            dt.Columns.Add(new DataColumn("subTotal"));

            dt.Rows[0]["itemQty"] = txt_q.Text;
            dt.Rows[0]["subTotal"] = Convert.ToDouble(dt.Rows[0]["itemQty"]) * Convert.ToDouble(dt.Rows[0]["itemPrice"]);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
