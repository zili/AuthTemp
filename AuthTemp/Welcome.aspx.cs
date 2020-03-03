using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthTemp
{
    public partial class Welcome : System.Web.UI.Page
    {
        Utilisateur user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (Utilisateur) Session["u"];
            if (user == null)
                Response.Redirect("index.aspx");
            else
                lbUser.Text = user.Login;

        }
    }
}