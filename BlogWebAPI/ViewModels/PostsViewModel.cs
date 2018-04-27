using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.ViewModels
{
    public class PostsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public int Readtime { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string HeroImage { get; set; }

        public AuthorWithoutPost Author { get; set; }
       
        public ICollection<TagViewModel> Tags { get; set; }
            = new List<TagViewModel>();
    }
}
