using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Class2ExampleWeb.App_Code
{
    public class Croud
    {
        public bool register(string User, string Pass)
        {

            try
            {

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Logins (UserName,Password) VALUES (@USER, @Pass)", con);
                    cmd.Parameters.AddWithValue("@User", User);
                    cmd.Parameters.AddWithValue("@Pass", Pass);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool addPerson(Person p)
        {
            try
            {


                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO People (FName,LName,Street1,Street2,City,State,Zip,Email,Phone) VALUES (@FName,@LName,@Street1,@Street2,@City,@State,@Zip,@Email,@Phone)", con);
                    cmd.Parameters.AddWithValue("@FName", p.FName);
                    cmd.Parameters.AddWithValue("@LName", p.LName);
                    cmd.Parameters.AddWithValue("@Street1", p.Street1);
                    cmd.Parameters.AddWithValue("@Street2", p.Street2);
                    cmd.Parameters.AddWithValue("@City", p.City);
                    cmd.Parameters.AddWithValue("@State", p.State);
                    cmd.Parameters.AddWithValue("@Zip", p.Zipcode);
                    cmd.Parameters.AddWithValue("@Email", p.Email);
                    cmd.Parameters.AddWithValue("@Phone", p.Phone);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public SqlDataReader getPeople()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM People", con);
            con.Open();
            return cmd.ExecuteReader();

        }

        public void deletePerson(string id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand($"DELETE FROM People WHERE P_ID={id}", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
    }

        public SqlDataReader getOnePerson(string id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand($"SELECT * FROM People WHERE P_ID ={id}", con);
            con.Open();
            return cmd.ExecuteReader();

        }

        public void updatePerson(Person p, string id)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
            {

                SqlCommand cmd = new SqlCommand($"UPDATE People SET FName=@FName,LName=@LName,Street1=@Street1,Street2=@Street2,City=@City,State=@State,Zip=@Zip,Email=@Email,Phone=@Phone WHERE P_ID ={id}", con);
                cmd.Parameters.AddWithValue("@FName", p.FName);
                cmd.Parameters.AddWithValue("@LName", p.LName);
                cmd.Parameters.AddWithValue("@Street1", p.Street1);
                cmd.Parameters.AddWithValue("@Street2", p.Street2);
                cmd.Parameters.AddWithValue("@City", p.City);
                cmd.Parameters.AddWithValue("@State", p.State);
                cmd.Parameters.AddWithValue("@Zip", p.Zipcode);
                cmd.Parameters.AddWithValue("@Email", p.Email);
                cmd.Parameters.AddWithValue("@Phone", p.Phone);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
    }
}


    