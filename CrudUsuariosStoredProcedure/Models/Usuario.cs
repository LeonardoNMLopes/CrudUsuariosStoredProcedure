using System.ComponentModel.DataAnnotations;

namespace CrudUsuariosStoredProcedure.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Sobrenome!")]
        public string SobreNome { get; set; }
        [Required(ErrorMessage = "Digite o Email!"),
            EmailAddress(ErrorMessage ="Email incorreto!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o Cargo!")]
        public string Cargo { get; set; }
    }
}
