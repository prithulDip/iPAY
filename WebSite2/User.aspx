<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link rel="stylesheet" href="CSS/user.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" Runat="Server">
   <div class="inner">
        <div class="grid-container">
            <div class="grid-item1">
               
                <div>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/IMG/uIcon.png" Height="350px" Width="350px" />
                   
                    <asp:Label ID="Label1" runat="server" Text="@@@@@"></asp:Label>
                    
                    <asp:Label ID="Label2" runat="server" Text="xxxxxxx@gmail.com"></asp:Label>
                    
                    <asp:Label ID="Label3" runat="server" Text="Phone:xxxxxxx"></asp:Label>
                </div>
              
            </div>
            <div class="grid-item2">
                <div>
                
                    <h3>
                    Your account has
                </h3>
                    <asp:Label ID="Label4" runat="server" Text="999999"></asp:Label>
                </div> 
                          
            </div>
            <div class="grid-item3">
                
                <div>
                    <h1>Services</h1>
                    <hr>
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Send Money</asp:LinkButton>
                    <br >
                    <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Payment</asp:LinkButton>
                    <br >
                    <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">CashOut</asp:LinkButton>
                    <br >
                    <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Mobile Recharge</asp:LinkButton>
                    <br >
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click">CahsIn</asp:LinkButton>

                </div>
            </div>
            <div class="grid-item4">
                <div><asp:LinkButton ID="LinkButton8" runat="server" OnClick="LinkButton8_Click" >HISTORY</asp:LinkButton></div>
            </div>
            <div class="grid-item5">
                <div><asp:LinkButton ID="LinkButton7" runat="server" OnClick="LinkButton7_Click" >EDIT ID</asp:LinkButton>
                </div>
            </div>
            <div class="grid-item6">
                <div> <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LOGOUT</asp:LinkButton>
               </div>
            </div>
        </div> 
   </div>      
</asp:Content>

