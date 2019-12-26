using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Helpers.Extensions
{
    public static class UserExtensions
    {
        public static List<UserDTO> GetUserDTO(this IEnumerable<User> users)
        {
            var userDTO = users.Select(user => new UserDTO
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password
            }).ToList();

            return userDTO;
        }
    }
}
