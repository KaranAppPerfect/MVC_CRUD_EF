using Microsoft.EntityFrameworkCore;
using StudentCrudApp.Models;

namespace StudentCrudApp.Context{

    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

        }

        public DbSet<Student> students {get; set;} = null!;

    }


}