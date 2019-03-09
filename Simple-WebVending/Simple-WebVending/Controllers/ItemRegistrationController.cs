using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Simple_WebVending.Models;

namespace Simple_WebVending.Controllers
{
    public class ItemRegistrationController : ApiController
    {

        public CustomerReply registerItem(VendingItems Itemreg)
        {
            Console.WriteLine("In register New Item");
            CustomerReply Itemreply = new CustomerReply();
            ItemRegistration.GetInstance().Add(Itemreg);
            Itemreply.Name = Itemreg.Name;
            Itemreply.Exp = Itemreg.Exp;
            Itemreply.RegistrationNumber = Itemreg.RegistrationNumber;
            Itemreply.RegistrationStatus = "Successful";
            return Itemreply;
        }
    } 
}

