using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using TicketSalesWebApp.Models;


namespace TicketSalesWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {
        
        [HttpPost]
        public async Task<ActionResult<Registration>> CreateAsync([FromBody] Registration registration)
        {
            
            return Ok(registration);
        }
    }
}