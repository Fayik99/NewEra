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
    public partial class Quotation : Form
    {
        SqlConnection con;
        DataTable dt = new DataTable();

        public Quotation()
        {
            InitializeComponent();

            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
            addvv();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu m6 = new MainMenu();
            m6.Show();
            Hide();
        }

        private void Quotation_Load(object sender, EventArgs e)
        {

            lbl_currentDate.Text = DateTime.Now.ToString();




            SqlCommand cmd = new SqlCommand("select top 2 itemName from Item order by itemName desc", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            string itemName = (rdr[0].ToString());
            rdr.Close();
            con.Close();

            cmd = new SqlCommand("select top 1 QuotationNumber from QuotationHeaderFile order by QuotationNumber desc", con);
            con.Open();
            rdr = cmd.ExecuteReader();


            rdr.Read();
            int num = Convert.ToInt32(rdr[0].ToString());
            lbl_qn.Text = Convert.ToInt32(++num).ToString();
            rdr.Close();
            con.Close();

            cmd = new SqlCommand("select  itemName from Item", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_in.Items.Add(row.Field<string>(0));
            }

            cmd = new SqlCommand("select  CusId from Customer", con);
            ad = new SqlDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmb_ci1.Items.Add(row.Field<int>(0));


            }

            //cmd = new SqlCommand("select  CusName from Customer", con);
            //ad = new SqlDataAdapter(cmd);
            //dt = new DataTable();
            //ad.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    cmb_cName.Items.Add(row.Field<string>(0));

            //}
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (cmb_in.SelectedItem == null)
            {

                MessageBox.Show("Select an item");
            }
            else
            {

                if (dataGridView1.Rows.Count != 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        btn_add.Enabled = true;
                        if (row.Cells[1].Value != null)
                        {
                            var id = row.Cells[1].Value.ToString();
                            if (id.Equals(cmb_in.SelectedItem.ToString()))
                            {
                                MessageBox.Show("You can't select same item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btn_add.Enabled = false;
                                return;

                            }

                        }

                    }

                }











                con.Open();
                String name = cmb_in.SelectedItem.ToString();
                //Quotations sas = new Quotations();
                //var dr = sas.addQuot(name);
                SqlCommand cmd = new SqlCommand("select itemCode,itemname,itemPrice from Item where ItemName='" + name + "'", con);
                //SqlDataAdapter ad = new SqlDataAdapter(cmd);
                SqlDataReader dr = cmd.ExecuteReader();




                dr.Read();

                Quotations s = new Quotations()
                {
                    Item1 = new Item()
                    {
                        ItemCode = Convert.ToInt16(dr[0].ToString()),
                        ItemName = dr[1].ToString(),
                        ItemPrice = Convert.ToInt16(dr[2].ToString())

                    }

                };
                dr.Close();
                con.Close();

                dt.Rows.Add(s.Item1.ItemCode, s.Item1.ItemName, s.Item1.ItemPrice);
                dataGridView1.DataSource = dt;
            }


        }



        public void addvv()

        {


            dt.Columns.Add("item Code", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(int));


            dataGridView1.DataSource = dt;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (cmb_in.SelectedIndex < 0 || cmb_ci1.SelectedIndex < 0)
            {

                MessageBox.Show("field cannot be empty");

            }

            else
            {
                Quotations abcd = new Quotations()
                {

                    quotationCreateDate = (lbl_currentDate.Text),
                    quotExpDate = dateTimePicker1.Value.ToString()


                };

                con.Open();
                SqlCommand cd = new SqlCommand("select itemCode from Item where itemName='" + cmb_in.SelectedItem + "'", con);
                SqlDataReader dr = cd.ExecuteReader();
                dr.Read();

                Quotations we = new Quotations()
                {

                    Item1 = new Item()
                    {

                        ItemCode = Convert.ToInt32(dr[0].ToString())


                    },


                };


                dr.Close();
                con.Close();



                con.Open();
                SqlCommand cms = new SqlCommand("insert into QuotationHeaderFile values('" + Convert.ToInt32(cmb_ci1.SelectedItem.ToString()) + "','" + abcd.quotationCreateDate + "','" + abcd.quotExpDate + "')", con);

                cms.ExecuteNonQuery();
                con.Close();

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{

                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {

                    int itemCode = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);


                    con.Open();
                    SqlCommand cm = new SqlCommand("insert into QuotationDetailFile values('" + Convert.ToInt32(lbl_qn.Text.ToString()) + "','" + itemCode + "')", con);

                    cm.ExecuteNonQuery();
                    con.Close();


                }


                //  abcd.quotMenu(abcd, Convert.ToInt32(cmb_ci1.SelectedItem.ToString()));

                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Open();
                //cd = new SqlCommand("select itemCode from Item where itemName='" + cmb_in.SelectedItem + "'", con);

                //dr.Read();


                //Quotations we = new Quotations()
                //{

                //    Item1 = new Item()
                //    {

                //        ItemCode = Convert.ToInt32(dr[0].ToString())


                //    },


                //};
                // we.quotMenu1(we, Convert.ToInt32(lbl_qn.Text.ToString()));

                con.Close();
                Quotation sd = new Quotation();
                Hide();
                sd.Show();
            }
        }
        private void btn_serch_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txt_can.Text))
                {
                    MessageBox.Show("insert a correct Quotationnumber");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from QuotationHeaderFile where QuotationNumber='" + txt_can.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (!txt_can.Text.Any(char.IsDigit))

            {

                MessageBox.Show("insert a Quotationumber","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToDouble(txt_can.Text) <= 0)
            {
                MessageBox.Show("number cannot be a negative value","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;

            }
            else
            {
                Quotations wrt = new Quotations()
                {
                    quotNumber = Convert.ToInt32(txt_can.Text)


                };
                wrt.cancelQuot(wrt);
                MessageBox.Show("deleted ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_can.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_ci2_SelectedIndexChanged(object sender, EventArgs e)
        {

            //SqlCommand nm = new SqlCommand("select * from QuotationHeaderFile where CusId='" + cmb_ci2.SelectedItem+"'",con);
            //SqlDataAdapter da = new SqlDataAdapter(nm);
            //con.Close();
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //txt_can.Text = dt.Rows[0][0].ToString();


        }

        private void cmb_cName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    SqlCommand rt = new SqlCommand("select CusId from Customer where CusName='" + cmb_cName.SelectedItem + "'", con);
            //    SqlDataReader dr = rt.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        lbl_cusid.Text = dr.GetInt32(0).ToString();
            //    }

            //    dr.Close();

            //    rt = new SqlCommand("select * from QuotationHeaderFile where CustomerId='" + lbl_cusid.Text + "'", con);
            //    SqlDataAdapter de = new SqlDataAdapter(rt);
            //    DataTable du = new DataTable();
            //    de.Fill(du);

                //txt_can.Text = du.Rows[0][0].ToString();

            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("You have not provided quotation to this customer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //finally
            //{
            //    con.Close();

            //}
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {

        }

        private void cmb_in_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = true;
        }

        private void txt_can_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
