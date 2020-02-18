using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System.Reflection;

namespace MoviesAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        // GET: /About
        [HttpGet]
        public About Get()
        {
            var assembly = Assembly.GetExecutingAssembly().GetName();
            return new About
            {
                AssemblyVerson = assembly.Version.ToString(),
                APIName = assembly.Name,
                APIVersion = "0",
                Owner = "",
                Summary = "",
                Support = "",
            };
        }
    }
}
