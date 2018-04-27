using BlogWebAPI.Domain;
using System.Collections.Generic;

namespace BlogWebAPI.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();

        void AddCategory(Category category);

        IEnumerable<Category> GetCategory(string category);
    }
}
