<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game1.aspx.cs" Inherits="Project_1.Game1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Game Details</h1>
                <a href="Game1_Details.aspx" class="btn btn-success btn-sm"><i class="fa fa-plus"></i>Add Game</a>

                <div>

                </div>

                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                    ID="GameGridView" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="Game ID" Visible="true"/>
                        <asp:BoundField DataField="GAME_NAME" HeaderText="Game Name" Visible="true"/>
                        <asp:BoundField DataField="DESCRIPTION" HeaderText="Description" Visible="true"/>
                        <asp:BoundField DataField="TEAM_A" HeaderText="Team A" Visible="true"/>
                        <asp:BoundField DataField="TEAM_B" HeaderText="Team B" Visible="true"/>
                        <asp:BoundField DataField="TOTAL_POINTS" HeaderText="Total points" Visible="true"/>
                        <asp:BoundField DataField="SPECTATORS" HeaderText="Spectators" Visible="true"/>
                        <asp:BoundField DataField="WINNING_TEAM" HeaderText="Winning Team" Visible="true"/>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
