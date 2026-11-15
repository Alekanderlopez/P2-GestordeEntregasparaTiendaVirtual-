using Gestordeentrega.Domain.Entities;
using Gestordeentrega.Domain.Repository;
using Gestordeentrega.Infrastructure.Models;

namespace Gestordeentrega.Infrastructure.Interfaces;

public interface IDeliveryRepository : IBaseRepository<Delivery>
{
    Task<List<DeliveryModel>> GetDeliveriesAsync();
    Task<DeliveryModel> CreateDeliveryAsync(DeliveryModel model);
}