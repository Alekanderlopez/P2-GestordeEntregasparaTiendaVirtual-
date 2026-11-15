using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Infrastructure.Context;
using Gestordeentrega.Infrastructure.Core;
using Gestordeentrega.Infrastructure.Exceptions;
using Gestordeentrega.Infrastructure.Interfaces;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(GestorContext context) : base(context) { }

    public async Task<List<OrderModel>> GetOrdersAsync()
    {
        var orders = await GetAllAsync();
        return orders.Select(o => new OrderModel
        {
            Id = o.Id,
            Product = o.Product,
            Status = o.Status,
            OrderDate = o.OrderDate,
            CustomerId = o.CustomerId
        }).ToList();
    }

    public async Task<OrderModel> CreateOrderAsync(OrderModel model)
    {
        if (string.IsNullOrWhiteSpace(model.Product))
            throw new OrderException("El producto es obligatorio.");

        var order = await AddAsync(new Order
        {
            Product = model.Product,
            Status = model.Status,
            OrderDate = model.OrderDate,
            CustomerId = model.CustomerId
        });

        model.Id = order.Id;
        return model;
    }
}