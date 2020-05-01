using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePub.Application.Models.OrderViewModels
{
    public class PlaceOrderViewModel
    {
        public DateTime Date { get; set; }

        public ICollection<MealOrderViewModel> Meals { get; set; }
    }
}
