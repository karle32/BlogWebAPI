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
    public class BlogPostRepository : IBlogPostRepository
    {
        private BlogContext _context;

        public BlogPostRepository(BlogContext context)
        {
            _context = context;
        }

        public void AddBlogPost(BlogPost post)
        {
            _context.Add(post);
            _context.SaveChanges();
        }

        public IEnumerable<BlogPost> GetAllPosts()
        {
            return _context.Posts 
                .Include(p => p.Author)
                .Include(p => p.Categories)
                .Include(p => p.Tags)
                .ToList();
        }

        public IEnumerable<Category> GetBlogPostByCategory(int id)
        {
            return _context.Categories
                .Include(c => c.BlogPost)
                .Where(c => c.Id == id)
                .ToList();
        }

        public BlogPost GetBlogPostById(int id)
        {
            return _context.Posts
                .Include(b => b.Author)
                .Include(b => b.Categories)
                .Include(b => b.Tags)
                .Where(t => t.Id == id)
                .FirstOrDefault();

        }
    }
}
