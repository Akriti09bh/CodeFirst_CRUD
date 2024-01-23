using CodeFirst_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_CRUD.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}

   
