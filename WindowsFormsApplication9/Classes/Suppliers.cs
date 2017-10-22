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
   public class Suppliers
    {
        public int supId { get; set; }
        public string supName { get; set; }
        public string supAddress1 { get; set; }
        public string supAddress2 { get; set; }
        public string supAddress3 { get; set; }
        public string supMobile { get; set; }
        public string conString = "";
        SqlConnection con;

        public Suppliers()
        {

            conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }

        public void addSup(Suppliers suppliers)
        {
            try {
                SqlCommand cmd = new SqlCommand("insert into Supplier values('" + suppliers.supName + "','" + suppliers.supMobile + "','" + suppliers.supAddress1 + "','" + suppliers.supAddress2 + "','" + suppliers.supAddress3 + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(SqlException e)
            {

                MessageBox.Show("Error" + e.ToString());
            }
        }

        public void deleteSup(Suppliers si)
        {
            try {
                SqlCommand cmd = new SqlCommand("delete from Supplier where supID='" + si.supId + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(SqlException ex)
            {
                
                MessageBox.Show("error","ERROR"+ex.ToString());
            }
           
        }

        public void updateSup(Suppliers s)
        {

            SqlCommand cmd = new SqlCommand("update Supplier set supName='" + s.supName + "',supMob='" + s.supMobile + "',supAdd1='" + s.supAddress1 + "',supAdd2='" + s.supAddress2 + "',supAdd3='" + s.supAddress3 + "'where supID='" + s.supId + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable viewSup(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from Supplier where supID='" + ++id + "'", con);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void manageSup()
        {


        }

        
    }
}
