using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Infrastructure.Context;
using Gestordeentrega.Infrastructure.Core;
using Gestordeentrega.Infrastructure.Exceptions;
using Gestordeentrega.Infrastructure.Interfaces;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Repositories;

public class DeliveryRepository : BaseRepository<Delivery>, IDeliveryRepository
{
    public DeliveryRepository(GestorContext context) : base(context) { }

    public async Task<List<DeliveryModel>> GetDeliveriesAsync()
    {
        var deliveries = await GetAllAsync();
        return deliveries.Select(d => new DeliveryModel
        {
            Id = d.Id,
            Address = d.Address,
            DeliveryDate = d.DeliveryDate,
            OrderId = d.OrderId,
            DeliveryDriverId = d.DeliveryDriverId
        }).ToList();
    }

    public async Task<DeliveryModel> CreateDeliveryAsync(DeliveryModel model)
    {
        if (string.IsNullOrWhiteSpace(model.Address))
            throw new DeliveryException("La dirección es obligatoria.");

        var delivery = await AddAsync(new Delivery
        {
            Address = model.Address,
            DeliveryDate = model.DeliveryDate,
            OrderId = model.OrderId,
            DeliveryDriverId = model.DeliveryDriverId
        });

        model.Id = delivery.Id;
        return model;
    }
}