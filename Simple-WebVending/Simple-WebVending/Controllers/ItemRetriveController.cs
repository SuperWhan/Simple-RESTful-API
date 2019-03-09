using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Simple_WebVending.Models;

namespace Simple_WebVending.Controllers
{
    public class ItemRetriveController : ApiController
    {

        public List<VendingItems> GetAllItemss()
        {
            return ItemRegistration.GetInstance().GetAllItems();
        }
    }
}
