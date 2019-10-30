using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class2ExampleWeb.App_Code;
using System.Reflection;
using System.Data.SqlClient;

namespace Class2ExampleWeb.controls
{
    public partial class ContentMgr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Convert.ToString(Session["Login"]) == "")
            {
                Response.Redirect("../controls/LogIn.aspx");

            }
            try
            {
                // Person p = (Person)Session["person"];
                Croud crud = new Croud();

                SqlDataReader reader = crud.getPeople();


                while (reader.Read())
                {

                

                TableRow r = new TableRow();
               // PropertyInfo[] properties = p.GetType().GetProperties();


                for(int i = 1; i < reader.FieldCount; i++)
                {
                    TableCell c = new TableCell();
                        c.Text = reader[i].ToString();
                    r.Cells.Add(c);
                }
                TableCell edit = addEdit("e-" + reader[0].ToString());
                TableCell delete = addDelete("d-" + reader[0].ToString());
                r.Cells.Add(edit);
                r.Cells.Add(delete);
                Table1.Rows.Add(r);
            }
            }
            catch (Exception)
            {

            }
        }

        public TableCell addEdit(string id)
        {
            TableCell edit = new TableCell();
            Button BtnEdit = new Button();
            BtnEdit.ID = id;
            BtnEdit.Text = "Edit";
            BtnEdit.Click += new EventHandler(btn_Edit);
            edit.Controls.Add(BtnEdit);
            return edit;
        }

        public TableCell addDelete(string id)
        {
            TableCell delete = new TableCell();
            Button BtnDelete = new Button();
            BtnDelete.ID = id;
            BtnDelete.Text = "Delete";
            BtnDelete.Click += new EventHandler(btn_Delete);
            delete.Controls.Add(BtnDelete);
            return delete;
        }
        protected void btn_Delete(object sender, EventArgs e)
        {
            // Session["person"] = "";
            Button b = sender as Button;
            var parts = b.ClientID.Split('-');
            string id = parts[1];
            Croud c = new Croud();
            c.deletePerson(id);
            Response.Redirect("../controls/ContentMgr.aspx");
        }

        protected void btn_Edit(object sender,EventArgs e)
        {
            Button b = sender as Button;
            var parts = b.ClientID.Split('-');
            string id = parts[1];
            Session["id"] = id;
            Response.Redirect("../controls/EditContent.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["Login"] = "";
            Response.Redirect("../controls/LogIn.aspx");
        }
    }
}