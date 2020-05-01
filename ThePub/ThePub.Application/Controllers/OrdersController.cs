using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using ThePub.Application.Models.OrderViewModels;
using ThePub.Data;

namespace ThePub.Application.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMealTypeService mealTypeService;

        public OrdersController(IMealTypeService mealTypeService)
        {
            this.mealTypeService = mealTypeService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var mealTypes = this.mealTypeService
                .GetAllMealTypes()
                .Select(mealType => new MealTypeViewModel
                {
                    Id = mealType.Id,
                    Name = mealType.Name,
                    Meals = mealType.Meals
                        .Select(meal => new SelectListItem(meal.Name, meal.Id.ToString()))
                })
                .ToList();

            if(base.User.IsInRole("KnowsTheRightPeople"))
            {
                mealTypes.Add(mealTypes.First(x => x.Id == Constants.DessertMealTypeId));
            }

            var today = (int)DateTime.Now.DayOfWeek;
            var startingDay = DateTime.Now.AddDays(-today);

            var weekView = Enumerable.Range(0, 7).Select(i => new OrderFormViewModel()
            {
                Date = startingDay.AddDays(i),
                MealTypes = mealTypes
            });

            return base.View(weekView);
        }

    }
}