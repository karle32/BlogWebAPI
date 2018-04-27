using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogWebAPI.Domain;
using BlogWebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogWebAPI.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private BlogContext _context;

        public AuthorRepository(BlogContext context)
        {
            _context = context;
        }

        public void AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAllAuthors()
        {
             return _context.Authors
                .Include(a => a.BlogPosts)
                .ToList();
        }

        public Author GetAuthorById(int id)
        {
            return _context.Authors
                .Include(a => a.BlogPosts)
                .Where(t => t.Id == id)
                .FirstOrDefault();
        }
    }
}
