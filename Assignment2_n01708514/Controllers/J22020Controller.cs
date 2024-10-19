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
        [HttpPost(template:"Epidemiology")]
        [Consumes("application/x-www-form-urlencoded")]
        public string Epidemiology([FromForm] int P, [FromForm] int N, [FromForm] int R)
       {
            int totalInfected = N;
            int newInfected = N;
            int days = 0;

            while (totalInfected <= P)
            {
                days++;
                newInfected *= R;
                totalInfected += newInfected;
            }

            return days.ToString();
        }
    }
}