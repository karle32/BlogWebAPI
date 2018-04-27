using BlogWebAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Models
{
    public class PostsWithRelatedData
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public int Readtime { get; set; }
        public string Status { get; set; }
        public string Title { get; set; }
        public string AuthorDescription { get; set; }
        public string ImageName { get; set; }
        public string Name { get; set; }
        public List<Tag> TagsName { get; set; }

    }
}
