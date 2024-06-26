using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e) // if username isn't null type Hello,+The username name, makes the login register buttons invisible and the logout button and the manwomen logo visible
    { 
      if (Session["Username"] != null)
        {
            lblsession.Text = "Hello, " + Session["Username"]  ;
            Logout.Visible = true;
            Button5.Visible = false;
            Button6.Visible = false;
            manwomenlogo.Visible = true;
            if ((bool)Session["Admin"]) // if the user is admin he would be able to get in to the admin panel
            {
                Adminbutton.Visible = true;
            }
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Page1.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Page2.aspx");

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Page3.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Page4.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }

    protected void Logout_Click(object sender, EventArgs e) //after logging out the log out button and manwomen logo invisible and makes the login register  visible ,makes the username label disappear and redirect the user to the home page
    {
        Button5.Visible = true;
        Button6.Visible = true;
        Logout.Visible = false;
        Session["Username"] = null;
        Response.Redirect("Home.aspx");
        manwomenlogo.Visible = false;
    }

    protected void Adminbutton_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminPanel.aspx");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("BodyBuildingExercises.aspx");
    }
}
