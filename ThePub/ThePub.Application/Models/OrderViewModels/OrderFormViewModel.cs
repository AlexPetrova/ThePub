using System;
using System.Collections.Generic;

namespace ThePub.Application.Models.OrderViewModels
{
    public class OrderFormViewModel
    {
        public DateTime Date { get; set; }

        public string Day
        {
            get => this.Date.ToString("dddd, dd MMM");
        }

        public IEnumerable<MealTypeViewModel> MealTypes { get; set; }

        public bool IsDeclined { get; set; }
    }
}
