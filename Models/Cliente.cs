using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int cpf { get; set; }

        [Required]
        [StringLength(90)]
        public string nome { get; set; }

        [Required]
  
        public int telefone { get; set; }

}
}
