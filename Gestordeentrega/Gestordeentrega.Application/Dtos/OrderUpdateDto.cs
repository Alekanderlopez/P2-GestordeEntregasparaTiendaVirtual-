namespace Gestordeentrega.Application.Dtos.Order;

public class OrderUpdateDto
{
    public string Product { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }
}