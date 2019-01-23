using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailApi.Controllers
{
    [Route("api/[controller]/send")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        [Route("plain")]
        public IActionResult Plain()
        {
            return Ok();
        }

        [HttpPost]
        [Route("html")]
        public IActionResult Html()
        {
            return Ok();
        }

        [HttpPost]
        [Route("ReminderEveryXDateTimeUntilDateTime")]
        public IActionResult ReminderEveryXDateTimeUntilDateTime()
        {
            return Ok();
        }

        [HttpPost]
        [Route("ReminderOnDateTime")]
        public IActionResult ReminderOnDateTime()
        {
            return Ok();
        }
    }
}