using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    HttpCookie cookie; 
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["phone"] != null)
        {
            cookie = Request.Cookies[Session["phone"].ToString()];
            if (cookie != null)
            {
                string username = cookie["UserName"];
               // LB1.Text = username;
                LB2.Visible = true;
                LB3.Text = username;
                LB3.Visible = true;
                LB1.Visible = false;
            }
            else
            {

                LB1.Text = "gg";
                LB2.Visible = true;

            }

        }
        else
        {
            LB1.Text = "LOGIN";
            LB2.Visible = false;
            LB3.Visible = false;
        }
        
    }

    protected void LB1_Click(object sender, EventArgs e)
    {
        if (Session["phone"] == null)
        {
            Response.Redirect("signUp.aspx");

        }
    }

    protected void LB3_Click(object sender, EventArgs e)
    {
       
            Response.Redirect("User.aspx");
        
    }

    protected void LB2_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        if (cookie != null)
        {
            cookie.Expires = DateTime.Now.AddDays(-1);
        }
        Response.Redirect("Default.aspx");
    }
}
