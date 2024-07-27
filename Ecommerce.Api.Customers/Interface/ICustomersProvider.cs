using Ecommerce.Api.Customers.Db;
using Ecommerce.Api.Customers.Models;

namespace Ecommerce.Api.Customers.Interface
{
    public interface ICustomersProvider
    {
        Task<(bool IsSuccess, IEnumerable<Models.Customers> Customers, string ErrorMessage)> GetCustomersAsync();
        Task<(bool IsSuccess, Models.Customers Customer, string ErrorMessage)> GetCustomerAsync(int id);
    }
}
