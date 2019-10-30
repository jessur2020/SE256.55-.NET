using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week2JR.App_Code
{
    public class validation
    {

        public bool validLoing( string user, string pass)
        {

            if (user == "NEIT" && pass == "Password")
            {
                return true;
            }
            return false;
        }
    }
}