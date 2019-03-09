using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Simple_WebVending.Models;

namespace Simple_WebVending.Controllers
{
    public class ItemDeleteController : ApiController
    {
        [Route("vendingitems/remove/{regnum}")]
        [HttpDelete]
        public String DeleteItem(String regnum)
        {
            Console.WriteLine("In delete Item Record");
            return ItemRegistration.GetInstance().Remove(regnum);
        }
    }
}
