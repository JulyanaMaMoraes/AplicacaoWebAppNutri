using System.ComponentModel.DataAnnotations;

namespace Teste.Models
{
    public class NUTRICIONISTA
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }


        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }


}