using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class J32024Controller : ControllerBase
    {
        /// <summary>
        /// Determines the score required for bronze level and how many participants achieved this score.
        /// </summary>
        /// <param name="N">The number of participants.</param>
        /// <param name="scores">A list of participant scores.</param>
        /// <returns>
        /// A string containing the bronze score and the number of participants who achieved it.
        /// </returns>
        /// <example>
        /// GET: localhost:5159/api/J32024/BronzeCount?N=4&scores=70&scores=62&scores=58&scores=73 -> 62 1
        /// </example>
        /// <example>
        /// GET: localhost:5159/api/J32024/BronzeCount?N=8&scores=75&scores=70&scores=60&scores=70&scores=70&scores=60&scores=75&scores=70 -> 60 2
        /// </example>
        /// 
        [HttpGet(template:"BronzeCount")]
        public string BronzeCount (int N, [FromQuery] List<int> scores)
        {
            scores.Sort((a, b) => b.CompareTo(a));

            List<int> uniqueScores = scores.Distinct().ToList();

            int bronzeScore = uniqueScores[2];
            int bronzeCount = scores.Count(x => x == bronzeScore);
            
            return $"{bronzeScore} {bronzeCount}";
        }       
    }       
}