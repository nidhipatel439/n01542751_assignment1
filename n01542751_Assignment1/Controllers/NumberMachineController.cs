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
            int add = id + 2;
            int sub = add-3;
            int multi = sub * 5;
            int div= multi / 5;
            return div;
        } 

    }
}
