using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace KauaeJoaoR.Models
{
    public class Aluno
    {
        [Display(Name = "Código", Description = "Código.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public int? Id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Nome { get; set; }

        [Display(Name = "E-mail", Description = "E-mail.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Email { get; set; }

        [Display(Name = "Telefone", Description = "Telefone.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Telefone { get; set; }

        [Display(Name = "Série", Description = "Série.")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Serie { get; set; }

        [Display(Name = "Turma", Description = "Turma")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Turma { get; set; }

        [Display(Name = "Data de Nascimento", Description = "Data de Nascimento")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public DateTime Nascimento { get; set; }
    }
}
