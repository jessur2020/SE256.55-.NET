using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class2ExampleWeb.App_Code;

namespace Class2ExampleWeb.controls
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Convert.ToString(Session["Login"]) == "true")
            {
                Response.Redirect("../controls/ContentMgr.aspx");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Validation val = new Validation();
            if (val.validLogin(UserName.Text, password.Text))
            {
                Session["Login"] = "true";
                Response.Redirect("../controls/ContentMgr.aspx");
            }else
            {
                ErrorLabel.Visible = true;
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            password.Text = "";
        }
    }
}