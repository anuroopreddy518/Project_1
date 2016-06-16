using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// using statements that are required to connect to EF DB
using Project_1.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;


namespace Project_1
{
    public partial class Game1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time, populate the student grid
            if (!IsPostBack)
            {
                Session["SortColumn"] = "StudentID"; // default sort column
                Session["SortDirection"] = "ASC";
                // Get the student data
                this.GetGames();
            }
        }

        /**
         * <summary>
         * This method gets the games data from the DB
         * </summary>
         * 
         * @method GetStudents
         * @returns {void}
         */
        protected void GetGames()
        {
            // connect to EF
            using (DefaultConnection db = new DefaultConnection())
            {
               

                // query the Students Table using EF and LINQ
                var Games = (from allgames in db.MAIN_GAME
                                select allgames);

                // bind the result to the GridView
                GameGridView.DataSource = Games.AsQueryable().ToList();
                GameGridView.DataBind();
            }
        }
    }
}