using BlogWebAPI.Data;
using BlogWebAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BlogWebAPI.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private BlogContext _context;

        public CategoryRepository(BlogContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Category> GetCategory(string category)
        {
            return _context.Categories
                .Where(c => c.Name == category)              
                .ToList();
        }        
    }
}
