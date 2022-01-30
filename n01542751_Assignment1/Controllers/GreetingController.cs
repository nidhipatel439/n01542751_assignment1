using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01542751_Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //POST api/Greeting
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        //GET api/Greeting/id
        public string Get(int id)
        {
            string response = $"Greetings to {id} people!";
            return response;
        }
    }
}
