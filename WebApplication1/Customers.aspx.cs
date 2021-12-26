using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Customers : System.Web.UI.Page 
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L8LBLKV\MSSQLSERVER01;Initial Catalog=LocalDB;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "Select name from Employee where Employee.email=@un And Employee.password=@p;";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@un", Session["Email"]);
            cmd.Parameters.AddWithValue("@p", Session["Password"]);
            string name = Convert.ToString(cmd.ExecuteScalar());


            Label1.Text = "Welcome  " + name; 

            
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Main.aspx");
        }
    }
}