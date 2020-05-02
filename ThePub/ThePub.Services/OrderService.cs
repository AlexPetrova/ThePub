using System.Linq;
using System.Threading.Tasks;
using ThePub.Data;
using ThePub.Data.DTO;
using ThePub.Data.Models;
using ThePub.Services.Contracts;

namespace ThePub.Services
{
    public class OrderService : IOrderService
    {
        private readonly PubDbContext context;

        public OrderService(PubDbContext context)
        {
            this.context = context;
        }

        public async Task Create(CreateOrderDTO dto)
        {
            var order = new Order
            {
                UserId = dto.UserId,
                OrderDate = dto.OrderDate,
                MealOrders = dto.Meals
                    .Select(meal => new MealOrders { MealId = meal.MealId })
                    .ToList()
            };
            this.context.Orders.Add(order);
            await this.context.SaveChangesAsync();
        }

        public async Task DeclineOrder(int orderId)
        {
            this.context.Orders
                .First(x => x.Id == orderId)
                .IsDeclined = true;
            await this.context.SaveChangesAsync();
        }
    }
}
