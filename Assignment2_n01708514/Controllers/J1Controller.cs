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
        /// Receives an HTTP GET request with one query parameter and provides a new date by adding a specified number of days to January 1, 2000.
        /// </summary>
        /// curl -X 'POST' \
  curl 'http://localhost:5159/api/J1/Delivedroid' -H 'Content-Type: application/x-www-form-urlencoded' -d 'Collisions=2&Deliveries=5'   /// 
        /// <returns>A string representing the new date in "yyyy-MM-dd" format.</returns>
        /// <example>
        /// GET api/q7/timemachine?days=1 -> 2000-01-02
        /// GET api/q7/timemachine?days=-1 -> 1999-12-31
        /// </example>
        
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