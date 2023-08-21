using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01.Models
{
    internal class Student
    {
        // C'est une data anotation pour rajouter un comportement à une propriété (qui est en dessous) celle-ci sert à préciser que la propriété suivante correspond à la clé primaire de la table.
        // elle est facultative dans le cas ou la clé correspond à "int Id" (C'est le comportement par défaut).

        /*
         * Exemple:
         * 
         * [Key]
         * public int MaClePrimaire { get; set; }
         * 
         */

        // [Key] 
        public int Id { get; set; }

        // Required permet de dire qu'in champ/une colonne est requis dans notre base de données => NOT NULL
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set;}
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
