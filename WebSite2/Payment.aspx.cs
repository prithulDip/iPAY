using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Payment : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
    HttpCookie cookie;
    string username, amount, email, phone, pass, shopname, shopid, shopamount;
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

            if (Session["Shop"] != null)
            {
                conn.Open();
                shopid = Session["Shop"].ToString();
                String com = "SELECT * from shops where Shop_ID=@shopid";
                SqlCommand cmd = new SqlCommand(com, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@shopid", shopid);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                shopname = dt.Rows[0]["name"].ToString();
                shopamount = dt.Rows[0]["amount"].ToString();
                ShopName.Text = shopname;
               // ShopName.ReadOnly= true;
            }

        }


    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Amount.Text == "")
        {
            Error.Text = "Enter Cost!";
            Error.Visible = true;
        }
        if (float.Parse(Amount.Text) <= float.Parse(amount))
        {
            if (Password.Text == pass)
            {
                addPayment();
                updateShop();
                updateUser();
                conn.Close();
                Response.Redirect("User.aspx");
               
            }
            else
            {
                Error.Text = "Wrong Passward";
                Error.Visible = true;
            }
        }
        else
        {
            Error.Text = "Insufficient Balance";
            Error.Visible = true;
        }

    }

    public void addPayment()
    {
        string com = "SELECT MAX(P_id) as P_id FROM payment";
        SqlCommand cmd = new SqlCommand(com, conn);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        string Pid = dt.Rows[0]["P_id"].ToString();
        int newPid = int.Parse(Pid) + 1;

        com = "INSERT into payment (P_id,shop_id,user_phone,time_date,amount,Sname) VALUES(@ID,@shop,@from,@time,@amount,@sname)";
        cmd = new SqlCommand(com, conn);
        cmd.Parameters.AddWithValue("@ID", newPid);
        cmd.Parameters.AddWithValue("@shop", shopid);
        cmd.Parameters.AddWithValue("@from", phone);
        cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString());
        cmd.Parameters.AddWithValue("@amount",Amount.Text);
        cmd.Parameters.AddWithValue("@sname",Snames.Text);
        cmd.ExecuteNonQuery();
    }

    public void updateUser()
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

    public void updateShop()
    {
        string newamount = (float.Parse(shopamount) + float.Parse(Amount.Text)).ToString();
        string com = "UPDATE shops SET amount = @newValue WHERE Shop_ID=@shopid";
        SqlCommand cmd = new SqlCommand(com, conn);
        cmd.Parameters.AddWithValue("@newValue", newamount);
        cmd.Parameters.AddWithValue("@shopid", shopid);
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