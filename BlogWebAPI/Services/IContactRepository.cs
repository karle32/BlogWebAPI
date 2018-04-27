using BlogWebAPI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebAPI.Services
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();

        Contact GetContactById(int id);

        void AddContact(Contact contact);

        void SaveContact();
    }
}
