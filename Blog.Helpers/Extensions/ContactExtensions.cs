using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Helpers.Extensions
{
    public static class ContactExtensions
    {
        public static List<ContactDTO> GetContactDTO(this IEnumerable<Contact> contacts)
        {
            var contactDTO = contacts.Select(contact => new ContactDTO
            {
                Name = contact.Name,
                Surname = contact.Surname,
                Email = contact.Email,
                Message =contact.Message
            }).ToList();

            return contactDTO;
        }
    }
}
