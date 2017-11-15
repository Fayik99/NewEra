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
    public class CusOrder
    {

        public int orderNumber { get; set; }
        public string cusName { get; set; }
        public string cusAdd1 { get; set; }
        public string cusAdd2 { get; set; }
        public string cusAdd3 { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime orderCreateDate { get; set; }
        public DateTime orderExpireDate { get; set; }
        public string cusTel { get; set; }
        public string conString = "";
        SqlConnection con;

        public CusOrder()
        {

            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["NewEraDBcontext"].ConnectionString;
            con = new SqlConnection(conString);
        }

        public void oderMenu(CusOrder a,string customerid,DataGridView datagridview1,string ordernumber)
        {
            //    SqlCommand cmd = new SqlCommand("insert into Customer values('" + a.cusName + "','" + a.cusTel + "','" + a.cusAdd1 + "','" + a.cusAdd2 + "','" + a.cusAdd3 + "')", con);
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            int status = 0;
            con.Open();
           SqlCommand cmd =new SqlCommand( "insert into CusOrderHeader values('"+DateTime.Now.Date+"','"+ a.orderExpireDate + "','"+Convert.ToInt32(customerid)+"','"+status+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();


            foreach(DataGridViewRow row in datagridview1.Rows)
            {
                try
                { 
                    con.Open();
                    cmd = new SqlCommand("insert into CusOrderDetail values('" + Convert.ToInt32(ordernumber) + "','" + Convert.ToInt16(row.Cells["item Code"].Value.ToString()) + "','" + Convert.ToInt32(row.Cells["Quantity"].Value.ToString()) + "','" + Convert.ToInt32(row.Cells["Subtotal"].Value.ToString()) + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                    con.Close();
                    return;
                }
            }                                                                                                                                                                                                                                                            

        }

        public DataTable viewOrder()
        {
            SqlCommand cma= new SqlCommand("select * from CusOrderDetail ", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cma);
            DataTable dat = new DataTable();
            sda.Fill(dat);
            return dat;
        }
    }
}

