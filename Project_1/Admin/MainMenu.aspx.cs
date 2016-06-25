using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;


namespace Project_1.Admin
{
    public partial class MainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {

                    // show the Contoso Content area
                    GamePlaceHolder.Visible = true;
                    PlaceHolder1.Visible = true;
                    PlaceHolder2.Visible = true;
                    PlaceHolder3.Visible = true;
                }
                else
                {
                    // only show login and register
                    GamePlaceHolder.Visible = false;
                    PlaceHolder1.Visible = false;
                    PlaceHolder2.Visible = false;
                    PlaceHolder3.Visible = false;

                }
                //SetActivePage();
            }
        }
    }
}