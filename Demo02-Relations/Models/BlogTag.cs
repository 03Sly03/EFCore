using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Relations.Models
{
    internal class BlogTag
    {
        public int Id { get; set; } // Possible de faire une PRIMARY KEY composite
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
        public int TagId { get; set; }
        public Tag? Tag { get; set; }

    }
}
