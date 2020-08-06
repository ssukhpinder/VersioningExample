using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersioningExample.Controllers.V2
{
    [ApiVersion("2")]
    [Route("api/[controller]/v{v:apiVersion}")]
    [ApiController]
    public class UrlVersioningController : ControllerBase
    {
        public UrlVersioningController()
        {

        }

        [HttpGet]
        [Route("get")]
        public string Get()
        {
            return "Url versioning example v2";
        }
    }
}
