using Gestordeentrega.Domain.Core;

namespace Gestordeentrega.Domain.Entities;

public class Order : BaseEntity
{
    public string Product { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
}