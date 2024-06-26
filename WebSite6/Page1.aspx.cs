using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] != null)
        {
            Label1.Text = "Sports and other physical activities have innumerable physical health benefits, including improved muscular fitness, bone health, increased life expectancy, and coronary health. Sports can also help prevent various types of cancer and weight gain and have positive effects on mental health by reducing depression and improving cognitive function.";
        }
        if (Session["Username"] != null)
        {
            Label2.Text = "Sports can help promote long-term weight loss and help avoid weight gain. Sports increase metabolic rates and can help increase lean body mass while burning calories and getting rid of excess fat. Although the amount of physical activity needed varies by body type and caloric intake, sports can help a person maintain a healthy weight.";
        }
        if (Session["Username"] != null)
        {
            Label3.Text = "According to the U.S. Department of Health and Human Services, between two and half to five hours of moderately-intensive physical activity can help achieve weight stability. High-intensity sports can help people who want to lose weight or maintain a significant amount of weight los";
        }
        if (Session["Username"] != null)
        {
            Label4.Text = "Sports can help people of all ages maintain and improve the health of their heart, lungs and blood vessels. Physical activity can significantly reduce the risk of coronary disease and stroke.";
        }
        if (Session["Username"] != null)
        {
            Label5.Text = "According to the British Parliamentary Office of Science and Technology, approximately 40 percent of deaths related to coronary heart disease are related to inadequate physical activity, obesity, stress and raised blood pressure. Sports can help with all of these physical issues, decreasing the risk of coronary disease by about 50 percent.";
        }
        if (Session["Username"] != null)
        {
            Label6.Text = "you grow older, physical activity becomes increasingly important for the health of bones, muscles and joints. Building bone, muscle and joint strength is important for children.";
        }
        if (Session["Username"] != null)
        {
            Label7.Text = "Sports can be a form of mental therapy for people with psychological disorders and depression. Sports may promote self-esteem in the form of positive perception of body image and self-worth. By participating in sports with others, people can also enter in positive social environments to promote psychological health. Physical activity can also decrease the risk of cognitive decline that comes with aging and can reduce anxiety in adolescents.";
        }
    }
}