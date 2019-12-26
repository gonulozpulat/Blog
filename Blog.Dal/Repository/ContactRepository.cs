using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class ContactRepository
    {
        public List<Contact> GetAllCategories()
        {
            List<Contact> contacts;
            using (var database = new ProjectContext())
            {
                contacts = database.Contacts.ToList();
            }
            return contacts;
        }
    }
}
