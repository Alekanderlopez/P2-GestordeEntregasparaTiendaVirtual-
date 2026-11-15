using Gestordeentrega.Domain.Core;

namespace Gestordeentrega.Domain.Entities;

public class Delivery : BaseEntity
{
    public string Address { get; set; } = string.Empty;
    public DateTime DeliveryDate { get; set; }
    public int OrderId { get; set; }
    public int DeliveryDriverId { get; set; }
}