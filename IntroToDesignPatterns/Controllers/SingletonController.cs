using IntroToDesignPatterns.Infra.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToDesignPatterns.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            var singleton = Singleton.Instance;
            return Ok(singleton);
        }
    }
}
