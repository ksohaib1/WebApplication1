﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L8LBLKV\MSSQLSERVER01;Initial Catalog=LocalDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            msg.Visible = false;
        }


        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void ok_Click1(object sender, EventArgs e)
        { 
            con.Open();

            string query = "Insert into Bike (ID,Company,EngineNo,Rent,Location,Availability) values (@id,@company,@en,@rent,@location,@a);";

            SqlCommand sqlcmd = new SqlCommand(query, con);

            sqlcmd.Parameters.AddWithValue("@id", bn.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@company", c.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@en", en.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@rent", r.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@location", a.Text.Trim());
            sqlcmd.Parameters.AddWithValue("@a", ab.Text.Trim());
            sqlcmd.ExecuteNonQuery();
            con.Close();
            msg.Visible = true;
        }
    }
}