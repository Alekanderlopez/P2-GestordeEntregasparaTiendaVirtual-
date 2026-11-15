using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.Delivery;

namespace Gestordeentrega.Application.Contract;

public interface IDeliveryService
{
    Task<List<DeliveryDto>> GetAllAsync();
    Task<DeliveryDto?> GetByIdAsync(int id);
    Task<DeliveryDto> CreateAsync(DeliveryCreateDto dto);
    Task<bool> UpdateAsync(int id, DeliveryUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}