using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Security.Claims;
using ThePub.Application.Extensions;
using ThePub.Application.Models.OrderViewModels;
using ThePub.Data;
using ThePub.Data.DTO;
using ThePub.Services.Contracts;

namespace ThePub.Application.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMealTypeService mealTypeService;
        private readonly IOrderService orderService;
        public OrdersController(
            IMealTypeService mealTypeService,
            IOrderService orderService)
        {
            this.mealTypeService = mealTypeService;
            this.orderService = orderService;
        }

        [Authorize]
        public IActionResult Index()
        {
            var mealTypes = this.mealTypeService
                .GetAllMealTypes(base.User.GetUserRole())
                .Select(mealType => new MealTypeViewModel
                {
                    Id = mealType.Id,
                    Name = mealType.Name,
                    Meals = mealType.Meals
                        .Select(meal => new SelectListItem(meal.Name, meal.Id.ToString()))
                })
                .ToList();

            var today = (int)DateTime.Now.DayOfWeek;
            var startingDay = DateTime.Now.AddDays(-today);

            var weekView = Enumerable.Range(0, 7).Select(i => new OrderFormViewModel()
            {
                Date = startingDay.AddDays(i),
                MealTypes = mealTypes
            });

            return base.View(weekView);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Make([FromBody] PlaceOrderViewModel order)
        {
            this.orderService.Create(new CreateOrderDTO
            {
                UserId = base.User.GetUserId(),
                Meals = order.Meals
                    .Select(m => new MealOrdersDTO { MealTypeId = m.MealTypeId, MealId = m.MealId })
                    .ToList(),
                OrderDate = order.Date
            });

            return Ok();
        }
    }
}