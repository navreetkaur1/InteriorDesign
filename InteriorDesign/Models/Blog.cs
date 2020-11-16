using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorDesign.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]

        public string gender { get; set; }

        public string discription { get; set; }

        public string image { get; set; }
        [Display(Name = "Categories")]
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
