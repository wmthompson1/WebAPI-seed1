using WebAPIseed1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_seed1.Models
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Todo.db");
        }

    }

}
