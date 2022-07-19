using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    string PhoneNo, UserName, Pass,Amount,email;

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
        string com = "SELECT COUNT(1) from users where phone=@phone";
        SqlCommand cmd = new SqlCommand(com, conn);
        cmd.Parameters.AddWithValue("@phone", Phone.Text);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        if (count ==  0)
        {
           //esponse.Write("<script>alert('wrong Phone number')</script>");
            Error.Text = "wrong Phone number";
            Error.Visible = true;
            return;
        }

        com = "SELECT * from users where phone=@phone";
        cmd = new SqlCommand(com, conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        cmd.Parameters.AddWithValue("@phone", Phone.Text);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        Pass = dt.Rows[0]["passward"].ToString();
        UserName = dt.Rows[0]["userName"].ToString();
        Amount = dt.Rows[0]["amount"].ToString();
        email = dt.Rows[0]["email"].ToString();
        PhoneNo = Phone.Text;
        if (Password.Text == Pass)
        {
            Session["phone"] = Phone.Text;
            conn.Close();
            AddCookie(PhoneNo,UserName,Pass,Amount,email);
            Response.Redirect("user.aspx");
        }

        else
           //esponse.Write("<script>alert('Wrong Passward')</script>");
        Error.Text = "Wrong Passward";
        Error.Visible = true;


    }

    public void AddCookie(string Phone, string UserName, string Password,string Amount,string email)
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