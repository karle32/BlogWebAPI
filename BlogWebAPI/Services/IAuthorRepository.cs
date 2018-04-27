using BlogWebAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Services
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllAuthors();

        Author GetAuthorById(int id);

        void AddAuthor(Author post);
    }
}
