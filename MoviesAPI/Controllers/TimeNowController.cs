using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TimeNowController : ControllerBase
    {
        // GET: /TimeNow
        [HttpGet]
        public TimeNow Get()
        {
            return new TimeNow
            {
                UTCTime = DateTime.UtcNow.ToString(),
                LocalTime = DateTime.Now.ToString(),
            };
        }
    }
}
