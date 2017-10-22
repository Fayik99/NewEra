using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9.Classes
{
    class Quotations
    {

        public int quotNumber { get; set; }
        public string quotationCreateDate { get; set; }
        public string  quotExpDate { get; set; }
        public string conString = "";
        SqlConnection con;

        public Quotations()
        {

            conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }


        public DataTable addQuot(string name)
        {
            SqlCommand cmd = new SqlCommand("select itemCode,itemname,itemPrice from Item where ItemName='" + name + "'", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
           

        }

        public void cancelQuot()
        {


        }

        public void quotMenu()
        {


        }
    }
}
