using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Carros")]
    public class Carros

    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(40)]
        public string modelo { get; set; }

        [Required]
        [StringLength(40)]
        public  string motor { get; set; }

        [Required]
        [StringLength(1)]
        public string disponibilidade { get; set; }
        public float valor { get; set; }
        
    }
}
