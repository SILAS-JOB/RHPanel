using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using api.Data;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly ApiDbContext _dbContext;

        public UserController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            var list = _dbContext.Employers.ToList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult FindEmployee(int id)
        {
            var emp = _dbContext.Employers.Find(id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employer employer)
        {
            _dbContext.Employers.Add(employer);
            _dbContext.SaveChanges();
            return CreatedAtAction(nameof(FindEmployee), new { id = employer.Id }, employer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var emp = await _dbContext.Employers.FindAsync(id);
            if (emp == null) return NotFound();
            _dbContext.Employers.Remove(emp);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}