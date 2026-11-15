using Gestordeentrega.Application.Contract;
using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.Delivery;

namespace Gestordeentrega.Application.Service;

public class DeliveryService : IDeliveryService
{
    public Task<List<DeliveryDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DeliveryDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DeliveryDto> CreateAsync(DeliveryCreateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Address))
            throw new Exception("La dirección es obligatoria.");

        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(int id, DeliveryUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}
