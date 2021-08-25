using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMicroservice.Models;
using MyMicroservice.Repository;

namespace MyMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TestController: ControllerBase
    {

        [HttpGet]
        public string getHello()
        {
            Services.TestServices service = new Services.TestServices();
            return service.getHello();
        }
    }
}
