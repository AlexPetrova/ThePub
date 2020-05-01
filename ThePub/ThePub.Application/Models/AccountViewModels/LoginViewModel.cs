using System.ComponentModel.DataAnnotations;

namespace ThePub.Application.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required]
        [MinLength(3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
