using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Paciente")]
        [StringLength(50, MinimumLength = 8)]
        public string Nome { get; set; }

   
    }
}

