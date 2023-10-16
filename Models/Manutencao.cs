using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Manutencao")]
    public class Manutencao
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }


        [Required(ErrorMessage = "Campo ID_CARRO é obrigatório")]
        [Display(Name = "ID_CARRO")]
        public int id_carro { get; set; }

        [Required(ErrorMessage = "Campo Estado é obrigatório")]
        [Display(Name = "Estado de manutenção")]
        [StringLength(1)]
        public string estado{get; set; }
        
    }
}
