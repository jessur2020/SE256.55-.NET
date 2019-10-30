using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class2ExampleWeb.App_Code;

namespace Class2ExampleWeb
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FName = FirstName.Text;
            p.LName = LastName.Text;
            p.Street1 = Street1.Text;
            p.Street2 =Street2.Text;
            p.City =City.Text;
            p.State = State.Text;
            p.Zipcode = Zip.Text;
            p.Email = Email.Text;
            p.Phone = PhoneNumber.Text;
            //Session["person"] = p;
            Croud c = new Croud();
            if (c.addPerson(p))
            {
                SuccessLabel.Visible = true;
                ErrorLabel.Visible = false;
            }
            else
            {
                ErrorLabel.Visible = true;
                SuccessLabel.Visible = false;

            }

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            Street1.Text = "";
            Street2.Text = "";
            City.Text = "";
            State.SelectedIndex = 0;
            Zip.Text = "";
            Email.Text = "";
            PhoneNumber.Text = "";

        }
    }
}