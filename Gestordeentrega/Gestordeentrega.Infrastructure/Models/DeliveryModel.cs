namespace Gestordeentrega.Infrastructure.Models;

public class DeliveryModel
{
    public int Id { get; set; }
    public string Address { get; set; } = string.Empty;
    public DateTime DeliveryDate { get; set; }
    public int OrderId { get; set; }
    public int DeliveryDriverId { get; set; }
}