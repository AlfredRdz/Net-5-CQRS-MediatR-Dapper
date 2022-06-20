using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRS.Domain
{
    [Table("PersonaEjercicio")]
    public class PersonaEjercicio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        [Column("Name")]
        [Required]
        public string Name { get; set; }
        [Column("FirstName")]
        [Required]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Age")]
        public int Age { get; set; }
    }
}
