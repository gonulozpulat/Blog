using Blog.Dal.Repository;
using Blog.Entities.Entities;

namespace Blog.Services.Services
{
    public class ContactServices
    {
        private readonly ContactRepository _contactRepository;
        public ContactServices()
        {
            _contactRepository = new ContactRepository();
        }        

        public Contact Add(Contact contact) => _contactRepository.AddContact(contact);
            
    }
}
