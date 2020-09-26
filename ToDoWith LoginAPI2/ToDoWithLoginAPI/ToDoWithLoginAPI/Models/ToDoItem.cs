using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWithLoginAPI.Models
{
    public partial class TodoItem
    {
        public TodoItem()
        {
        }

        public TodoItem(int id)
        {
            Id = id;
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}
