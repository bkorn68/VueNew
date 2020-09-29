using System;
using System.Collections.Generic;

namespace EFCoreDatabaseFirstSample.Models
{
    public partial class TodoItems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
    }
}
