<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editProfile.aspx.cs" Inherits="editProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/demoform1.css">
</head>
<body>
    <div class="center">
        <h1>Edit Your Profile</h1>
        <form runat="server">
            <div class="inputbox">
                <asp:TextBox ID="Username" CssClass="textbox" runat="server"></asp:TextBox>
                <span>Username</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="Email" CssClass="textbox" runat="server"></asp:TextBox>
                <span>Email</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="Password" CssClass="textbox" Textmode="Password" runat="server"></asp:TextBox>
                <span>Enter Your Password to Confirm</span>
            </div>

            <div class="wrap">
                <asp:Button ID="Button1" class="button" runat="server" Text="SUBMIT" OnClick="Button1_Click" />
            </div>
            <div class="sure">
             <p>Want to change passward <asp:HyperLink CssClass="hyp" runat="server" NavigateUrl="ChangePass.aspx" Text="Click Here"></asp:HyperLink></p>
           </div>
        </form>
    </div>
</body>
</html>
