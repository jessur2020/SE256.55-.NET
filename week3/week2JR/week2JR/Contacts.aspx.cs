using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using week2JR.App_Code;

namespace week2JR
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            Output.Text = "";

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            Person p = new Person(FirstName.Text, LastName.Text, Street.Text, City.Text ,State.Text, ZipCode.Text, Email.Text, PhoneNumber.Text);
            Session["person"] = p;
        }
    }
}