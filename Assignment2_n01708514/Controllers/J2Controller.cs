using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class J2Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the total spiciness of the chili based on the peppers added.
        /// </summary>
        /// <param name="Ingredients">A comma-separated list of pepper names.</param>
        /// <returns>
        /// The total spiciness of the chili in Scoville Heat Units (SHU).
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/J2/ChiliPeppers&Ingredients=Poblano,Cayenne,Thai,Poblano -> 118000
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/J2/ChiliPeppers&Ingredients=Habanero,Habanero,Habanero,Habanero,Habanero -> 625000
        /// </example>
        
        [HttpGet(template:"ChiliPeppers")]
        public int GetChiliSpiciness([FromQuery] string Ingredients)
        {
            Dictionary<string, int> PepperSHU = new Dictionary<string, int>
        {
            { "Poblano", 1500 },
            { "Mirasol", 6000 },
            { "Serrano", 15500 },
            { "Cayenne", 40000 },
            { "Thai", 75000 },
            { "Habanero", 125000 }
        };

            var peppers = Ingredients.Split(',');
            int totalSHU = peppers.Sum(pepper => PepperSHU.ContainsKey(pepper) ? PepperSHU[pepper] : 0);
            return totalSHU;
        }
    }
}