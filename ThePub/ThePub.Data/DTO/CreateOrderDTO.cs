using System;
using System.Collections.Generic;

namespace ThePub.Data.DTO
{
    public class CreateOrderDTO
    {
        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public IReadOnlyCollection<MealOrdersDTO> Meals { get; set; }
    }
}
