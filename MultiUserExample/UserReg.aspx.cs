using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MultiUserExample
{
    public partial class UserReg : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login";
            string regid = obj.Fun_scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into UserReg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "')";
            int i = obj.Fun_Non_Query(ins);
            string inslog = "insert into Login values(" + reg_id + ",'" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int j = obj.Fun_Non_Query(inslog);
        }
    }
}