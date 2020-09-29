using System;
using System.Collections.Generic;

namespace ToDoWithLoginAPI.Models
{
    public partial class TodoItems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}
