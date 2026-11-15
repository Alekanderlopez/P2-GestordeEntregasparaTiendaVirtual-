using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Infrastructure.Context;
using Gestordeentrega.Infrastructure.Core;
using Gestordeentrega.Infrastructure.Exceptions;
using Gestordeentrega.Infrastructure.Interfaces;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Repositories;

public class DeliveryDriverRepository : BaseRepository<DeliveryDriver>, IDeliveryDriverRepository
{
    public DeliveryDriverRepository(GestorContext context) : base(context) { }

    public async Task<List<DeliveryDriverModel>> GetDeliveryDriversAsync()
    {
        var drivers = await GetAllAsync();
        return drivers.Select(d => new DeliveryDriverModel
        {
            Id = d.Id,
            Name = d.Name,
            Phone = d.Phone
        }).ToList();
    }

    public async Task<DeliveryDriverModel> CreateDeliveryDriverAsync(DeliveryDriverModel model)
    {
        if (string.IsNullOrWhiteSpace(model.Name))
            throw new DeliveryDriverException("El nombre es obligatorio.");

        var driver = await AddAsync(new DeliveryDriver
        {
            Name = model.Name,
            Phone = model.Phone
        });

        model.Id = driver.Id;
        return model;
    }
}