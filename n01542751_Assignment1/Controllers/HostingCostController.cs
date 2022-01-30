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
            int fortNights = (id / 14) + 1 ;
            double subTotal = fortNights * 5.50;
            double tax = Math.Round((subTotal * 0.13),2);
            double total = subTotal + tax;


            /* To display two decimal places , use ToString() as suggested in stackoverflow 
             * (https://stackoverflow.com/questions/533931/convert-double-to-string) 
             as per the suggestion of Visual Studio changing subTotal.ToString("0.00") to subTotal:0.00 */
            string response1 = $"{fortNights} fortnights at $5.50/FN = ${subTotal:0.00} CAD";
            string response2 = $"HST 13% = ${tax} CAD";
            string response3 = $"Total = ${total} CAD";

            return new string[] { response1, response2, response3};
        }
    }
}
