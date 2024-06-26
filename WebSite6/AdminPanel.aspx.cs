using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAL table = new DAL();
        UserTable.Text = table.UserAdminTable(); // call the users table function
        if ((Session["Username"] != null && (bool)Session["Admin"] == false) || Session["Username"] == null) // אם המשתמש שמחובר אינו אדמין הוא לא יוכל להכנס לאדמין פאנל בקישור למעלה
        {
            Response.Redirect("Home.aspx");
        }
    }
}