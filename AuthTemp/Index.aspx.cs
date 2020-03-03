using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthTemp
{
    public partial class Index : System.Web.UI.Page
    {
        DCDataContext ctx = new DCDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lgn_Authenticate(object sender,
            AuthenticateEventArgs e)
        {
            foreach (Utilisateur u in ctx.Utilisateurs)
            {
                if (u.Login.Equals(lgn.UserName) && u.Pwd.Equals(lgn.Password))
                {
                    Session["u"] = u;
                    e.Authenticated = true;
                }
            }
        }

    }

}


            
        
    
