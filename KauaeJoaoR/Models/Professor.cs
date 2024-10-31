using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace KauaeJoaoR.Models
{
    public class Professor
    {
        [Display(Name = "Código", Description = "Código.")]
        [Required(ErrorMessage ="Esse campo é obrigatório")]
        public int? Id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "CPF", Description = "CPF.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string CPF { get; set; }

        [Display(Name = "RG", Description = "RG.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string RG { get; set; }

        [Display(Name = "Telefone", Description = "Telefone")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Telefone { get; set; }

        [Display(Name = "Data de Nascimento", Description = "Data de Nascimento")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public DateTime Nascimento { get; set; }
    }
}
