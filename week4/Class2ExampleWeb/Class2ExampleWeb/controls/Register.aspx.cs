using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class2ExampleWeb.App_Code;

namespace Class2ExampleWeb.controls
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["Login"]) == "true")
            {
                Response.Redirect("../controls/ContentMgr.aspx");
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Croud c = new Croud();
            if (c.register(UserName.Text, password.Text))
            {
                SuccessLabel.Visible = true;
                ErrorLabel.Visible = false;
                clear_Click(null, null);
            }
            else
            {
                ErrorLabel.Visible = true;
                SuccessLabel.Visible = false;
            }
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            password.Text = "";
        }

    }
}