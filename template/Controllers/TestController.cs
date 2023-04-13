using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lomo_Template.Interfaces;

namespace Lomo_Template.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        ITestService _testService;
        public TestController(ITestService testService)
        {
            this._testService = testService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res = _testService.GetPerson();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var res = _testService.GetPersonById(id);
            return Ok(res);
        }

        [HttpPost]
        public IActionResult Post([FromBody] object body)
        {
            var res = _testService.CreatePerson(body);
            return Ok(res);
        }
    }
}
