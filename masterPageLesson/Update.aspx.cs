using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace masterPageLesson
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String name = Request.Form["name"];
                String pass = Request.Form["password1"];
                String mail = Request.Form["mail"];
                String gender = Request.Form["gender"];
                String genre1 = Request.Form["genre1"];
                String genre2 = Request.Form["genre2"];
                String genre3 = Request.Form["genre3"];
                String genre4 = Request.Form["genre4"];
                String genre5 = Request.Form["genre5"];
                String genre6 = Request.Form["genre6"];
                String birthday = Request.Form["birthday"];
                Object id = Session["id"];

                if (Session["id"] != null)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User-PC\Desktop\my tv list\masterPageLesson\App_Data\Database1.mdf"";Integrated Security=True");
                    con.Open();
                    string s = "update Users set name='" + name + "',pass='" + pass + "',mail='" + mail + "',gender='" + gender + "',genre1='" + genre1 + "',genre2='" + genre2 + "',genre3='" + genre3 + "',genre4='" + genre4 + "',genre5='" + genre5 + "',genre6='" + genre6 + "',birthday='" + birthday + "'    where id= " + id + "";
                    SqlDataAdapter da = new SqlDataAdapter(s, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    con.Close();
                }

            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User-PC\Desktop\my tv list\masterPageLesson\App_Data\Database1.mdf"";Integrated Security=True");
                con.Open();
                string s = "delete from Users where id=" + int.Parse(Session["id"].ToString()) + "";
                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                con.Close();
                Session.Clear();
                Session.Abandon();
                Response.Redirect("register.aspx");
            }

        }
    }
}