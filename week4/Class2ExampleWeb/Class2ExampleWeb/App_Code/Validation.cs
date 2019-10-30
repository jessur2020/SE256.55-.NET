using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Class2ExampleWeb.App_Code
{
    public class Validation
    {
        public Validation()
        {

        }

        public Boolean validLogin(string UserName, string Password)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Logins WHERE UserName=@User AND Password=@Pass", con);
                    cmd.Parameters.AddWithValue("@User", UserName);
                    cmd.Parameters.AddWithValue("@Pass", Password);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }

                    return false;

                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
