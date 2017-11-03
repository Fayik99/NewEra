﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9.Classes
{
      
    public class PurchaseOrder 
    {
        public int orderId { get; set; }
        public string orderDate { get; set; }
        public Item Item { get; set; }
        public int qty { get; set; }
        public double grosstotal { get; set; }
        public Suppliers supplier { get; set; }
        public string conString = "";
        SqlConnection con;

        public PurchaseOrder()
        {
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }


        public void sOrderMenu()

        {


        }

        public void sAddOrder(DataGridView dataGridView1, DataGridView dataOrg,PurchaseOrder ad)
        {
            int qty;
            int ic;
            con.Open();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                ic = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToInt32(dataOrg.Rows[ic - 1].Cells[3].Value);
                SqlCommand sa = new SqlCommand("update Item set itemQty = '" + qty + "' where itemCode = '" + ic + "'", con);
                sa.ExecuteNonQuery();
            }
            con.Close();
            getQua(dataOrg);

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                int qty1 = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                
               
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into PurchaseOrderDetailFile values('" +  ad.orderId+ "','" + name + "','" + qty1 + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            con.Open();
            SqlCommand cms = new SqlCommand("insert into PurchaseOrderHeaderFile values('" + ad.supplier.supId + "', '" + ad.orderId + "', '"+ DateTime.Now.Date + "')", con);
            cms.ExecuteNonQuery();
            con.Close();
            //dataGridView1.Rows.Clear();
            /*for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
            }*/
        }


        public void getQua(DataGridView dataOrg)
        {
            SqlCommand sa = new SqlCommand("select * from Item", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sa);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataOrg.DataSource = dt;
        }

    }
}
