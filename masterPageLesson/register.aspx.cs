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
    public partial class register1 : System.Web.UI.Page
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

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User-PC\Desktop\my tv list\masterPageLesson\App_Data\Database1.mdf"";Integrated Security=True";
                con.Open();

                string s = "insert into Users(name,pass,mail,gender,genre1,genre2,genre3,genre4,genre5,genre6,birthday) values('" + name + "','" + pass + "','" + mail + "','" + gender + "','" + genre1 + "','" + genre2 + "','" + genre3 + "','" + genre4 + "','" + genre5 + "','" + genre6 + "','" + birthday + "')";
                SqlDataAdapter da = new SqlDataAdapter(s, con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //שאילתה ששולפת את המזהה של המשתמש ושומרת אותו בסשן
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT id from Users WHERE name='" + name + "'AND pass='" + pass + "'";
                object obj = cmd2.ExecuteScalar();
                con.Close();


                if (obj != null)
                {
                    Session["id"] = obj;
                    Session["name"] = name;
                    Response.Redirect("home.aspx");
                }

            }
        }
    }
}