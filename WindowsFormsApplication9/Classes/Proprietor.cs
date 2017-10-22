using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9.Classes
{
    class Proprietor
    {

        public int ProprietorId { get; set; }
        public string ProprietorName { get; set; }
        public string ProprietorUsername { get; set; }
        public string ProprietorPassword { get; set; }
        public string conString = "";
        SqlConnection con;

        public Proprietor()
        {
            conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }

        public bool PLogin(Proprietor proprietor)
        {


            SqlCommand cmd = new SqlCommand("select * from Proprietor where ProprietorUserName='" + proprietor.ProprietorUsername + "'", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
                if (proprietor.ProprietorUsername.Equals(rdr[2].ToString()) && proprietor.ProprietorPassword.Equals(rdr[3].ToString()))
                    return true;
            return false;

        }
        public void pManageItem()
        {


        }

        public void pManageSupplier()
        {


        }

        public void pGetRep()
        {



        }

        public void pRecOrder()
        {



        }

        public void pManageQuot()
        {


        }

        public void pManageSale()
        {



        }

    }
}
