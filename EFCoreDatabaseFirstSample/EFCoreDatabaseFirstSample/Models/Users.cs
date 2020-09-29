using System;
using System.Collections.Generic;

namespace EFCoreDatabaseFirstSample.Models
{
    public partial class Users
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
    }
}
