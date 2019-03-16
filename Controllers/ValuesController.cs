using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CoreConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IConfiguration _config;
        public ValuesController(IConfiguration config)
        {
            _config = config;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string CmdLineConfigValue =_config.GetValue<string>("cmdlinearg") ?? "No Cmd Line Value Set";

            return new string[] { CmdLineConfigValue, "Test Change", "value red", "value blue", "test" };
        }
    }
}
