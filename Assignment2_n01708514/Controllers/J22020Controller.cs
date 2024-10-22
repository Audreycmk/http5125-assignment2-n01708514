using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class J22020Controller : ControllerBase
    {
        /// <summary>
        /// Determines the first day on which the total number of people who have had the disease exceeds P.
        /// </summary>
        /// <param name="P">The threshold of total infections.</param>
        /// <param name="N">The number of people initially infected on Day 0.</param>
        /// <param name="R">The number of people each infected person infects the next day.</param>
        /// <returns>
        /// The number of the first day on which the total number of people who have had the disease is greater than P.
        /// </returns>
        /// <example>
        /// POST: localhost:5159/api/J22020/Epidemiology
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: P=750&N=1&R=5 -> 4
        /// </example>
        /// <example>
        /// POST: localhost:5159/api/J22020/Epidemiology
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: P=10&N=2&R=1 -> 5
        /// </example>

        [HttpPost(template:"Epidemiology")]
        [Consumes("application/x-www-form-urlencoded")]
        public int Epidemiology([FromForm] int P, [FromForm] int N, [FromForm] int R)
       {
            int totalInfected = N;
            int newInfected = N;
            int day = 0;

            while (totalInfected <= P)
            {
                day++;
                newInfected *= R;
                totalInfected += newInfected;
            }

            return day;
        }
    }
}