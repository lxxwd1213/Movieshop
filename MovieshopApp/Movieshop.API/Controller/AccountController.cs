﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Movieshop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }
    }
}
