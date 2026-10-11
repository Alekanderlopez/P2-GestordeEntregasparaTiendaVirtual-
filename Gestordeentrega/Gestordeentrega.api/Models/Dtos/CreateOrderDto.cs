namespace Gestordeentrega.api.Models.Dtos
{
    public class CreateOrderDto
    {
        public string Product { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
    }
}