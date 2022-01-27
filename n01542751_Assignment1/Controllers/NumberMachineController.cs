using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01542751_Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //GET api/NumberMachine/id
        public int Get(int id)
        {
            var add = id + 2;
            var sub = add-3;
            var multi = sub * 5;
            var div= multi / 5;
            return div;
        } 

    }
}
