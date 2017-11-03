using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9.Classes
{
    public class CusOrderList
    {
        public double subtotal { get; set; }
        public int Orderqty { get; set; }
        public int orderNumber { get; set; }
        public CusOrder cusOrder { get; set; }
        public Item Item { get; set; }
        public PurchaseOrder supplyOrder { get; set; }
        public string conString = "";
        SqlConnection con;
        public CusOrderList()
        {
            conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);

        }

        public void addOrder()
        {
           

        }

        public void cancelOrder(int ordernumber)
        {

            SqlCommand cmd = new SqlCommand("delete from CusOrderDetail where OrderNumber='"+ordernumber+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
