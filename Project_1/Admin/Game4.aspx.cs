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

namespace Project_1.Admin
{
    public partial class Game4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time, populate the game 1
            if (!IsPostBack)
            {
                Session["SortColumn"] = "StudentID"; // default sort column
                Session["SortDirection"] = "ASC";

                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {

                    // show the Contoso Content area
                    GamePlaceHolder.Visible = true;
                }
                else
                {
                    // only show login and register
                    GamePlaceHolder.Visible = false;

                }
                //SetActivePage();

                // Get the game data
                this.GetGames();
            }
        }

        /**
         * <summary>
         * This method gets the games data from the DB
         * </summary>
         * 
         * @method Getgame1
         * @returns {void}
         */
        protected void GetGames()
        {
            // connect to EF
            using (ProjectConnection db = new ProjectConnection())
            {


                // query the game Table using EF and LINQ
                var Games = (from allgames in db.MAIN_GAME
                             select allgames);

                // bind the result to the GridView
                GameGridView.DataSource = Games.AsQueryable().ToList();
                GameGridView.DataBind();
            }
        }

        /**
         * <summary>
         * This event handler deletes a student from the db using EF
         * </summary>
         * 
         * @method StudentsGridView_RowDeleting
         * @param {object} sender
         * @param {GridViewDeleteEventArgs} e
         * @returns {void}
         */
        protected void GameGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected StudentID using the Grid's DataKey collection
            int gameID = Convert.ToInt32(GameGridView.DataKeys[selectedRow].Values["ID"]);

            // use EF to find the selected student in the DB and remove it
            using (ProjectConnection db = new ProjectConnection())
            {
                // create object of the Student class and store the query string inside of it
                MAIN_GAME deletedStudent = (from gameRecords in db.MAIN_GAME
                                            where gameRecords.ID == gameID
                                            select gameRecords).FirstOrDefault();

                // remove the selected student from the db
                db.MAIN_GAME.Remove(deletedStudent);

                // save my changes back to the database
                db.SaveChanges();

                // refresh the grid
                this.GetGames();
            }
        }

        protected void GameGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    GameGridView.Columns[8].Visible = true;
                }
            }
        }
    }
}