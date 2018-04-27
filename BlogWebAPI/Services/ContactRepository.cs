using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebAPI.Domain;
using BlogWebAPI.Data;

namespace BlogWebAPI.Services
{
    public class ContactRepository : IContactRepository
    {
        private BlogContext _context;

        public ContactRepository(BlogContext context)
        {
            _context = context;
        }

        public void AddContact(Contact contact)
        {
            contact.Created = DateTime.Now;
             _context.Add(contact);
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        public Contact GetContactById(int id)
        {
            return _context.Contacts.FirstOrDefault(t => t.Id == id);
        }

        public void SaveContact()
        {
            _context.SaveChanges();
        }
    }
}
