using System.ComponentModel.DataAnnotations;

namespace Blazor_WebAssembly.Model
{
    public class Usuario
    {
        public int Id { get; set; }

        //Dois Atibutos de validação.
        [Required(ErrorMessage = "O nome deve ser informado.")]
        [StringLength(10, ErrorMessage = "O nome não pode exeder 10 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email deve ser informado.")]
        [EmailAddress(ErrorMessage = "Formato do email inválido.")]
        public string Email { get; set; }

        [Range(18, 80, ErrorMessage = "A idade deve estar entre 18 e 80 anos.")]
        public int Idade { get; set; }
    }
}
