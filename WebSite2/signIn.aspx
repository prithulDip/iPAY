<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signIn.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="CSS/demoform1.css">
</head>
<body>
    <div class="center">
        <h1>LOG IN</h1>
        <form runat="server">       
             <div class="inputbox">
                <asp:TextBox ID="Phone" CssClass="textbox" runat="server"></asp:TextBox>
                <span>Phone</span>
            </div>

            <div class="inputbox">
                <asp:TextBox ID="Password" CssClass="textbox" runat="server" TextMode="Password"></asp:TextBox>
                <span>Password</span>
            </div>

            <div class="wrap">
                <asp:Button ID="Button2" class="button" runat="server" Text="LOGIN" OnClick="Button1_Click" />
            </div>  

         <div class="sure">
          <p>Don't have an account? <asp:HyperLink CssClass="hyp" runat="server" NavigateUrl="signUp.aspx" Text="SIGN UP"></asp:HyperLink></p>
         </div>
            <asp:Label ID="Error" runat="server" Text="Label"></asp:Label>
        </form>
    </div>
</body>
</html>
