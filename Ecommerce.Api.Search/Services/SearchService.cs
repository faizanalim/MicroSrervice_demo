using Ecommerce.Api.Search.Interfaces;

namespace Ecommerce.Api.Search.Services
{
	public class SearchService : ISearchService
	{
		private readonly IOrdersService ordersService;
		

		public SearchService(IOrdersService ordersService )
		{
			this.ordersService = ordersService;
			
		}
		public async Task<(bool IsSuccess, dynamic SearchResults)> SearchAsync(int customerId)
		{
			var ordersResult = await ordersService.GetOrdersAsync(customerId);
			

			if (ordersResult.IsSuccess)
			{
				//foreach (var order in ordersResult.Orders)
				//{
				//	foreach (var item in order.Items)
				//	{
				//		item.ProductName = productsResult.Products.FirstOrDefault(p => p.Id == item.ProductId)?.Name;
				//	}
				//}


				var result = new
				{
					Orders = ordersResult.Orders
				};
				return (true, result);
			}
			return (false, null);
		}
	}
}
