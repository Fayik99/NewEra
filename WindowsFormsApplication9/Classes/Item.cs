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

        public void addItm(Item a)
        {
            SqlCommand cmd = new SqlCommand("insert into Item values('" +a.ItemName  + "','" +a.ItemPrice  + "','" +a.ItemQuantity  + "','"+a.supId+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void deleteItem(Item d)
        {
            SqlCommand cmd = new SqlCommand("delete from Item where itemCode='" + d.ItemCode + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void updateItem (Item b)
        {
            try {
                SqlCommand cmd = new SqlCommand("update Item set itemName='" + b.ItemName + "',itemPrice='" + b.ItemPrice + "',itemQty='" + b.ItemQuantity + "',supID='" + b.supId + "' where itemCode='" + b.ItemCode + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
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
