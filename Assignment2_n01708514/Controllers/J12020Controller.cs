using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class J1Controller2020 : ControllerBase
    {
        [HttpPost (template: "DogTreats")]
        [Consumes ("application/x-www-form-urlencoded")]
        public string DogTreats ([FromForm] int S, [FromForm] int M, [FromForm] int L)
        {
            bool BarleyHappy = 1 * S + 2 * M + 3 * L >= 10;
                if (BarleyHappy) {
                    return "happy";
                } else {
                    return "sad";
                }
        }
    }
}