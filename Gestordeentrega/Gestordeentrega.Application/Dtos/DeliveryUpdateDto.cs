namespace Gestordeentrega.Application.Dtos.Delivery;

public class DeliveryUpdateDto
{
    public string Address { get; set; } = string.Empty;

    public DateTime DeliveryDate { get; set; }

    public int OrderId { get; set; }

    public int DeliveryDriverId { get; set; }
}
