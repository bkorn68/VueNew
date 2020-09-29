using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWithLoginAPI.Models;

namespace ToDoWithLoginAPI.Misc
{
    public static class UsersConverter
    {
        internal static UsersDTO ToDTO(this Users users)
        {
            return new UsersDTO()
            {
                Id = users.Id,
                Name = users.Name,
                EmailAddress = users.EmailAddress,
                Password = CryptographyHelpers.Encrypt(Data.password, Data.salt, users.PasswordHash)

            };

        }
        internal static Users FromDTO(this UsersDTO usersDTO)
        {
            return new Users()
            {
                Id = usersDTO.Id,
                Name = usersDTO.Name,
                EmailAddress = usersDTO.EmailAddress,
                PasswordHash = CryptographyHelpers.Encrypt(Data.password, Data.salt, usersDTO.Password)

            };

        }
    }
}
