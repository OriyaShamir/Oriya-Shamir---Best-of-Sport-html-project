using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    public DAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public string UserAdminTable() //הדפסת הטבלה של המשתמשים
    {
        string table = "";
        DBHelper dbH = new DBHelper();
        DataTable dt = dbH.GetTableByName("users");
        if (dt.Rows.Count > 0)
        {
            table+="<table border='1' class='font'>";
            table += "<tr>";
            table += "<td> userID </td>";
            table += "<td > userEmail </td>";
            table += "<td> userFirstName </td>";
            table += "<td > userLastName </td>";
            table += "<td> userUsername </td>";
            table += "<td> userPassword </td>";
            table += "<td > userAdmin </td>";
            table += "</<tr>";
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                table+="<tr>";
                for (int j = 0; j <= dt.Columns.Count - 1; j++)
                {
                    table += "<td>";
                    table += dt.Rows[i][j];

                }
                table += "</td>";
            }
            table += "</tr>";
        }
        table += "</table>";
        return table;
    }
    public string ExerciseAdminTable() //הדפסת הטבלה של המשתמשים
    {
        string table = "";
        DBHelper dbH = new DBHelper();
        DataTable dt = dbH.GetTableByName("Exercises");
        if (dt.Rows.Count > 0)
        {
            table += "<table border='1' class='font'>";
            table += "<tr>";
            table += "<td> ID </td>";
            table += "<td > Legs </td>";
            table += "<td> Chest </td>";
            table += "<td > Back </td>";
            table += "<td> Shoulders </td>";
            table += "<td> Biceps </td>";
            table += "<td > Triceps </td>";
            table += "<td > ABS </td>";
            table += "</<tr>";
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                table += "<tr>";
                for (int j = 0; j <= dt.Columns.Count - 1; j++)
                {
                    table += "<td>";
                    table += dt.Rows[i][j];

                }
                table += "</td>";
            }
            table += "</tr>";
        }
        table += "</table>";
        return table;
    }
}
