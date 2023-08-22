using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Relations.Models
{
    internal class BlogHeader
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
    }
}
