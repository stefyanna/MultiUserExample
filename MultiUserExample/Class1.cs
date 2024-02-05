using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MultiUserExample
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;

        public Class1()
        {
            con = new SqlConnection(@"server=LAPTOP-FIA28NHF\SQLEXPRESS;database=NovDB;integrated security=true");
        }
        public int Fun_Non_Query(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string Fun_scalar(string sql)
        {
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}