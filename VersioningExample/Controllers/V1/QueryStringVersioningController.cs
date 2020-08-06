using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersioningExample.Controllers.V1
{
    [ApiVersion("1")]
    [Route("api/[controller]")]
    [ApiController]
    public class QueryStringVersioningController : ControllerBase
    {
        public QueryStringVersioningController()
        {

        }

        [HttpGet]
        [Route("get")]
        public string Get()
        {
            return "Query string versioning example v1";
        }
    }
}
