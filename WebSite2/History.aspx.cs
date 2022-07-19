using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e) 
    {
        if (Session["phone"] != null)
        {   
            conn.Open();
            // GridView1
            string com = "SELECT *from payment where user_phone=@phone";
            SqlCommand cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", Session["phone"].ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();

            reader.Close();
            // GridView2
             com = "SELECT *from ttable where from_ID=@phone";
             cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", Session["phone"].ToString());
             reader = cmd.ExecuteReader();

            GridView2.DataSource = reader;
            GridView2.DataBind();
            reader.Close();
            // GridView3
            com = "SELECT *from cashout where From_ID=@phone";
            cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", Session["phone"].ToString());
            reader = cmd.ExecuteReader();

            GridView3.DataSource = reader;
            GridView3.DataBind();
            reader.Close();

            // GridView4
            com = "SELECT *from cashIn where TO_ID=@phone";
            cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", Session["phone"].ToString());
            reader = cmd.ExecuteReader();

            GridView4.DataSource = reader;
            GridView4.DataBind();
            reader.Close();

            // GridView5
            com = "SELECT *from mobilerecharge where From_ID=@phone";
            cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", Session["phone"].ToString());
             reader = cmd.ExecuteReader();

            GridView5.DataSource = reader;
            GridView5.DataBind();
            reader.Close();

            // GridView6
            com = "SELECT *from ttable where to_id=@phone";
            cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", Session["phone"].ToString());
            reader = cmd.ExecuteReader();

            GridView6.DataSource = reader;
            GridView6.DataBind();
            reader.Close();

            conn.Close();
        }
        else
        gg.Visible = false; 
    }
}