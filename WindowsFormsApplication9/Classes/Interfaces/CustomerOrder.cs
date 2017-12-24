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

        int quan = 0;
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

            cmd = new SqlCommand("select  itemName from Item", con);

            SqlDataAdapter rd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            rd.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_ic.Items.Add(row.Field<string>(0));
            }

            cmd = new SqlCommand("select CusId  from Customer", con);

            rd = new SqlDataAdapter(cmd);
            dt = new DataTable();
            rd.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_ci.Items.Add(row.Field<int>(0));
            }
            con.Close();

        }
        int flag = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {


            if (cmb_ic.SelectedIndex < 0 || !txt_q.Text.Any(char.IsDigit))
            {

                MessageBox.Show("Field cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDouble(txt_q.Text) <= 0)
            {


                MessageBox.Show("Quantity cannot be a negative value", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            else
            {

                if (dataGridView1.Rows.Count != 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        btn_add.Enabled = true;
                        if (row.Cells[2].Value != null)
                        {
                            var id = row.Cells[2].Value.ToString();
                            if (id.Equals(cmb_ic.SelectedItem.ToString()))
                            {
                                MessageBox.Show("You can edit you Quantity for same item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btn_add.Enabled = false;
                                return;

                            }
                        }

                    }

                }

                flag = 1;
                con.Open();
                SqlCommand sa = new SqlCommand("select * from Item where itemName='" + cmb_ic.SelectedItem + "' and itemQty>='" + Convert.ToInt32(txt_q.Text) + "'", con);
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
                dataGridView1.Refresh();








            }
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

            if (dataGridView1.Rows.Count != 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[2].Value != null)
                    {
                        var id = row.Cells[2].Value.ToString();

                        if (id.Equals(cmb_ic.SelectedItem.ToString()))
                        {

                            quan = (Convert.ToInt32(row.Cells[4].Value) * Convert.ToInt32(row.Cells[3].Value));
                            row.Cells[5].Value = this.quan;


                        }

                    }
                }


            }
        }

        private void btn_po_Click(object sender, EventArgs e)
        {
            if (!txt_q.Text.Any(char.IsDigit) || dataGridView1.Rows.Count == 0 || cmb_ic.SelectedIndex < 0 || cmb_ci.SelectedIndex < 0)
            {
                MessageBox.Show("fields cannot be blank or invalid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (flag == 0)
            {

                MessageBox.Show("Please add items", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                CusOrder a = new CusOrder()
                {
                    //cusName = txt_name.Text,
                    //cusTel = txt_tele.Text,
                    //cusAdd1 = txt_a1.Text,
                    //cusAdd2 = txt_A2.Text,
                    //cusAdd3 = txt_A3.Text,
                    orderExpireDate = dateTimePicker1.Value
                };

                a.oderMenu(a, cmb_ci.SelectedItem.ToString(), dataGridView1, lbl_order.Text);

                MessageBox.Show("Successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Dispose();
                CustomerOrder c = new CustomerOrder();
                c.Show();
                Dispose();
                Refresh();
            }
        }

        private void btn_vo_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_eon.Text))
            //{
            //    MessageBox.Show("Enter Order number");


            //}
            //else   

            {

                CusOrder b = new CusOrder();

                //  orderNumber = Convert.ToInt32(txt_eon.Text)


                var dat = b.viewOrder();
                dataGridView1.DataSource = dat;
                txt_q.Clear();
            }
        }
        private void btn_co_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_on.Text) || !txt_on.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Enter Order number");


            }
            else
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
                MessageBox.Show("Successfully deleted","informarion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                SqlCommand ds = new SqlCommand("select * from CusOrderDetail", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(ds);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
         


            if (txt_name.Text.Any(char.IsDigit) || string.IsNullOrEmpty(txt_a1.Text) || string.IsNullOrEmpty(txt_A2.Text) || string.IsNullOrEmpty(txt_A3.Text) || !txt_tele.MaskFull)
            {
                MessageBox.Show("Field cannot be blank or invalid format","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;

            }


            string id = txt_name.Text;
            con.Open();
           SqlCommand  cmd = new SqlCommand("select * from Customer where CusName='" + id + "'", con);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                if (id.Equals(rdr[1].ToString()))
                {

                    MessageBox.Show("Entered name is already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();


                }


            }


            else
            {

                rdr.Close();
                SqlCommand cm = new SqlCommand("insert into Customer values('" + txt_name.Text + "','" + txt_tele.Text + "','" + txt_a1.Text + "','" + txt_A2.Text + "','" + txt_A3.Text + "')", con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                MessageBox.Show("Registered Successfully","information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                CustomerOrder cd = new CustomerOrder();
                Hide();
                cd.Show();

                txt_name.Clear();
                txt_tele.Clear();
                txt_a1.Clear();
                txt_A2.Clear();
                txt_A3.Clear();

                cmb_ci.Items.Clear();

                 cmd = new SqlCommand("select CusId  from Customer", con);

                SqlDataAdapter rd = new SqlDataAdapter(cmd);
                dt = new DataTable();
                rd.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cmb_ci.Items.Add(row.Field<int>(0));
                }

            }
        }

        private void cmb_ic_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {


            dataGridView1.DataSource = "";
            if (dt.Rows.Count > 0)
                dt.Clear();
            // dt.Reset();
            // addtodg();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text.Any(char.IsDigit))
            {
                MessageBox.Show("you can't enter numbers here", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txt_q_TextChanged(object sender, EventArgs e)
        {
            //if (!txt_q.Text.Any(char.IsDigit))
            //{

            //    MessageBox.Show("Enter only numbers", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        //private void btn_load_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cma = new SqlCommand("select CusId  from Customer", con);

        //    SqlDataAdapter rd = new SqlDataAdapter(cma);
        //    dt = new DataTable();
        //    rd.Fill(dt);
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        cmb_ci.Items.Add(row.Field<int>(0));

        //    }
        //}
    }
}
