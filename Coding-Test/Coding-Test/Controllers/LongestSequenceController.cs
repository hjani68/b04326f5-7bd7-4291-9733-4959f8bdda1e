using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coding_Test.BusinessService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coding_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LongestSequenceController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("GetLongestIncreasinSequence")]
        public IActionResult GetLongestIncreasinSequence([FromBody] string input)
        {
            return Ok(LongestSequenceService.GetLongestIncreasingSequence(input));
        }
    }
}