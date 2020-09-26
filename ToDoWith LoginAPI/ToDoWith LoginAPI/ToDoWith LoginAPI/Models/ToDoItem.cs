using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWith_LoginAPI.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public bool IsCompleted { get; set; }

    }
}
