using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterPageLesson
{
    public partial class Quiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int score = 0;

                string q1 = Request.Form["q1"];
                string q2 = Request.Form["q2"];
                string q3 = Request.Form["q3"];
                string q4 = Request.Form["q4"];
                string q5 = Request.Form["q5"];
                string q6 = Request.Form["q6"];
                string q7 = Request.Form["q7"];
                string q8 = Request.Form["q8"];
                string q9 = Request.Form["q9"];
                string q10 = Request.Form["q10"];

                if (q1 == "Korean")
                    score += 10;

                if (q2 == "Doug Judy")
                    score += 10;

                if (q3 == "Bangle")
                    score += 10;

                if (q4 == "Fear")
                    score += 10;

                if (q5 == "Get Schwifty")
                    score += 10;

                if (q6 == "Lake")
                    score += 10;

                if (q7 == "four")
                    score += 10;

                if (q8 == "Doctor")
                    score += 10;

                if (q9 == "Metal")
                    score += 10;

                if (q10 == "Celing")
                    score += 10;

                finalScore.InnerHtml = "your score is: " + score + " out of 100";

            }

        }
    }
}