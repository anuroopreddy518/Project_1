<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project_1.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- 
Author Name: Anuroop, Ivan
    Student Number:200265054, 200253631
    Date: 08-06-2016
    Version:1.1
    Discription: Default Page to track games
    -->
    <div class="container bg">
        <div class="row">
            <div class="col-md-offset-2 col-md-8" style="padding-top:15%;">
                <div class="text-center" style="color:white; font-size: 30px; font-weight:200;">
                 <h1>WELCOME</h1>
                 <h1>TO</h1>
                 <h1>GAME ZONE</h1>
                </div>
                <div>
                    <a href="/Login.aspx" class="btn btn-info center-block" style="width:30%" role="button">Login</a>  
                    <br />
                    
                    <a href="/Register.aspx" class="btn btn-info center-block" style="width:30%" role="button">Register</a>  
                </div>                                  
            </div>
        </div>
    </div>

    <style>
        .navbar{
            display:none;
        }
    </style>
</asp:Content>
