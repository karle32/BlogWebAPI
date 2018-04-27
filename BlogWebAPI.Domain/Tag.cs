using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Category Category { get; set; }
        //public int CategoryId { get; set; }
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }

    }
}
