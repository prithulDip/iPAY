<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signUp.aspx.cs" Inherits="signUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/demoform1.css">
</head>
<body>
<div class="center">
        <h1>SIGN UP</h1>
        <form runat="server">
            <div class="inputbox">
                <asp:TextBox ID="Username" CssClass="textbox" runat="server" TextMode="SingleLine"></asp:TextBox>
                <span>Username</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="Email" CssClass="textbox" runat="server" TextMode="Email"></asp:TextBox>
                <span>Email</span>
            </div>
             <div class="inputbox">
                <asp:TextBox ID="Phone" CssClass="textbox" runat="server" TextMode="Phone"></asp:TextBox>
                <span>Phone</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="Password" CssClass="textbox" runat="server" TextMode="Password"></asp:TextBox>
                <span>Password</span>
            </div>
            <div class="wrap">
                <asp:Button ID="Button1" class="button" runat="server" Text="SUGNUP" OnClick="Button1_Click" />
            </div>  
         <div class="sure">
          <p>Already have an account? <asp:HyperLink CssClass="hyp" runat="server" NavigateUrl="signIn.aspx" Text="LOG IN"></asp:HyperLink></p>
         </div>
            <asp:Label ID="Error" runat="server" Text="Label"></asp:Label>
        </form>
    </div>
</body>
</html>
