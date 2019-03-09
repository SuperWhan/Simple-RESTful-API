using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Simple_WebVending.Models;

namespace Simple_WebVending.Controllers
{
    public class ItemGetController : ApiController
    {
        [Route("vendingitems/get/{regnum}")]
        [HttpGet]
        public VendingItems DeleteItem(String regnum)
        {
            Console.WriteLine("In searching Item Record");
            return ItemRegistration.GetInstance().GetItems(regnum);
        }
    }
}