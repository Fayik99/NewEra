﻿using System;
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cmb_ic.SelectedIndex < 0 || string.IsNullOrEmpty(txt_q.Text))
            {

                MessageBox.Show("Field cannot be empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
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

        }

        private void btn_po_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_q.Text) || dataGridView1.Rows.Count == 0 || cmb_ic.SelectedIndex < 0)
            {
                MessageBox.Show("fields cannot be blank","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
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

                
                var dt = b.viewOrder();
                dataGridView1.DataSource = dt;
            }
        }
        private void btn_co_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_on.Text))
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
                MessageBox.Show("Successfully deleted");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text) || txt_tele.TextLength!=10 || string.IsNullOrEmpty(txt_a1.Text) || string.IsNullOrEmpty(txt_A2.Text) || string.IsNullOrEmpty(txt_A3.Text))
            {
                MessageBox.Show("Field cannot be blank");

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Customer values('" + txt_name.Text + "','" + txt_tele.Text + "','" + txt_a1.Text + "','" + txt_A2.Text + "','" + txt_A3.Text + "')", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Registered Successfully");
                con.Close();
            }
        }
    }
}
