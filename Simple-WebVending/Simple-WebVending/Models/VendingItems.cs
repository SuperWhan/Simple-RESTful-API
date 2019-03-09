using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_WebVending.Models
{
    public class VendingItems
    {
        String ItemName;
        public String Name
        {
            get { return ItemName; }
            set { ItemName = value; }
        }
        String expirtion;
        public String Exp
        {
            get { return expirtion; }
            set { expirtion = value; }
        }
        String registrationNumber;
        public String RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
    }
}