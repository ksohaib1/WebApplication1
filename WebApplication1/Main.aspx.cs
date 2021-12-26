using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication1
{
    public partial class Main: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Visible = false;
        }
        public void Login_Click1(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L8LBLKV\MSSQLSERVER01;Initial Catalog=LocalDB;Integrated Security=True"))
            {
                con.Open();
                string query = "select Count(1) from Employee where Email=@Email and Password = @Password";
                SqlCommand sqlcmd = new SqlCommand(query, con);
                sqlcmd.Parameters.AddWithValue("@Email", un.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Password", p.Text.Trim());
                int ch = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (ch == 1)
                {
                    Session["Email"] = un.Text.Trim();
                    Session["Password"] = p.Text.Trim();
                    Response.Redirect("Customers.aspx");
                }
                else
                {
                    Error.Visible = true;
                }
            }
        }
    }
}