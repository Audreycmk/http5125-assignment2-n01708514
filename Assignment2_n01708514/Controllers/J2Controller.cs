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
        /// 
        /// </summary>
        /// <param name="N"></param>
        /// <param name="pepperNames"></param>
        /// <returns></returns> <summary>
        /// curl -X 'GET' \
//   'http://localhost:5159/api/J2/ChiliPeppers?N=4&pepperNames=Poblano&        pepperNames=Cayenne&pepperNames=Thai&pepperNames=Poblano' \
//   -H 'accept: text/plain'
        /// </summary>
        /// <param name="N"></param>
        /// <param name="pepperNames"></param>
        /// <returns></returns>
        [HttpGet("ChiliPeppers")]
        public int ChiliPeppers([FromQuery] int N, [FromQuery] List<string> pepperNames)
        {
    
            List<(string Name, int SHU)> Peppers = new List<(string, int)>
            {
                ("Poblano", 1500),
                ("Mirasol", 6000),
                ("Serrano", 15500),
                ("Cayenne", 40000),
                ("Thai", 75000),
                ("Habanero", 125000)
            };

            int T = 0; 
            for (int i = 0; i < N; i++)
            {
                string pepperName = pepperNames[i];
                var pepper = Peppers.Find(p => p.Name.Equals(pepperName, StringComparison.OrdinalIgnoreCase));
                
                if (pepper != default)
                    {
                        T += pepper.SHU;
                    }
            }
            return T;
        }
    }
}