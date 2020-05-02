using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePub.Data.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int MealTypeId { get; set; }

        public MealType MealType { get; set; }

        public ICollection<MealOrders> MealOrders { get; set; }
    }
}
