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
        DataTable dt = new DataTable();
        SqlConnection con;

        public string conString = "";

        public RecordSupplyOrder()
        {
            InitializeComponent();
            lbl_gross.Text = "0";

            addvc();
            dataOrg.Visible = false;
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
            string a = DateTime.Today.ToString("dd-MM-yyyy");
            lbl_date.Text = "Current Date: " + a;
            con.Open();
            string id = LoginForm.LoginInfo.logged.ToString();
            SqlCommand vn = new SqlCommand("select ProprietorId from Proprietor where ProprietorUserName='" + id + "'", con);
            SqlDataReader rd = vn.ExecuteReader();

            while (rd.Read())
            {
                lbl_logprop.Text = rd.GetInt32(0).ToString();


            }

            con.Close();

            SqlCommand cmd = new SqlCommand("select  supID from Supplier", con);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cmb_sid.Items.Add(row.Field<int>(0));
            }

            con.Close();

            cmd = new SqlCommand("select top 1 PurchaseOrderId from PurchaseOrderDetailFile order by PurchaseOrderId desc", con);
            con.Open();

            var rdr = cmd.ExecuteReader();



            int num = 0;
            if (rdr.Read())
            {
                num = Convert.ToInt32(rdr[0].ToString());
            }
            lbl_on.Text = Convert.ToInt32(++num).ToString();
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
                cmb_in.Items.Add(row.Field<string>(0));
            }

            con.Close();


        }
        int result = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_q.Text) || cmb_in.SelectedIndex < 0 || cmb_sid.SelectedIndex<0)
            {

                MessageBox.Show("field cannot be blank", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                result = 1;
                con.Open();
                SqlCommand sa = new SqlCommand("select * from Item where itemName ='" + cmb_in.SelectedItem + "'", con);

                SqlDataReader dr = sa.ExecuteReader();
                dr.Read();
                //if (!dr.Read())
                //{
                //    MessageBox.Show("Qty not available");
                //    con.Close();

                //    return;
                //}

                PurchaseOrder purchaseorderlist = new PurchaseOrder()
                {
                    Item = new Item()
                    {
                        ItemCode = Convert.ToInt16(dr[0].ToString()),
                        ItemName = dr[1].ToString(),
                        ItemPrice = Convert.ToInt16(dr[2].ToString())

                    },
                    qty = Convert.ToInt16(txt_q.Text),
                    grosstotal = Convert.ToInt16(txt_q.Text) * Convert.ToInt16(dr[2].ToString())

                };
                con.Close();
                lbl_gross.Text = (Convert.ToInt32(lbl_gross.Text) + purchaseorderlist.grosstotal).ToString();
                dt.Rows.Add(purchaseorderlist.Item.ItemCode, purchaseorderlist.Item.ItemName, purchaseorderlist.Item.ItemPrice, purchaseorderlist.qty, purchaseorderlist.grosstotal);
                dataGridView1.DataSource = dt;

            }


        }


        public void addvc()

        {


            dt.Columns.Add("item Code", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(int));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Subtotal", typeof(double));

            dataGridView1.DataSource = dt;



        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (cmb_sid.SelectedIndex < 0 || cmb_in.SelectedIndex < 0 || string.IsNullOrEmpty(txt_q.Text)|| dataGridView1.Rows.Count==0 )
            {

                MessageBox.Show("Fields cannot be blank", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else if(result==0)
            {

                MessageBox.Show("please add items");
            }
            else
            {
                PurchaseOrder ad = new PurchaseOrder()
                {
                    supplier = new Suppliers()
                    {
                        supId = Convert.ToInt32(cmb_sid.SelectedItem)
                    },
                };
                ad.orderId = Convert.ToInt32(lbl_on.Text);
                ad.grosstotal = Convert.ToInt32(lbl_gross.Text);
                ad.getQua(dataOrg);

                ad.sAddOrder(dataGridView1, dataOrg, ad, Convert.ToInt32(lbl_logprop.Text));
                RecordSupplyOrder sb = new RecordSupplyOrder();
                this.Hide();
                sb.Show();
                

            }
        }

        private void cmb_in_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lbl_code_Click(object sender, EventArgs e)
        {

        }





        //SqlCommand sa = new SqlCommand("select * from Item where itemname='" + cmb_in.SelectedItem+"' ", con);
        //con.Open();
        //SqlDataAdapter da = new SqlDataAdapter(sa);
        //DataTable dt = new DataTable();
        //con.Close();
        //da.Fill(dt);




        //if (dt.Rows.Count == 0)
        //{
        //    MessageBox.Show("qty not available");
        //    return;
        //}


        //dataGridView1.AutoGenerateColumns = false;
        //dataGridView1.ColumnCount = 5;
        //dataGridView1.Columns[0].HeaderText = "Item Code";
        //dataGridView1.Columns[0].DataPropertyName = "itemCode";
        //dataGridView1.Columns[1].HeaderText = "Item Name";
        //dataGridView1.Columns[1].DataPropertyName = "itemName";
        //dataGridView1.Columns[2].HeaderText = "Item Quantity";
        //dataGridView1.Columns[2].DataPropertyName = "itemQty";
        //dataGridView1.Columns[3].HeaderText = "Unit Price";
        //dataGridView1.Columns[3].DataPropertyName = "itemPrice";
        //dataGridView1.Columns[4].HeaderText = "Sub Total";
        //dataGridView1.Columns[4].DataPropertyName = "subTotal";
        //dt.Columns.Add(new DataColumn("subTotal"));

        //dt.Rows[0]["itemQty"] = txt_q.Text;
        //dt.Rows[0]["subTotal"] = Convert.ToDouble(dt.Rows[0]["itemQty"]) * Convert.ToDouble(dt.Rows[0]["itemPrice"]);
        //dataGridView1.DataSource = dt;
        //dataGridView1.Refresh();
    }
    }
