using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Domain.Repository;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Interfaces;

public interface IDeliveryDriverRepository : IBaseRepository<DeliveryDriver>
{
    Task<List<DeliveryDriverModel>> GetDeliveryDriversAsync();
    Task<DeliveryDriverModel> CreateDeliveryDriverAsync(DeliveryDriverModel model);
}