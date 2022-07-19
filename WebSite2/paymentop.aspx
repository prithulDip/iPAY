<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="paymentop.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="CSS/payment.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="Server">
    <div class="inner">
        <div><h1 style="text-transform:uppercase; font-family:Bahnschrift; ">Happy shopping..!</h1></div>
        <hr style="border-top: 5px solid black;">
        <div class="grid-container">

            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/aarong.jpg" OnClick="aarong" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/bata.jpeg" OnClick="bata" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/apex.png" OnClick="apex" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/Chillox.png" OnClick="chillox" />
                </div>
            </div>
             <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/Ryans.png" OnClick="ryans" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/Startech.png" OnClick="startech" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/gAndG.png" OnClick="gandg" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton8" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/shawpno.png" OnClick="shawpno" />
                </div>
            </div>
             <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton9" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/pran.png" OnClick="pran" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/RFL.png" OnClick="rfl" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton11" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/otobi.png" OnClick="otobi" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton12" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/HATIL.jpg" OnClick="hatil" />
                </div>
            </div>
             <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton13" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/heartfoundation.jpg" OnClick="heartfoundation" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton14" runat="server" ImageUrl="~/IMG/Icons/squareHos.jpg" Height="200px" Width="200px" OnClick="shos" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton15" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/hotel1.jpg" OnClick="hotel1" />
                </div>
            </div>
            <div class="grid-item1">
                <div>
                    <asp:ImageButton ID="ImageButton16" runat="server" Height="200px" Width="200px" ImageUrl="~/IMG/Icons/hotel2.png"  OnClick="hotel2" />
                </div>
            </div>
        </div>
        <div><p style="font-family:'Bookman Old Style'; font-weight:bold;">NOTE:We have partenership with these companise.
            Oue users can payment to this shops throuhg iPay.
             </p></div>
    </div>
</asp:Content>

