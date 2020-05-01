using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ThePub.Application.Models.OrderViewModels
{
    public class MealTypeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SelectedMealId { get; set; }

        public IEnumerable<SelectListItem> Meals { get; set; }
    }
}
