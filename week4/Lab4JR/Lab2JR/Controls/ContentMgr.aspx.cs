using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab2JR.App_Code;
namespace Lab2JR.Controls
{
    public partial class ContentMgr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(Session["loggedin"]))
            {
                Response.Redirect("../Controls/Login.aspx");
            }

            try
            {
                Person P = (Person)Session["person"];
                if (P != null)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Person Loaded')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Person Loaded')", true);
                }
            }
            catch (Exception err)
            {

            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["loggedin"] = false;
            Response.Redirect("../Controls/Login.aspx");

        }
    }
}