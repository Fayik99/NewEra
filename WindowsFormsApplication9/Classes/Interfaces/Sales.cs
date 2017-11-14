﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication9
{
    public partial class Sales : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        int itemcode = 0;
       
        public Sales()
        {
            InitializeComponent();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
            dataGridView2.Visible = false;
            label5.Text = "0";
            lbl_grossTotal.Text = "0";
            fill();
        }

        internal void fill()
        {
            con.Open();
             cmd = new SqlCommand("select * from invoiceHeader", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            int b = dataGridView2.Rows.Count - 2;
            int a = Convert.ToInt32(dataGridView2.Rows[b].Cells[0].Value) + 1;
            lbl_invoiceNumber.Text = a.ToString();
            lbl_Invoicedate.Text = DateTime.Today.Date.ToString("dd/MM/yy");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m1 = new MainMenu();
            m1.Show();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            invoice ink = new invoice();
            ink.Show();
            Hide();
        }

        private void txt_subtot_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        int place = 0;
        int flag = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_item.SelectedIndex < 0 || string.IsNullOrEmpty(txt_q.Text) || cmb_oi.SelectedIndex<0 || cmb_order.SelectedIndex<0)
                {

                    MessageBox.Show("Fields cannot be blank", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    flag = 1;
                    con.Open();
                    SqlCommand sa = new SqlCommand("select * from Item where itemName='" + cmb_item.SelectedItem + "' and itemQty>='" + Convert.ToInt32(txt_q.Text) + "'", con);
                    SqlDataReader dr = sa.ExecuteReader();


                    if (!dr.Read())
                    {
                        MessageBox.Show("Quantity not available", "Items out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();

                        return;
                    }
                    con.Close();

                    lbl_grossTotal.Text = (Convert.ToInt32(label5.Text) + Convert.ToInt32(lbl_grossTotal.Text)).ToString();
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[place].Cells[3].Value = txt_q.Text;
                    dataGridView1.Rows[place].Cells[2].Value = txt_sell.Text;
                    dataGridView1.Rows[place].Cells[1].Value = lbl_in.Text;
                    dataGridView1.Rows[place].Cells[4].Value = label5.Text;
                    dataGridView1.Rows[place].Cells[0].Value = itemcode;
                    place++;
                    label5.Text = "0";
                    txt_q.Text = "";
                    cmb_item.Items.Clear();
                   
                }
            }
            catch
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (cmb_Code.SelectedIndex<0  || string.IsNullOrEmpty(txt_sell.Text)|| cmb_order.SelectedIndex<0 || cmb_oi.SelectedIndex<0)
            {

                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(flag==0)
            {

                MessageBox.Show("Please add Items","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                DateTime datte = Convert.ToDateTime(DateTime.Now.Date.ToString());

                cmd = new SqlCommand("insert into invoiceHeader values('" + Convert.ToInt32(lbl_invoiceNumber.Text) + "','" + cmb_order.SelectedItem + "','" + cmb_oi.SelectedItem + "',CONVERT(DATETIME,'" + datte.ToShortDateString() + "',103),'" + Convert.ToInt32(lbl_grossTotal.Text) + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {

                        con.Open();
                        cmd = new SqlCommand("insert into invoiceDetail values('" + Convert.ToInt32(lbl_invoiceNumber.Text) + "','" + row.Cells["ItmName"].Value.ToString() + "','" + Convert.ToInt32(row.Cells["SellPrice"].Value.ToString()) + "','" + Convert.ToInt32(row.Cells["Quantity"].Value.ToString()) + "' ,'" + Convert.ToInt16(row.Cells["Column1"].Value.ToString()) + "','" + Convert.ToInt32(row.Cells["itm"].Value.ToString()) + "' )", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    catch (Exception)

                    {
                        // MessageBox.Show(ex.ToString());
                        //MessageBox.Show("Sale Recorded Successfully");
                        con.Close();
                        //Sales re = new Sales();
                        //re.Show();



                    }
                }
                con.Open();
                SqlCommand vb = new SqlCommand("update CusOrderHeader set status=1 where CusId='"+cmb_oi.SelectedItem+"'",con);
                vb.ExecuteNonQuery();
                con.Close();
                  


                //con.Open();
                //SqlCommand cf = new SqlCommand("delete from CusOrderHeader where CusId='"+cmb_oi.SelectedItem+"'",con);
                //cf.ExecuteNonQuery();
                //con.Close();

                {

                    foreach (DataGridViewRow drow in dataGridView1.Rows)
                    {
                        try
                        {
                            con.Open();
                            cmd = new SqlCommand("select itemQty from Item where itemCode='" + Convert.ToInt32(drow.Cells["itm"].Value.ToString()) + "'", con);


                            SqlDataReader rdr = cmd.ExecuteReader();
                            rdr.Read();
                            int temp = Convert.ToInt32(rdr[0].ToString());
                            rdr.Close();
                            int temp1 = temp - Convert.ToInt32(drow.Cells["Quantity"].Value.ToString());
                            cmd = new SqlCommand("update Item set itemQty='" + temp1.ToString() + "' where itemCode='" + Convert.ToInt32(drow.Cells["itm"].Value.ToString()) + "'", con);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception)

                        {
                            //  MessageBox.Show(exs.ToString());

                            MessageBox.Show("Sale Recorded Successfully", "Sales information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            Sales re = new Sales();
                            re.Show();
                            Dispose();
                            //return;

                        }
                    }
                }




                //fill();
            }
            
        }

        private void itmcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "0";
            lbl_in.Text = cmb_item.SelectedItem.ToString();
            cmd = new SqlCommand("select itemCode from Item where itemName='" + lbl_in.Text + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            itemcode = Convert.ToInt32(rdr[0].ToString());
            rdr.Close();
            con.Close();
            if (lbl_in.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select * from Item where itemName='" + lbl_in.Text + "'", con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
                txt_sell.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select  itemName from Item ", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            string itemName = (rdr[0].ToString());
            rdr.Close();


            //cmd = new SqlCommand("select  itemName,itemCode from Item", con);
            //SqlDataAdapter ad = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    cmb_item.Items.Add(row.Field<string>(0));
            //}

            con.Close();

            cmd = new SqlCommand("select  CusId from  Customer", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_oi.Items.Add(row.Field<int>(0));


            }
            con.Close();

            cmd = new SqlCommand("select  itemCode from  Item", con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_Code.Items.Add(row.Field<int>(0));


            }

            con.Close();

           

       


        }
       


       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_q_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_q.Text))
            {
                label5.Text = (Convert.ToInt16(txt_q.Text) * Convert.ToInt32(txt_sell.Text)).ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow drow in dataGridView1.Rows)
            //{

            //    con.Open();
            //    int no1 = Convert.ToInt32(cmb_1.SelectedItem.ToString());

            //   SqlCommand cmd = new SqlCommand("select itemCode from CusOrderDetail where OrderNumber='" + no1 + "'", con);

            //    SqlDataAdapter ad = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    ad.Fill(dt);

            //    con.Close();
               

            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(cmb_oi.SelectedItem.ToString());
            SqlCommand cd = new SqlCommand("select orderId from CusOrderHeader where CusId='"+no+"'",con);
            con.Open();
            SqlDataAdapter de = new SqlDataAdapter(cd);
            DataTable ds = new DataTable();
            de.Fill(ds);
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand rd = new SqlCommand("select * from CusOrderDetail where orderNumber='" + cmb_order.SelectedItem + "' ", con);
            SqlDataAdapter df = new SqlDataAdapter(rd);
            DataTable dt = new DataTable();
            df.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_orders_Click(object sender, EventArgs e)
        {

        }

        private void cmb_oi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_order.Items.Clear();

            //            SqlCommand sd = new SqlCommand("select orderId from CusOrderHeader where CusId='"+cmb_oi.SelectedItem+"'",con);
            cmd = new SqlCommand("select  orderId from CusOrderHeader where CusId='"+cmb_oi.SelectedItem+"' and status=0 ", con);
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

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select itemName from Item where itemCode='"+cmb_Code.SelectedItem+"'",con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_item.Items.Add(row.Field<string>(0));


            }
        }

        private void lbl_in_Click(object sender, EventArgs e)
        {

        }

        private void cmb_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

