using Gestordeentrega.Application.Dtos;
using Gestordeentrega.Application.Dtos.Customer;

namespace Gestordeentrega.Application.Contract;

public interface ICustomerService
{
    Task<List<CustomerDto>> GetAllAsync();
    Task<CustomerDto?> GetByIdAsync(int id);
    Task<CustomerDto> CreateAsync(CustomerCreateDto dto);
    Task<bool> UpdateAsync(int id, CustomerUpdateDto dto);
    Task<bool> DeleteAsync(int id);
}