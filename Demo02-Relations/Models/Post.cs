using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Relations.Models
{
    internal class Post
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public DateTime PublishedOn { get; set; } = DateTime.Now;
        public bool Archived { get; set; } = false;
        public int BlogId { get; set; } // facultatif permet d'avoir une id du blog lié au post. Il faudra forcément un Blog valide relié au post. (si on met un ? après le type ce sera pas le cas)
        public Blog? Blog { get; set; } 
    }
}
