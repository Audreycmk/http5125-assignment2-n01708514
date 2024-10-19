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
        /// http://localhost:5159/api/J32024/BronzeCount?N=4&scores=70&scores=62&scores=58&scores=73
        /// </summary>
        /// <param name="N"></param>
        /// <param name="scores"></param>
        /// <returns></returns> <summary>
        /// 
        /// </summary>
        /// <param name="N"></param>
        /// <param name="scores"></param>
        /// <returns></returns>
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