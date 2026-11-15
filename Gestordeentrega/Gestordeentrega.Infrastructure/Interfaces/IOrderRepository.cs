using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Domain.Repository;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Interfaces;

public interface IOrderRepository : IBaseRepository<Order>
{
    Task<List<OrderModel>> GetOrdersAsync();
    Task<OrderModel> CreateOrderAsync(OrderModel model);
}