using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Data;
using api.Models;


namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ApiDbContext _dbcontext;

        FileController(ApiDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            var list = _dbcontext.Archive.


        }
    }
}