using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models 
{ 
    public class MyDbContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        } 

    }
}