using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SignUpForm_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : Controller
    {
        public CustomersController()
        {

        }
        public Task<ActionResult<JObject>> PostAsnyc(JObject data)
        {
            return null;
        }
    }
}
