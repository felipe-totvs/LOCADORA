﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOCADORA.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        [Display(Name = "CPF")]
        [StringLength(11)]
        public string cpf { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome")]
        [StringLength(90)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo Telefone é obrigatório")]
        [Display(Name = "Telefone")]
        [StringLength(14)]
        public string telefone { get; set; }

}
}
