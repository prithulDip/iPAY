using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SendMoney : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
    HttpCookie cookie;
    string username, amount, email, phone, pass;
    protected void Page_Load(object sender, EventArgs e)
    {
        Error.Visible = false;
        if(Session["phone"] != null)
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
        if (toID.Text!="" && Amount.Text!="" && Password.Text!="" )
        {
            conn.Open();
            string com = "SELECT count(1) from users where phone=@phone";
            SqlCommand cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@phone", toID.Text);
            int check = Convert.ToInt32(cmd.ExecuteScalar());
            if (check != 1)
            {
                Error.Text = "User does not exists";
                Error.Visible = true;
                return;
            }
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

            com = "SELECT MAX(T_id) as t_id FROM ttable";
            cmd = new SqlCommand(com, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string tID = dt.Rows[0]["t_id"].ToString();
            int newTID = int.Parse(tID) + 1;


            com = "INSERT into ttable (T_id,from_id,to_id,amount,time_date) VALUES(@ID,@from,@to,@amount,@time)";

            cmd = new SqlCommand(com, conn);
            cmd.Parameters.AddWithValue("@ID", newTID);
            cmd.Parameters.AddWithValue("@from", phone);
            cmd.Parameters.AddWithValue("@to", toID.Text);
            cmd.Parameters.AddWithValue("@amount", Amount.Text);
            cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();

            updateReceiver();
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
    public void updateReceiver()
    {
        string com = "SELECT amount from users where phone = @phone";
        SqlCommand cmd = new SqlCommand(com, conn);
        cmd.Parameters.AddWithValue("@phone", toID.Text);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        string oldValue = dt.Rows[0]["amount"].ToString();

        string newamount = ( float.Parse(oldValue) + float.Parse(Amount.Text)).ToString();

        com = "UPDATE users SET amount = @newValue WHERE phone = @phone";
        cmd = new SqlCommand(com, conn);
        cmd.Parameters.AddWithValue("@phone", toID.Text);
        cmd.Parameters.AddWithValue("@newValue", newamount);
        cmd.ExecuteNonQuery();
    
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