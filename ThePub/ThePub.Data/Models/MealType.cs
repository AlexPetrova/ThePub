using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePub.Data.Models
{
    public class MealType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Meal> Meals { get; set; }
    }
}
