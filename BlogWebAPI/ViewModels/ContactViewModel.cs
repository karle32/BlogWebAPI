using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebAPI.ViewModels
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string Company { get; set; }
                
        [Required]
        [StringLength(300, MinimumLength = 5)]
        public string Message { get; set; }

        public DateTime MyProperty { get; set; }
    }
}
