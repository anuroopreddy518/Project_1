<%@ Page Title="Game Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game2_Details.aspx.cs" Inherits="Project_1.Admin.Game2_Details" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Add a Game</h1>
                <h5>All Fields are Required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="GameNameTextBox">Game Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="GameNameTextBox" placeholder="Game Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="DescriptionTextBox">Description</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="DescriptionTextBox" placeholder="Description" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TeamATextBox">Team A</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamATextBox" placeholder="Team A" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TeamBTextBox">Team B</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TeamBTextBox" placeholder="Team B" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="TotalPointsTextBox">Total Points</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TotalPointsTextBox" TextMode="Number" placeholder="Total Points" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="SpectatorsTextBox">Spectators</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="SpectatorsTextBox" placeholder="Spectators" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="WinningTeamTextBox">Winning Team</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="WinningTeamTextBox" placeholder="Winning Team" required="true"></asp:TextBox>
                </div>

                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" 
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click"/>
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
