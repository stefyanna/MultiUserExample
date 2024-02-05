using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiUserExample
{
    public partial class Login : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(RegId) from Login where username='" + TextBox1.Text + "' and password='" + TextBox2 + "'";
            string cid = obj.Fun_scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if(cid1==1)
            {
                string str1 = "select Reg_Id from Login where username='" + TextBox1.Text + "' and password ='" + TextBox2 + "'";
                string regid= obj.Fun_scalar(str1);
                Session["userid"] = regid;
                string str2 = "select Log_type from Login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logtype=obj.Fun_scalar(str2);
                if (logtype == "admin")
                {
                    Label1.Text = "Admin";
                }
                else if (logtype == "user") 
                {
                    Label1.Text = "User";
                }
            }
        }
    }
}