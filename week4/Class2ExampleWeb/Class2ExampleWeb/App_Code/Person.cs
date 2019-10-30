using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class2ExampleWeb.App_Code
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, string St1, string St2, string city, string state, string zip, string email, string phone)
        {
            FName = firstName;
            LName = lastName;
            Street1 = St1;
            Street2 = St2;
            City = city;
            State = state;
            Zipcode = zip;
            Email = email;
            Phone = phone;

        }

    }
}