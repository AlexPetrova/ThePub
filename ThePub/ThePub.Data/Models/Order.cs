using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThePub.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public bool IsDeclined { get; set; }

        public ICollection<MealOrders> MealOrders { get; set; }
    }
}
