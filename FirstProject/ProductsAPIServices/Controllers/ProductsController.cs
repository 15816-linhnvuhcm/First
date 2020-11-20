using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductsAPIServices.Controllers
{
    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
       public IEnumerable<string> Get()
        {
            return new string[] { "Book 1", "Book 2" };
        }
    }
}
