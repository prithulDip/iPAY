<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="CSS/indexcontent.css">
    <link rel="stylesheet" href="CSS/font-awesome.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="Server">
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" interval:200>
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img class="d-block w-100" src="IMG/dark.jpg" alt="First slide">
                <div class="carousel-caption d-none d-md-block">
                   <h2>CASH OUT</h2>
                   <p>Easy cash out system.Any point of the World!</p>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="IMG/dark.jpg" alt="Second slide">
                <div class="carousel-caption d-none d-md-block">
                     <h2>MONEY TRANSFER</h2>
                     <p>Fastest and Safest money transfer.!</p>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="IMG/dark.jpg" alt="Third slide">
                <div class="carousel-caption d-none d-md-block">
                    <h2>PAYMENT</h2>
                     <p>Pay your bills for avilable shops.</p>
                 </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="IMG/dark.jpg" alt="Forth slide">
                <div class="carousel-caption d-none d-md-block">
                    <h2>MOBILE RECHARGE</h2>
                      <p>Now you can recharge your phone balance at any time</p>
                 </div>
            </div>
        </div>

    </div>
        <section class="section_one">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="left-side">
                        <div class="image">
                            <img src="IMG/bank.jpg" alt="">
                        </div>
                    </div>
                </div>
                <div class="col-md-5">
                    <div class="right-side">
                        <div class="content">
                            <h3>Banking Partner</h3>
                            <p>
                                We now collaborate with BRACK bank.<br>
                                You can use your BRACK bank card to recharge iPAY account.<br><br>

                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="users">
        <div class="container">
            <div class="row">
                <div class="col-md-5">
                    <div class="text">
                        <h3>Currently...</h3>
                        <p> 
                            We have naw 400+ users<br>
                            Welcome to our family..!
                            <dr>
                            We’re elated to have you onboard of our community. We will continue sending emails (unless you decide to unsubscribe!) to keep you updated on all the latest and greatest news.
                 
                               
                        </p>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="user_img">
                        <img src="IMG/33308.png" alt="">
                    </div>
                </div>
            </div>
        </div>
    </section>
    
    <section class="services">
        <div class="container">
            <div>Our upcoming Features:</div>
            <hr>
            <div class="row">
                <div class="col-md-4">
                    <div class="first_part cl-1">
                        <div class="first_part-img">
                            <img src="IMG/icon-human.png" alt="">
                        </div>
                        <h4>Upload Photo</h4>
                        <p>Upload your profile photo. Face the camera straight on, photo must be in focus and not blurry.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="first_part cl-2">
                        <div class="first_part-img">
                            <img src="IMG/icon-id.png" alt="">
                        </div>
                        <h4>Upload Photo ID</h4>
                        <p>Upload a copy of National ID documents front and back photo. Make sure all information is clearly readable.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="first_part cl-3">
                        <div class="first_part-img">
                            <img src="IMG/icon-bank.png" alt="">
                        </div>
                        <h4>Add Source of Fund</h4>
                        <p>Update your source of fund info to add money from your a/c to shop, send money or transfer.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>

