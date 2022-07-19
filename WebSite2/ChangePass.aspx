<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePass.aspx.cs" Inherits="CSS_ChangePass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/demoform1.css">
</head>
<body>
   <div class="center">
        <h1>Change Passward</h1>
        <form runat="server">
            <div class="inputbox">
                <asp:TextBox ID="pass1" CssClass="textbox" Textmode="Password" runat="server"></asp:TextBox>
                <span>New Password</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="pass2" CssClass="textbox" Textmode="Password" runat="server"></asp:TextBox>
                <span>New Password</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="Password" CssClass="textbox" Textmode="Password" runat="server"></asp:TextBox>
                <span>Enter Your Old Password to Confirm</span>
            </div>

            <div class="wrap">
                <asp:Button ID="Button1" class="button" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
            </div>
        </form>
    </div>
</body>
</html>
