using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab2JR.App_Code;

namespace Lab2JR.Controls
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["loggedin"]))
            {
                Response.Redirect("../Controls/ContentMgr.aspx");
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            validation v = new validation();
            if (v.validLoing(UserName.Text, Password.Text))
            {
                Session["loggedin"] = true;
                Response.Redirect("../Controls/ContentMgr.aspx");
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }
    }
}