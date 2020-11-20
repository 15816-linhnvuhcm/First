using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAPIServices.Controllers
{
    [Route("api/[Controller]")]
    public class CustomersController : Controller
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Linh Nguyen", "Phu Nguyen" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Day la - {id}";
        }
    }
}
