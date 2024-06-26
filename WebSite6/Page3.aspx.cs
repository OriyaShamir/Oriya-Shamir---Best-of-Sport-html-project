using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] != null)
        {
            Label14.Text = "Playing sports provides participants with opportunities to develop skills in communication and team building. according to Keith Zullig, a public health researcher. These skills enable people to function effectively as leaders, as well. Playing and coaching sports activities, such as baseball, football, running, bicycling and swimming, helps participants learn to treat other competitors with respect, identify strengths and weaknesses, develop winning strategies and manage time effectively. Participating in sports helps people develop confidence and make quick decisions necessary to succeed in leadership roles of all types.";
        }
        if (Session["Username"] != null)
        {
            Label15.Text = "Effective leaders assess situations and decide which leadership style to use. In a crisis situation, they typically use the autocratic leadership style. Playing sports presents many opportunities to recognize when to behave decisively. For example, when a soccer player sees a chance to score a goal, he makes the kick. In other cases, a leader needs to consult his subordinates and gather information before making a decision. Playing team sports often involves developing a strategy to confront the opponent and attack its weaknesses. Leaders of all types use these same strategies in other situations.";
        }
        if (Session["Username"] != null)
        {
            Label16.Text = "Company executives need to establish a vision, develop strategic objectives, hire talented employees, obtain funding to operate their business and motivate personnel. Playing and coaching sports allows a future business leader to develop team-building skills. He learns how to inspire others and focus on achieving objectives. For example, successful business project leaders use their sports experience to coordinate team-building games for their subordinates. This helps foster collaboration in the workplace. A background that includes playing team sports prepares a person to function effectively in personal and professional situations that require coordinating other people's actions.";
        }
        if (Session["Username"] != null)
        {
            Label17.Text = "Playing sports helps participants learn to make decisions by observing and interpreting information quickly. Effective leaders exhibit decisive behavior. For example, a football quarterback typically has only a few seconds to decide where to throw a pass. Playing sports helps a person develop the skills and behavior necessary to succeed in a dynamic, global workplace. Additionally, by participating on a team, a player learns to develop strategies and work with his teammates to enable their victory. Playing sports prepares a leader to influence others, set realistic goals and solve problems efficiently to win a competitive advantage.";
        }
        if (Session["Username"] != null)
        {
            Label18.Text = "Leaders require excellent communication skills. Playing sports helps people develop the ability to work together effectively using techniques that apply in business situations, too. For example, a baseball pitcher and catcher communicate using a series of signals. Finding a way to communicate efficiently in any situation helps a leader succeed in business, too. People who play sports learn how to present their winning ideas to others. Leaders improve their leadership capacity by listening to others, and speaking and writing clearly and convincingly.";
        }
    }
}