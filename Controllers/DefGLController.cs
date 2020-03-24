using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("sis/openCore/api/lut-mgmt/[controller]")]
    public class DefGLController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "GL 1", "GL 2", "GL 3", "GL 4", "GL 5", "GL 6", "GL 7", "GL 8", "GL 9", "GL 10"
        };

        private readonly ILogger<DefGLController> _logger;

        public DefGLController(ILogger<DefGLController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<GLDef> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 7).Select(index => new GLDef
            {
                OpenDate = DateTime.Now,
                Nature = rng.Next(5),
                Desc = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpDelete]
        public IEnumerable<GLDef> Delete()
        {
            var rng = new Random();
            return Enumerable.Range(1, 7).Select(index => new GLDef
            {
                OpenDate = DateTime.Now,
                Nature = rng.Next(5),
                Desc = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        
    }
}