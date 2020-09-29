using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWithLoginAPI.Models
{
    public partial class User
    {
        public User()
        {
        }

        public User(int id)
        {
            Id = id;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
    }
}
