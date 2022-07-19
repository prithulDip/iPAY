using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class signUp : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        Error.Visible = false;
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
        conn.Open();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Username.Text!= "" && Email.Text != "" && Phone.Text != "" && Password.Text != "") 
        {
            if (Password.Text.Length<8)
            {
                Error.Text = "use larger passward";
                Error.Visible = true;
                return;
            }
            string com = "SELECT COUNT(1) from users where phone=@phone";
            SqlCommand cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", Phone.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                Error.Text = "Phone number is taken..! Try new one";
                Error.Visible = true;
                return;
            }


            com = "INSERT into users (userName,email,phone,passward) VALUES(@username,@email,@phone,@pass)";
            cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@username", Username.Text);
            cmd.Parameters.AddWithValue("@email", Email.Text);
            cmd.Parameters.AddWithValue("@pass", Password.Text);
            cmd.Parameters.AddWithValue("@phone", Phone.Text);
            cmd.ExecuteNonQuery();
            // Response.Write("<script>alert('SignUp successful..!')</script>");
            Session["phone"] = Phone.Text;
            AddCookie(Phone.Text, Username.Text, Password.Text, Email.Text);
            conn.Close();
            Response.Redirect("user.aspx");
        }
        else
        {
            Error.Text = "Fill every thing";
            Error.Visible = true;
        }
        
    }

    public void AddCookie(string Phone, string UserName, string Password,string email)
    {
        HttpCookie cookie = new HttpCookie(Phone);
        cookie["Phone"]= Phone;
        cookie["UserName"] = UserName;
        cookie["Password"] = Password;
        cookie["Amount"] = "0";
        cookie["Email"] = email;

        cookie.Expires = DateTime.Now.AddMinutes(10);

        Response.Cookies.Add(cookie);
    }

    
}


