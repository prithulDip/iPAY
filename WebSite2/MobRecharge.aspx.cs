using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class MobRecharge : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
    HttpCookie cookie;
    string username, amount, email, phone, pass;
    protected void Page_Load(object sender, EventArgs e)
    {
        Error.Visible = false;
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
        if(Phone.Text != "" && Amount.Text!="" && Password.Text!= "")
        {
            conn.Open();

            if (float.Parse(amount) < float.Parse(Amount.Text))
            {
                Error.Text = "Insufficient Funds";
                Error.Visible = true;
                return;
            }

            if (Password.Text != pass)
            {
                Error.Text = "Wrong Passward";
                Error.Visible = true;
                return;
            }

            string com = "SELECT MAX(R_ID) as r_id FROM mobilerecharge";
            SqlCommand cmd = new SqlCommand(com, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string rID = dt.Rows[0]["r_id"].ToString();
            int newRID = int.Parse(rID) + 1;


            com = "INSERT into mobilerecharge (R_ID,From_ID,TO_ID,amount,date_time) VALUES(@ID,@from,@to,@amount,@time)";

            cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@ID", newRID);
            cmd.Parameters.AddWithValue("@from", phone);
            cmd.Parameters.AddWithValue("@to", Phone.Text);
            cmd.Parameters.AddWithValue("@amount", Amount.Text);
            cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();

            updateSender();
            conn.Close();
            Response.Redirect("User.aspx");
        }

        else
        {
            Error.Text = "Fill EVEYTHING..!";
            Error.Visible = true;
        }
    }

    public void updateSender()
    {
        string newamount = (float.Parse(amount) - float.Parse(Amount.Text)).ToString();
        string com = "UPDATE users SET amount = @newValue WHERE phone = @phone";
        SqlCommand cmd = new SqlCommand(com, conn);
        cmd.Parameters.AddWithValue("@newValue", newamount);
        cmd.Parameters.AddWithValue("@phone", phone);
        cmd.ExecuteNonQuery();
        if (cookie != null)
        {
            cookie.Expires = DateTime.Now.AddDays(-1);
        }
        AddCookie(phone, username, pass, newamount, email);
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