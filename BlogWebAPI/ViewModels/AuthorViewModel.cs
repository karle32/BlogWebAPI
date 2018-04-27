using System.Collections.Generic;

namespace BlogWebAPI.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }

        public ICollection<BlogPostViewModel> BlogPosts { get; set; }
            = new List<BlogPostViewModel>();
    }
}
