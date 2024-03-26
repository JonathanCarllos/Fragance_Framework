using System.ComponentModel.DataAnnotations;

namespace Fragance_Framework.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O e-Mail é obrigatório")]
        [EmailAddress(ErrorMessage = "e-Mail é inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Lembre-me")]
        public bool RememberMe { get; set; }
    }
}
