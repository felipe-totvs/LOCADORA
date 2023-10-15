using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Manutencao")]
    public class Manutencao
    {

        [Key]
        public int id { get; set; }
        [Required]
        
        public int id_carro { get; set; }

        [Required]
        [StringLength(1)]
        public string estado{get; set; }
        
    }
}
