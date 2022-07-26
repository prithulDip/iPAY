﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/demoform1.css">
</head>
<body>
     <div class="center">
        <h1>Payment</h1>
        <form runat="server">
            <div class="inputbox">
                <asp:TextBox ID="ShopName" CssClass="textbox" runat="server" ></asp:TextBox>
                <span>ShopName</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="Snames" CssClass="textbox" runat="server"></asp:TextBox>
                <span>Service Name</span>
            </div>
             <div class="inputbox">
                <asp:TextBox ID="Amount" CssClass="textbox" runat="server"></asp:TextBox>
                <span>Amount</span>
            </div>
            <div class="inputbox">
                <asp:TextBox ID="Password" CssClass="textbox" runat="server"></asp:TextBox>
                <span>Enter Your Password to Confirm</span>
            </div>

            <div class="wrap">
                <asp:Button ID="Button1" class="button" runat="server" Text="Button" OnClick="Button1_Click" />
            </div> 
             <asp:Label ID="Error" runat="server" Text="Label"></asp:Label>
        </form>
    </div>
</body>
</html>
