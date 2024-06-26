using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void LoginClick_Click(object sender, EventArgs e) // if he entered a right username\email and password it will redirect him to home with 1 second timing and if he didn't it will type to him "Username or Passworrd are incorrect"
    {
        DBHelper dbH = new DBHelper();
        DataTable dt = dbH.GetTableByName("users");
        if (dt.Rows.Count > 0)
        {
            bool isUser = false;
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if (((string)dt.Rows[i][4] == TextUsername.Text || ((string)dt.Rows[i][1] == TextUsername.Text)) && ((string)dt.Rows[i][5] == TextPassword.Text))
                {
                    isUser = true;                   
                    Session["Username"] = (string)dt.Rows[i]["userUsername"];
                    Session["Admin"] = (bool)dt.Rows[i]["userAdmin"];
                    i = dt.Rows.Count + 1;                 
                }
            }

            if (isUser)
            {
                Response.Redirect("Home.aspx");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                lblMsage2.Text = "Username or Passworrd are incorrect";
            }
        }
    }
}