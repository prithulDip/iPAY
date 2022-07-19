using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class editProfile : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
    HttpCookie cookie;
    string username, amount, email, phone, pass;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["phone"] != null)
        {
            cookie = Request.Cookies[Session["phone"].ToString()];
            if (cookie != null)
            {

                phone = cookie["Phone"];
                username = cookie["UserName"];
                pass = cookie["Password"];
                amount = cookie["Amount"];
                email = cookie["Email"];
                    

            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if(Password.Text == pass)
        {
            conn.Open();
            string com = "UPDATE users SET username = @username, email = @email WHERE phone=@phone; ";
            SqlCommand cmd=new SqlCommand(com,conn);
            cmd.Parameters.AddWithValue("@username", Username.Text);
            cmd.Parameters.AddWithValue("@email", Email.Text);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.ExecuteNonQuery();
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
            }
            AddCookie(phone, Username.Text, Password.Text, amount, Email.Text);
            conn.Close();  
            Response.Redirect("User.aspx");
        }
        else
            Response.Write("<script>alert('Passward mismatch..!')</script>");
    }

    public void AddCookie(string Phone, string UserName, string Password, string Amount, string email)
    {
        HttpCookie cookie = new HttpCookie(Phone);
        cookie["Phone"] = Phone;
        cookie["UserName"] = UserName;
        cookie["Password"] = Password;
        cookie["Amount"] = Amount;
        cookie["Email"] = email;

        cookie.Expires = DateTime.Now.AddMinutes(10);

        Response.Cookies.Add(cookie);
    }
}