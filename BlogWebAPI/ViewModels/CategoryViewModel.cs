using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<PostsViewModel> Posts { get; set; }
            = new List<PostsViewModel>();
    }
}
