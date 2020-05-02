using System.Threading.Tasks;
using ThePub.Data.DTO;

namespace ThePub.Services.Contracts
{
    public interface IOrderService
    {
        Task Create(CreateOrderDTO dto);

        Task DeclineOrder(int orderId);
    }
}
