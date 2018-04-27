using BlogWebAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogWebAPI.Services
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPost> GetAllPosts();

        BlogPost GetBlogPostById(int id);

        IEnumerable<Category> GetBlogPostByCategory(int id);

        void AddBlogPost(BlogPost post);        
    }
}
