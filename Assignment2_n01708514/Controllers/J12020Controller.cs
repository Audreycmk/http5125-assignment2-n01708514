using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class J12020Controller : ControllerBase
    {
        /// <summary>
        /// Determines if Barley the dog is happy based on the number of small, medium, and large treats.
        /// </summary>
        /// <param name="S">The number of small treats.</param>
        /// <param name="M">The number of medium treats.</param>
        /// <param name="L">The number of large treats.</param>
        /// <returns>
        /// "happy" if the total treat points (1*S + 2*M + 3*L) are 10 or more; otherwise, "sad".
        /// </returns>
        /// <example>
        /// POST: localhost:5159/api/J12020/DogTreats
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: S=3&M=1&L=0 -> sad
        /// </example>
        /// <example>
        /// POST: localhost:5159/api/J12020/DogTreats
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: S=3&M=2&L=1 -> "happy"
        /// </example>

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