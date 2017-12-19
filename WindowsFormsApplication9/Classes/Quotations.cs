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
   public class Quotations
    {

        public int quotNumber { get; set; }
        public Item Item1 { get; set; }
        public string quotationCreateDate { get; set; }
        public string  quotExpDate { get; set; }
        public string conString = "";
        SqlConnection con;

        public Quotations()
        {

            conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }


        public SqlDataReader addQuot(string name)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select itemCode,itemname,itemPrice from Item where ItemName='" + name + "'", con);
            //SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataReader rd = cmd.ExecuteReader();
            
            rd.Read();
            con.Close();
            return rd;
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //return dt;
           

        }

        public void cancelQuot(Quotations wrt)
        {
            SqlCommand mn = new SqlCommand("delete  from QuotationHeaderFile where QuotationNumber='"+wrt.quotNumber+"'",con);
            con.Open();
            mn.ExecuteNonQuery();
            con.Close();


        }

        public void quotMenu(Quotations abcd,int a)
        {


            //SqlCommand cms = new SqlCommand("insert into QuotationHeaderFile values('"+a+"','" + abcd.quotationCreateDate + "','" + abcd.quotExpDate + "')", con);
            //con.Open();
            //cms.ExecuteNonQuery();
            //con.Close();
        }
        public void quotMenu1(Quotations we,int b)
        { 
            //SqlCommand cm = new SqlCommand("insert into QuotationDetailFile values('"+b+"','" +we.Item1.ItemCode + "')", con);
            //con.Open();
            //cm.ExecuteNonQuery();
            //con.Close();

        }



    }
}
