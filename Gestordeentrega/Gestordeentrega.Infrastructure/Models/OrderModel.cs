namespace Gestordeentrega.Infrastructure.Models;

public class OrderModel
{
    public int Id { get; set; }
    public string Product { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
}