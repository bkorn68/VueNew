using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWithLoginAPI.Models
{
    public class ToDoWithLoginAPIContext : DbContext
    {
        public ToDoWithLoginAPIContext(DbContextOptions<ToDoWithLoginAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations for entity

            modelBuilder
                .ApplyConfiguration(new UsersConfiguration());
            modelBuilder
                .ApplyConfiguration(new ToDoItemsConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}

