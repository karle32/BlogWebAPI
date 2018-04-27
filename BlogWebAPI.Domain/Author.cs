using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
            = new List<BlogPost>();
    }
}
