using Blog.Dal.Database;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Blog.Dal.Repository
{
    public class ContactRepository
    {
        public List<Contact> GetAllContact()
        {
            List<Contact> contacts;
            using (var database = new ProjectContext())
            {
                contacts = database.Contacts.ToList();
            }
            return contacts;
        }

        public Contact AddContact(Contact contact)
        {
            using(var database = new ProjectContext())
            {
                contact = database.Contacts.Add(contact);
                database.SaveChanges();
            }
            return contact;

        }
    }
}
