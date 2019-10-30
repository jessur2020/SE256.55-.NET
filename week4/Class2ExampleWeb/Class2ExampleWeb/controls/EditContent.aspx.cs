using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class2ExampleWeb.App_Code;
using System.Data.SqlClient;

namespace Class2ExampleWeb.controls
{
    public partial class EditContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    // Person p = (Person)Session["person"];
                    Croud c = new Croud();
                    SqlDataReader reader = c.getOnePerson(Convert.ToString(Session["id"]));

                    while (reader.Read()) { 
                        FirstName.Text = reader["FName"].ToString();
                        LastName.Text = reader["LName"].ToString();
                        Street1.Text = reader["Street1"].ToString();
                        Street2.Text = reader["Street2"].ToString();
                        City.Text = reader["City"].ToString();
                        State.Text = reader["State"].ToString();
                        Zip.Text = reader["Zip"].ToString();
                        Email.Text = reader["Email"].ToString();
                        PhoneNumber.Text = reader["Phone"].ToString();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        protected void submit_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FName = FirstName.Text;
            p.LName = LastName.Text;
            p.Street1 = Street1.Text;
            p.Street2 = Street2.Text;
            p.City = City.Text;
            p.State = State.Text;
            p.Zipcode = Zip.Text;
            p.Email = Email.Text;
            p.Phone = PhoneNumber.Text;
            // Session["person"] = p;

            Croud c = new Croud();
            c.updatePerson(p, Convert.ToString(Session["id"]));
            Response.Redirect("../controls/ContentMgr.aspx");

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