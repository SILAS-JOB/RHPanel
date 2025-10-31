using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }     
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}