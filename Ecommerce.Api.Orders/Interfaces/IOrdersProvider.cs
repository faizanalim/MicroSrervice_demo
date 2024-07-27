using Ecommerce.Api.Orders.Models;

namespace Ecommerce.Api.Orders.Interfaces
{
    public interface IOrdersProvider
    {
        Task<(bool IsSuccess, IEnumerable<OrderDto> Orders, string ErrorMessage)> GetOrdersAsync(int customerId);
    }
}
