using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
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
                username= cookie["UserName"];
                pass = cookie["Password"];
                amount = cookie["Amount"];
                email = cookie["Email"];

                Label1.Text = username;
                Label2.Text = email;
                Label3.Text = "Phone:" + phone;
                Label4.Text = amount + "Taka";

            }

        }
 

    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        if (cookie != null)
        {
            cookie.Expires = DateTime.Now.AddDays(-1);
        }
        Response.Redirect("Default.aspx");
    }

    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("history.aspx");
    }

    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Response.Redirect("editProfile.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("paymentop.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("SendMoney.aspx");
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        //cashin
        Response.Redirect("CashIn.aspx");
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        //mobile recharge
        Response.Redirect("MobRecharge.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        //cashout
        Response.Redirect("cashOut.aspx");
    }
}