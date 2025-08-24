using Microsoft.EntityFrameworkCore;
using Todo_API.Models;

namespace Todo_API.Data
{

    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
        : base(options)
        {
            //Empty for now :)
        }

        //DB for todolist.
        public DbSet<ToDo> ToDoList { get; set; }
    }


}