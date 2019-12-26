using Blog.Entities.DTO;
using Blog.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Helpers.Extensions
{
    public static class ContactExtensions
    {
        public static List<ContactDTO> GetAllContactDTO(this IEnumerable<Contact> contacts)
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

        public static ContactDTO GetContactDTO(this Contact contacts)
        {
            var contactDTO = new ContactDTO
            {
                Name = contacts.Name,
                Surname = contacts.Surname,
                Email = contacts.Email,
                Message = contacts.Message
            };

            return contactDTO;
        }
    }
}
