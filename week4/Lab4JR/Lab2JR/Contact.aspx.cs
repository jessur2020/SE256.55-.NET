using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab2JR.App_Code;
namespace Lab2JR
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            Street1.Text = "";
            Street2.Text = "";
            City.Text = "";
            State.Text = "";
            ZipCode.Text = "";
            Email.Text = "";
            PhoneNumber.Text = "";
            Output.Text = "";

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
      Person p = new Person(FirstName.Text, LastName.Text, Street1.Text, Street2.Text, City.Text ,State.Text, ZipCode.Text, Email.Text, PhoneNumber.Text);
            Session["person"] = p;

        }
    }
}