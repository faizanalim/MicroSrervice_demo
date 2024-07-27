﻿

namespace Ecommerce.Api.Orders.Profiles
{
    public class OrderProfile : AutoMapper.Profile
    {
        public OrderProfile()
        {
            CreateMap<Db.Order, Models.OrderDto>();
            CreateMap<Db.OrderItem, Models.OrderItemDto>();
        }
        
    }
}
