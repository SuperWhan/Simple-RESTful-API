using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Simple_WebVending.Models;

namespace Simple_WebVending.Controllers
{
    public class ItemUpdateController : ApiController
    {
        public String PutStudentRecord(VendingItems item)
        {
            Console.WriteLine("In update item informations");
            return ItemRegistration.GetInstance().UpdateItem(item);
        }
    }
}