using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTest.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Year")]
        public string Year { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Price")]
        public string Price { get; set; }

    }
}
