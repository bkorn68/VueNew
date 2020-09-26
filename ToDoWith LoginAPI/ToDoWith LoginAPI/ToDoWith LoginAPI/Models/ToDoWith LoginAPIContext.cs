using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWith_LoginAPI.Models
{
    public class ToDoWith_LoginAPIContext : DbContext
    {
        public ToDoWith_LoginAPIContext(DbContextOptions<ToDoWith_LoginAPIContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
