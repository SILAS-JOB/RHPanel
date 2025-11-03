using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;


namespace api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly Employer? _employer;
        private readonly Admin? _admin;

        public UserController(Employer employer, Admin admin)
        {
            _employer = employer;
            _admin = admin;
        }

        [HttpGet]
        public void Find()
        {
            
        }

        [HttpPost]
        public string Create()
        {

            return "Pilas";
        }

        [HttpGet]
        [Route("/target/[controller]")]
        public string Pilas()
        {
            return "oll";
        }
    }
}