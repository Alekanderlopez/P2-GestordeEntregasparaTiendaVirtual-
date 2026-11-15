using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.DeliveryDriver;

namespace Gestordeentrega.Application.Contract;

public interface IDeliveryDriverService
{
    Task<List<DeliveryDriverDto>> GetAllAsync();
    Task<DeliveryDriverDto?> GetByIdAsync(int id);
    Task<DeliveryDriverDto> CreateAsync(DeliveryDriverCreateDto dto);
    Task<bool> UpdateAsync(int id, DeliveryDriverUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}
