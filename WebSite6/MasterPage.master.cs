using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e) 
    { 

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


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Home.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }
   


}
