using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models
{
    public class Caloria_v3
    {
        [Key]
        public int Caloria_ID { get; set; }

        
        [Display(Name = "Data da Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string? DATA_REFEICAO { get; set; }


        
        [Display(Name = "Horário da Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string? HORARIO_REFEICAO { get; set; }


       
        [Display(Name = "Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string? REFEICAO { get; set; }


        
        [Display(Name = "Peso da Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string? PESO_REFEICAO { get; set; }


        [ForeignKey("Paciente")]
        [Display(Name = "CPF")]
        [StringLength(20, MinimumLength = 8)]
        public string CPF { get; set; }
        public virtual Paciente Paciente { get; set; }


    }
}
