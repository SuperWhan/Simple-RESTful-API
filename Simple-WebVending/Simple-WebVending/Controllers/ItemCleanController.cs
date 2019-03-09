using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Simple_WebVending.Models;

namespace Simple_WebVending.Controllers
{
    public class ItemCleanController : ApiController
    {
        [Route("vendingitems/cleanmachine")]
        [HttpDelete]
        public String DeleteItem()
        {
            Console.WriteLine("In delete All Item Record");
            return ItemRegistration.GetInstance().RemoveAllItems();
        }
    }
}
