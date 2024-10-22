using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class J1Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the score based on the number of collisions and deliveries.
        /// </summary>
        /// <param name="Collisions">The number of collisions.</param>
        /// <param name="Deliveries">The number of deliveries.</param>
        /// <returns>The final score at the end of a game, which each collision deducts +10 points, each delivery +50 points, and deliveries > collisions +500.</returns>
        /// <example>
        /// POST: localhost:xx/api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: Collisions=2&Deliveries=5 -> 730
        /// </example>
        /// <example>
        /// POST: localhost:xx/api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Request Body: Collisions=10&Deliveries=0 -> -100
        /// </example>/// 
        
    [HttpPost (template: "Delivedroid")]
    [Consumes ("application/x-www-form-urlencoded")]
    public int Delivedroid ([FromForm] int Collisions, [FromForm] int Deliveries)
    {
        int CollisionsPoint = Collisions * -10;
        int DeliveriesPoint = Deliveries * 50; 
    
    
        if (Deliveries > Collisions)
       {
        return CollisionsPoint + DeliveriesPoint + 500;
       } else
       {    
        return CollisionsPoint + DeliveriesPoint;
       }
        
    }
    }
}