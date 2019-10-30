using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            Street.Text = "";
            City.Text = "";
            State.Text = "";
            ZipCode.Text = "";
            Email.Text = "";
            PhoneNumber.Text = "";
            Output.Text = "";

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                Output.Text = "You must enter a fisrt name";

            }

            else if (LastName.Text == "")
            {
                Output.Text = "You must enter a last name";

            }
            else if (Street.Text == "")
            {
                Output.Text = "You must enter a valid Street";

            }

            else if (City.Text == "")
            {
                Output.Text = "You must enter a valid City";

            }

            else if (State.Text == "")
            {
                Output.Text = "You must enter a valid State";

            }

            else if (ZipCode.Text == "")
            {
                Output.Text = "You must enter a valid Zip Code";

            }

            else if (Email.Text == "")
            {
                Output.Text = "You must enter a valid Email";

            }

            else if (PhoneNumber.Text == "")
            {
                Output.Text = "You must enter a valid Phone Number";

            }
            else
            {
                Output.Text = FirstName.Text + "<br/>" + LastName.Text + "<br/>" + Street.Text + "<br/>" + City.Text + "<br/>" + State.Text
                    + "<br/>" + ZipCode.Text + "<br/>" + Email.Text + "<br/>" + PhoneNumber.Text;

            }

        }
    }
}