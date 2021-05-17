using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    [ApiVersion("2.0")]
    public class DefaultController : ControllerBase
    {
        string[] authors = new string[]
        {
            "Yosi Osi","Jaden Smith","Stephen og" 
        };
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return authors;
        }
        [HttpGet("{id}")]
        [MapToApiVersion("2.0")]
        public string Get(int id)
        {
            return authors[id];
        }                                                                                                                                                                                                                                                                                                          
    }
}
