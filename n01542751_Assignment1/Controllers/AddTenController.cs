using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01542751_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET api/AddTen/id
        public int Get(int id)
        {
            var addition = id + 10;
            return addition;
        }
    }
}
