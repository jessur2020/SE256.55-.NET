using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week2JR.App_Code
{
    public class Person
    {
        public Person(string fname, string lname, string street, string city, string state, string zipCode, string email, string phone)
        {
            Fname = fname;
            Lname = lname;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Email = email;
            Phone = phone;
        }



        string Fname { get; set; }
        string Lname { get; set; }
        string Street{ get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        string Email{ get; set; }
        string Phone { get; set; }



    }
}