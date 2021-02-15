using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class UserRepository
    {
        public List<User> GetAllUser()
        {
            List<User> users;
            using(var database = new ProjectContext())
            {
                users = database.Users.ToList();
            }
            return users;
        }

        
    }
}
