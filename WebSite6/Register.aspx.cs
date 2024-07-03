using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Registerbutton_Click(object sender, EventArgs e) //if Username or Email or Password Fields are empty, signup will fail and if the password is shorter then 6 characters it will tell him that Password must be at least 6 characters else register success 
    {
        DBHelper dbH = new DBHelper();
        DataTable dt = dbH.GetTableByName("users");

        if (Username.Text == null || Username.Text == "")
        {
            lblMsage.Text = "Username Field Is Empty, Sign up Failed";

        }
        else if (Email.Text == null || Email.Text == "")
        {
            lblMsage.Text = "Email Field Is Empty, Sign up Failed";
        }
        else if (Password.Text == null || Password.Text == "" || Password.Text.Length < 6)
        {
            lblMsage.Text = "Password must be at least 6 characters";
        }
        else if (FirstName.Text == null || FirstName.Text == "")
        {
            lblMsage.Text = "FirstName Field Is Empty, Sign up Failed";
        }
        else if (LastName.Text == null || LastName.Text == "")
        {
            lblMsage.Text = "LastName Field Is Empty, Sign up Failed";
        }
        else
        {

        string register = "INSERT INTO users(userEmail,userFirstName,userLastName,userUsername,userPassword) " +
              "VALUES ('" + Email.Text + "','" + FirstName.Text + "','" + LastName.Text + "','" + Username.Text + "','" + Password.Text + "');";
            dbH.ExecuteNonQuery(register);


            lblMsage.Text = "Register Successful";
            lblMsage.ForeColor = System.Drawing.Color.Green;
            Email.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            Username.Text = "";
            Password.Text = "";


        }
    }
}