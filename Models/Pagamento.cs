using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Pagamentos")]
    public class Pagamento
    {
        [Key]
        public int id { get; set; }
        [Required]
        
        public int dias { get; set; }

        public float valor_final { get; set; }
}
}
