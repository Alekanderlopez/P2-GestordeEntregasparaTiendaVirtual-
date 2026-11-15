using Gestordeentrega.Application.Contract;
using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.DeliveryDriver;

namespace Gestordeentrega.Application.Service;

public class DeliveryDriverService : IDeliveryDriverService
{
    public Task<List<DeliveryDriverDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DeliveryDriverDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DeliveryDriverDto> CreateAsync(DeliveryDriverCreateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
            throw new Exception("El nombre es obligatorio.");

        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(int id, DeliveryDriverUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}