using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Domain.Repository;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Interfaces;

public interface ICustomerRepository : IBaseRepository<Customer>
{
    Task<List<CustomerModel>> GetCustomersAsync();
    Task<CustomerModel> CreateCustomerAsync(CustomerModel model);
}