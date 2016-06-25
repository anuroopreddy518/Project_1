using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
Author Name: Anuroop, Ivan
    Student Number:200265054, 200253631
    Date: 08-06-2016
    Version:1.1
    Discription: Game 1 with details with db connection 
    */

// using statements that are required to connect to EF DB
using Project_1.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;

namespace Project_1.Details
{
    public partial class Game3_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetGames();
            }
        }

        protected void GetGames()
        {
            // populate teh form with existing data from the database
            int GameID = Convert.ToInt32(Request.QueryString["ID"]);

            // connect to the EF DB
            using (ProjectConnection db = new ProjectConnection())
            {
                // populate a game object instance with the gameID from the URL Parameter
                MAIN_GAME updatedGame = (from game in db.MAIN_GAME
                                         where game.GAME_NAME == ID
                                         select game).FirstOrDefault();

                // map the game properties to the form controls
                if (updatedGame != null)
                {
                    GameNameTextBox.Text = updatedGame.GAME_NAME;
                    DescriptionTextBox.Text = updatedGame.DESCRIPTION;
                    TeamATextBox.Text = updatedGame.TEAM_A;
                    TeamBTextBox.Text = updatedGame.TEAM_B;
                    TotalPointsTextBox.Text = updatedGame.TOTAL_POINTS.ToString();
                    SpectatorsTextBox.Text = updatedGame.SPECTATORS.ToString();
                    WinningTeamTextBox.Text = updatedGame.WINNING_TEAM;
                }
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Game3.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to connect to the server
            using (ProjectConnection db = new ProjectConnection())
            {
                // use the game model to create a new game object and
                // save a new record
                MAIN_GAME newGame = new MAIN_GAME();

                int GameID = 0;

                if (Request.QueryString.Count > 0) // our URL has a GameID in it
                {
                    // get the id from the URL
                    GameID = Convert.ToInt32(Request.QueryString["ID"]);

                    // get the current Game from EF DB
                    newGame = (from game in db.MAIN_GAME
                               where game.ID == GameID
                               select game).FirstOrDefault();
                }

                // add form data to the new Game record
                newGame.GAME_NAME = GameNameTextBox.Text;
                newGame.DESCRIPTION = DescriptionTextBox.Text;
                newGame.TEAM_A = TeamATextBox.Text;
                newGame.TEAM_B = TeamBTextBox.Text;
                newGame.TOTAL_POINTS = Convert.ToInt32(TotalPointsTextBox.Text);
                newGame.SPECTATORS = Convert.ToInt32(SpectatorsTextBox.Text);
                newGame.WINNING_TEAM = WinningTeamTextBox.Text;


                // use LINQ to ADO.NET to add / insert new Game into the database

                if (GameID == 0)
                {
                    db.MAIN_GAME.Add(newGame);
                }


                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated Game page
                Response.Redirect("~/Admin/Game3.aspx");
            }
        }
    }
}