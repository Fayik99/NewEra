using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9.Classes
{
   public class Item
    {

        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
        public Suppliers supplier { get; set; }
        public PurchaseOrder supplyOrder { get; set; }

        public string conString = "";
        SqlConnection con;
       public int supId { get; set; }

        public Item()
        {

            conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }

        public void addItm(Item a,int sid)
        {
            SqlCommand cmd = new SqlCommand("insert into Item values('" +a.ItemName  + "','" +a.ItemPrice  + "','" +a.ItemQuantity  + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            SqlCommand fr = new SqlCommand("insert into itemSupply values('" + sid + "','" + a.ItemCode + "','" +string.Empty+ "','" + DateTime.Now.ToString("dd/MM/yyyy") + "','" + a.ItemQuantity + "')", con);
            con.Open();
            fr.ExecuteNonQuery();
            con.Close();

        }

        public void deleteItem(Item d)
        {
            SqlCommand cmd = new SqlCommand("delete from Item where itemName='" + d.ItemName + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void updateItem (Item b,int a)
        {
            try {
                con.Open();
                SqlCommand bv = new SqlCommand("select itemQty from Item where itemCode='"+b.ItemCode+"'",con);
                SqlDataReader dr = bv.ExecuteReader();
                dr.Read();
                int totalQty = Convert.ToInt32(dr[0]) + b.ItemQuantity;
                dr.Close();
                con.Close();


                SqlCommand cmd = new SqlCommand("update Item set itemName='" + b.ItemName + "',itemPrice='" + b.ItemPrice + "',itemQty='" + totalQty + "' where itemCode='" + b.ItemCode + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DateTime datte = Convert.ToDateTime(DateTime.Now.Date.ToString());
                SqlCommand fr = new SqlCommand("insert into itemSupply values('"+b.supId+ "','" + b.ItemCode + "','"+a+"',CONVERT(DATETIME,'" + datte.ToShortDateString() + "',103), '" + b.ItemQuantity + "')",con);
                con.Open();
                fr.ExecuteNonQuery();
                con.Close();


                con.Open();
                cmd = new SqlCommand("update PurchaseOrderHeaderFile set status=1 where PurchaseorderID='"+a+"'",con);
                cmd.ExecuteNonQuery();
                con.Close();

                //con.Open();
                //cmd = new SqlCommand("delete from PurchaseOrderHeaderFile where PurchaseorderID='" +a+ "'", con);
                //cmd.ExecuteNonQuery();
                //con.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error" + ex.ToString());
            }

        }

        public DataTable checkInventory(Item ab)
        {
            SqlCommand cmd = new SqlCommand("select * from Item where itemCode='" + ab.ItemCode + "'", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            

            
        }

        public void itemMenu()
        {

        }


    }
}
