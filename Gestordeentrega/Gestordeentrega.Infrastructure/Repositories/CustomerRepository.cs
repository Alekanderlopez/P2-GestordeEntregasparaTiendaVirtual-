using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Infrastructure.Context;
using Gestordeentrega.Infrastructure.Core;
using Gestordeentrega.Infrastructure.Exceptions;
using Gestordeentrega.Infrastructure.Interfaces;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Repositories;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(GestorContext context) : base(context) { }

    public async Task<List<CustomerModel>> GetCustomersAsync()
    {
        var customers = await GetAllAsync();
        return customers.Select(c => new CustomerModel
        {
            Id = c.Id,
            Name = c.Name,
            Phone = c.Phone,
            Email = c.Email
        }).ToList();
    }

    public async Task<CustomerModel> CreateCustomerAsync(CustomerModel model)
    {
        if (string.IsNullOrWhiteSpace(model.Name))
            throw new CustomerException("El nombre es obligatorio.");

        var customer = await AddAsync(new Customer
        {
            Name = model.Name,
            Phone = model.Phone,
            Email = model.Email
        });

        model.Id = customer.Id;
        return model;
    }
}