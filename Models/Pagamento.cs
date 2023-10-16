using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Pagamentos")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID Pagamento")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Dias é obrigatório")]
        [Display(Name = "Dias")]
        public int dias { get; set; }
        [Required(ErrorMessage = "Campo Valor Final é obrigatório")]
        [Display(Name = "Valor Final")]
        [DisplayFormat(DataFormatString = "{0,C2}")]
        public float valor_final { get; set; }
}
}
