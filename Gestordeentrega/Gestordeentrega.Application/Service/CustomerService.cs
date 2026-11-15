using Gestordeentrega.Application.Contract;
using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.Customer;

namespace Gestordeentrega.Application.Service;

public class CustomerService : ICustomerService
{
    public async Task<List<CustomerDto>> GetAllAsync()
    {
        return new List<CustomerDto>();
    }

    public async Task<CustomerDto?> GetByIdAsync(int id)
    {
        return null;
    }

    public async Task<CustomerDto> CreateAsync(CustomerCreateDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Name))
            throw new Exception("El nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(dto.Email))
            throw new Exception("El email es obligatorio.");

        return new CustomerDto
        {
            Name = dto.Name,
            Phone = dto.Phone,
            Email = dto.Email
        };
    }

    public async Task<bool> UpdateAsync(int id, CustomerUpdateDto dto)
    {
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return true;
    }
}