using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.Order;

namespace Gestordeentrega.Application.Contract;

public interface IOrderService
{
    Task<List<OrderDto>> GetAllAsync();
    Task<OrderDto?> GetByIdAsync(int id);
    Task<OrderDto> CreateAsync(OrderCreateDto dto);
    Task<bool> UpdateAsync(int id, OrderUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}