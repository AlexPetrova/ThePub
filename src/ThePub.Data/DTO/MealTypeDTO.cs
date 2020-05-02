using System.Collections.Generic;

namespace ThePub.Data.DTO
{
    public class MealTypeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<MealDTO> Meals { get; set; }
    }
}
