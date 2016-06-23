<%@ Page Title="Main Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="Project_1.Admin.MainMenu" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="row">

            <div class="col-md-offset-3 col-md-6">

                <h1>Main Menu</h1>

                <div class="well">

                    <h3><i class="fa fa-leanpub fa-lg"></i> Game 1</h3>

                    <div class="list-group">

                        <a class="list-group-item" href="/Admin/Game1.aspx"><i class="fa fa-th-list"></i> Game List</a>

                        <a class="list-group-item" href="/Admin/Game1_Details.aspx"><i class="fa fa-plus-circle"></i> Add Game</a>

                    </div>

                </div>

                <div class="well">

                    <h3><i class="fa fa-book fa-lg"></i> Game 2</h3>

                    <div class="list-group">

                        <a class="list-group-item" href="/Admin/Game2.aspx"><i class="fa fa-th-list"></i> Game List</a>

                        <a class="list-group-item" href="/Admin/Game2_Details.aspx"><i class="fa fa-plus-circle"></i> Add Game</a>

                    </div>

                </div>

                <div class="well">

                    <h3><i class="fa fa-puzzle-piece fa-lg"></i> Game 3</h3>

                    <div class="list-group">

                        <a class="list-group-item" href="/Admin/Game3.aspx"><i class="fa fa-th-list"></i> Game List</a>

                        <a class="list-group-item" href="/Admin/Game3_Details.aspx"><i class="fa fa-plus-circle"></i> Add Game</a>

                    </div>

                </div>

                <div class="well">

                    <h3><i class="fa fa-puzzle-piece fa-lg"></i> Game 4</h3>

                    <div class="list-group">

                        <a class="list-group-item" href="/Admin/Game4.aspx"><i class="fa fa-th-list"></i> Game List</a>

                        <a class="list-group-item" href="/Admin/Game4_Details.aspx"><i class="fa fa-plus-circle"></i> Add Game</a>

                    </div>

                </div>

            </div>

        </div>

    </div>
</asp:Content>