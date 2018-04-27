using System.Collections.Generic;

namespace BlogWebAPI.Domain
{
    public class Category
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }

        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
