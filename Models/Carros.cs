using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Carros")]
    public class Carros

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Modelo é obrigatório")]
        [Display(Name = "Modelo")]
        [StringLength(40)]
        public string modelo { get; set; }

        
        [Required(ErrorMessage = "Campo Motor é obrigatório")]
        [Display(Name = "Motor")]
        [StringLength(40)]
        public  string motor { get; set; }

        [Required(ErrorMessage = "Campo Disponibilidade é obrigatório")]
        [Display(Name = "Disponibilidade")]
        [StringLength(1)]
        public string disponibilidade { get; set; }
        [Required(ErrorMessage = "Campo Valor é obrigatório")]
        [Display(Name = "Valor/Dia")]
        public float valor { get; set; }
        
    }
}
