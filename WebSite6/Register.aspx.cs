using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void registerbutton_Click(object sender, EventArgs e) // if he clicked register without entering a username it will ask for him to enter his username and if the password is shorter then 6 characters it will tell him that Password must be at least 6 characters 
    {
        if (Username.Text == null || Username.Text == "")
        {
            lblMsage.Text = "Please enter your username";

        }
        else if (Password.Text.Length < 6)
        {
            lblMsage.Text = "Password must be at least 6 characters";
        }
    }
}