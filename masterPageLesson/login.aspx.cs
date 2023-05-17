using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace masterPageLesson
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                String name = Request.Form["name"];
                String pass = Request.Form["password"];

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User-PC\Desktop\my tv list\masterPageLesson\App_Data\Database1.mdf"";Integrated Security=True";
                con.Open();

                //שאילתה ששולפת את המזהה של המשתמש ושומרת אותו בסשן
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT id from Users WHERE name='" + name + "'AND pass='" + pass + "'";
                object obj = cmd2.ExecuteScalar();
                con.Close();

                if (obj != null)
                {
                    Session["name"] = name;
                    Session["id"] = obj;
                    Response.Redirect("home.aspx");
                }

            }
        }
    }
}