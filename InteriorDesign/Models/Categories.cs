using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorDesign.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required]
        
        public string Discription { get; set;} 
        

        public string Areas { get; set;}

        public List<Blog> Blogs { get; set; }
    }
    
}
