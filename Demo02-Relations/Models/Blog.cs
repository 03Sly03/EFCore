using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Relations.Models
{
    internal class Blog
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? SiteUri { get; set; }
        public List<Post>? Posts { get; set;} = new List<Post>();
        public BlogHeader? Header { get; set; }
        public List<BlogTag>? BlogTags { get; set;} = new List<BlogTag>();
    }
}
