using Gestordeentrega.Application.Contract;
using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.Order;

namespace Gestordeentrega.Application.Service;

public class OrderService : IOrderService
{
    public Task<List<OrderDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDto> CreateAsync(OrderCreateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Product))
            throw new Exception("El producto es obligatorio.");

        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(int id, OrderUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}