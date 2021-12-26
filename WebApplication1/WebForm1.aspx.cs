using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Visible = false;
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L8LBLKV\MSSQLSERVER01;Initial Catalog=LocalDB;Integrated Security=True"))
            {
                con.Open();
                string query = "select Count(1) from admin where Email=@Email and Password = @Password";
                SqlCommand sqlcmd = new SqlCommand(query, con);
                sqlcmd.Parameters.AddWithValue("@Email", un.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@Password", p.Text.Trim());
                int ch = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (ch ==1)
                    {
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    Error.Visible = true;
                }
            }
        }
    }
}