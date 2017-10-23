using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9.Classes
{
    public class PurchaseOrder 
    {
        public int orderId { get; set; }
        public string orderDate { get; set; }
        public int itemOrderQuantity { get; set; }
        public double grosstotal { get; set; }
        public Suppliers supplier { get; set; }
        public string conString = "";
        SqlConnection con;

        public void sOrderMenu()

        {


        }

        public void sAddOrder()
        {
           
        }

    }
}
