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
using System.Data.Entity;

using WindowsFormsApplication9.Classes;

namespace WindowsFormsApplication9
{
    public partial class CustomerOrder : Form
    {
        DataTable dt = new DataTable();

        SqlConnection con;
        public CustomerOrder()
        {
            InitializeComponent();
            addtodg();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m4 = new MainMenu();
            m4.Show();
            Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {


            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("select top 1 CusId from Customer order by CusId desc", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            int itemCode = Convert.ToInt32(rdr[0].ToString());
            lbl_cus.Text = (++itemCode).ToString();
            rdr.Close();





            cmd = new SqlCommand("select top 1 orderId from CusOrderHeader order by orderId desc", con);

            rdr = cmd.ExecuteReader();
            rdr.Read();
            // rdr.Read();
            int orderid = Convert.ToInt32(rdr[0].ToString());
            lbl_order.Text = (++orderid).ToString();
            rdr.Close();

            cmd = new SqlCommand("select  itemCode from Item", con);

            SqlDataAdapter rd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_ic.Items.Add(row.Field<int>(0));
            }


            con.Close();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand sa = new SqlCommand("select * from Item where itemCode='" + cmb_ic.SelectedItem + "' and itemQty>='" + Convert.ToInt32(txt_q.Text) + "'", con);
            SqlDataReader dr = sa.ExecuteReader();

            if (!dr.Read())
            {
                MessageBox.Show("Qty not available");
                con.Close();

                return;
            }

            CusOrderList customerorderlist = new CusOrderList()
            {
                Item = new Item()
                {
                    ItemCode = Convert.ToInt16(dr[0].ToString()),
                    ItemName = dr[1].ToString(),
                    ItemPrice = Convert.ToInt16(dr[2].ToString())

                },
                Orderqty = Convert.ToInt16(txt_q.Text),
                subtotal = Convert.ToInt16(txt_q.Text) * Convert.ToInt16(dr[2].ToString())

            };
            con.Close();
            dt.Rows.Add(customerorderlist.Item.ItemCode, customerorderlist.Item.ItemName, customerorderlist.Item.ItemPrice, customerorderlist.Orderqty, customerorderlist.subtotal);
            dataGridView1.DataSource = dt;

        }


        public void addtodg()

        {


            dt.Columns.Add("item Code", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Subtotal", typeof(double));

            dataGridView1.DataSource = dt;



        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_po_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_tele.Text) || string.IsNullOrEmpty(txt_a1.Text) || string.IsNullOrEmpty(txt_A2.Text) || string.IsNullOrEmpty(txt_q.Text) || dataGridView1.Rows.Count==0 || cmb_ic.SelectedValue==null)
            {


                MessageBox.Show("fields cannot be blank");
                return;
            }
            CusOrder a = new CusOrder()
            {
                cusName = txt_name.Text,
                cusTel = txt_tele.Text,
                cusAdd1 = txt_a1.Text,
                cusAdd2 = txt_A2.Text,
                cusAdd3 = txt_A3.Text
            };

            var expirydate = dateTimePicker1.Value;
            a.oderMenu(a,lbl_cus.Text, expirydate,dataGridView1,lbl_order.Text);
            MessageBox.Show("Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Dispose();
            CustomerOrder c = new CustomerOrder();
            c.Show();
            Dispose();
            Refresh();
            
        }

        private void btn_vo_Click(object sender, EventArgs e)
        {
            CusOrder b = new CusOrder()
            {
                orderNumber = Convert.ToInt32(txt_eon.Text)

            };
            var dt = b.viewOrder(b);
            dataGridView1.DataSource = dt;
        }

        private void btn_co_Click(object sender, EventArgs e)
        {
            CusOrderList c = new CusOrderList()
            {
                cusOrder = new CusOrder
                {
                    orderNumber = Convert.ToInt32(txt_on.Text)
                },


                orderNumber = Convert.ToInt32(txt_on.Text)

            };

            c.cancelOrder(c.cusOrder.orderNumber);
            MessageBox.Show("Successfully deleted");

        }
    }
}
