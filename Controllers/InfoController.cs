using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.InteropServices;

namespace WA9.Controllers
{
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        [Route("/getinfo")]
        public IActionResult GetInfo()
        {
            var dotnetRuntimeVersion = Environment.Version.ToString();
            var dotnetBitVersion = RuntimeInformation.FrameworkDescription;
            // var dotnetRuntimeVersion = RuntimeInformation.FrameworkDescription;

            var info = new
            {
                DotnetBitVersion = dotnetBitVersion,
                DotnetRuntimeVersion = dotnetRuntimeVersion
            };

            return Ok(info);
        }
    }
}
