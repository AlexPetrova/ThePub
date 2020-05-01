using System.ComponentModel.DataAnnotations;

namespace ThePub.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }
        
        public int RoleId { get; set; }

        public Role Role { get; set; }
    }
}
