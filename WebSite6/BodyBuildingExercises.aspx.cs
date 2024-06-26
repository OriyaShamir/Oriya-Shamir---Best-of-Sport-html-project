using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BodyBuildingExercises : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAL table = new DAL();
        ExerciseTable.Text = table.ExerciseAdminTable(); // calls the Exercise function
    }
}