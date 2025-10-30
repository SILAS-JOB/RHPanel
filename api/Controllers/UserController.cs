using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Find()
        {
            return "Hello World";
        }

        [HttpPost]
        public string Create()
        {
            // var funcionario = 
            return "Pilas";
        }
    }
}