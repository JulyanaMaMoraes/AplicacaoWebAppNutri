using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class Paciente
    {

      
        [Display(Name = "Nome da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string? NOME { get; set; }

        [Key]
        [Required]
        [Display(Name = "Cpf da Pessoa")]
        [StringLength(20, MinimumLength = 8)]
        public string CPF { get; set; }

        
        [Display(Name = "Email da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string? EMAIL { get; set; }

   
        [Display(Name = "Telefone da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string? TELEFONE { get; set; }

        
        [Display(Name = "Idade da Pessoa")]
        public int? IDADE { get; set; }

       
        [Display(Name = "Username da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string? USERNAME { get; set; }

       
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 4)]
        public string? PASSWORD { get; set; }


        
        [Display(Name = "Comorbidade da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string? COMORBIDADE { get; set; }

        
        [Display(Name = "Preferencia Alimentar da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string? PREFERENCIA_ALIMENTAR { get; set; }


      
        [Display(Name = "Objetivo da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string? OBJETIVO { get; set; }

       
        [Display(Name = "Exercicio Habitual da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string? EXERCICIO_HABITUAL { get; set; }

        
        [Display(Name = "Alimentacao Habitual da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string? ALIMENTACAO_HABITUAL { get; set; }

        public virtual ICollection<Caloria_v3> Caloria_v3 { get; set; }

    }
}
