using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01542751_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        //GET api/HostingCost/id
        public IEnumerable<string> Get(int id)
        {
            var fortNights = ((int)(id / 14)) + 1 ;
            var subTotal = fortNights * 5.50;
            var tax = Math.Round((subTotal * 0.13),2);
            var total = subTotal + tax;

            /* To display two decimal places , use String.Format as suggested in stackoverflow 
             * (https://stackoverflow.com/questions/10749506/two-decimal-places-using-c-sharp/10749520) */
            return new string[] { $"{fortNights} fortnights at $5.50/FN = ${String.Format("{0:.00}",subTotal)} CAD" , 
                $"HST 13% = ${tax} CAD" ,
                $"Total = ${total} CAD"
            };
        }
    }
}
