using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTest.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string PremierDate { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string Director { get; set; }
    }
}
