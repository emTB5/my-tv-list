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
    public partial class Admin : System.Web.UI.Page
    {
        string str;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User-PC\Desktop\my tv list\masterPageLesson\App_Data\Database1.mdf"";Integrated Security=True";
            con.Open();

            //שליפת הטבלה
            string s = "select * from users";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            str = "<table class='usersTable' align='center' border=10 >";
            str += "<tr>";
            foreach (DataColumn column in ds.Tables[0].Columns)
            {
                str += "<td>" + column.ColumnName + "</td>";
            }
            str += "</tr>";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                str += "<tr>";
                foreach (DataColumn column in ds.Tables[0].Columns)
                {
                    str += "<td>" + row[column] + "</td>";
                }
                str += "</tr>";
            }
            str += "</table>";
            adminDiv.InnerHtml = str;



            if (IsPostBack)
            {
                string btn = Request.Form["btn"];
                if (Request.Form["btn"] == "add")
                {
                    String name = Request.Form["name"];
                    String password1 = Request.Form["password1"];
                    String mail = Request.Form["mail"];
                    String gender = Request.Form["gender"];
                    String genre1 = Request.Form["genre1"];
                    String genre2 = Request.Form["genre2"];
                    String genre3 = Request.Form["genre3"];
                    String genre4 = Request.Form["genre4"];
                    String genre5 = Request.Form["genre5"];
                    String genre6 = Request.Form["genre6"];
                    String birthday = Request.Form["birthday"];
                    s = "insert into Users(name,pass,mail,gender,genre1,genre2,genre3,genre4,genre5,genre6,birthday) values('" + name + "','" + password1 + "','" + mail + "','" + gender + "','" + genre1 + "','" + genre2 + "','" + genre3 + "','" + genre4 + "','" + genre5 + "','" + genre6 + "','" + birthday + "')";
                    da = new SqlDataAdapter(s, con);
                    ds = new DataSet();
                    da.Fill(ds);
                    Response.Redirect("Admin.aspx");
                }
                else if (Request.Form["btn"] == "delete")
                {

                    int id = int.Parse(Request.Form["id"]);

                    s = "delete from Users where id=" + id + "";
                    da = new SqlDataAdapter(s, con);
                    ds = new DataSet();
                    da.Fill(ds);
                    Response.Redirect("Admin.aspx");

                }
                else if (Request.Form["btn"] == "update")
                {

                    String name = Request.Form["name"];
                    String password1 = Request.Form["password1"];
                    String mail = Request.Form["mail"];
                    String gender = Request.Form["gender"];
                    String genre1 = Request.Form["genre1"];
                    String genre2 = Request.Form["genre2"];
                    String genre3 = Request.Form["genre3"];
                    String genre4 = Request.Form["genre4"];
                    String genre5 = Request.Form["genre5"];
                    String genre6 = Request.Form["genre6"];
                    String birthday = Request.Form["birthday"];

                    int id = int.Parse(Request.Form["id"]);
                    s = "update Users set name='" + name + "',pass='" + password1 + "',mail='" + mail + "',gender='" + gender + "',genre1='" + genre1 + "',genre2='" + genre2 + "',genre3='" + genre3 + "',genre4='" + genre4 + "',genre5='" + genre5 + "',genre6='" + genre6 + "',birthday='" + birthday + "'    where id= " + id + "";
                    da = new SqlDataAdapter(s, con);
                    da.Fill(ds);
                    Response.Redirect("Admin.aspx");
                }

            }

        }

    }
}
