using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TestController: ControllerBase
    {

        [HttpGet]
        public string getHello()
        {
            return "Hello this is a Test controller.";
        }

        [HttpGet]
        public string getTest()
        {
            Services.TestServices service = new Services.TestServices();
            var result = service.getHello();
            return result;
        }
    }
}
