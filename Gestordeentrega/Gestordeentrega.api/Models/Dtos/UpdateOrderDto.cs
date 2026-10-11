namespace Gestordeentrega.api.Models.Dtos
{
    public class UpdateOrderDto
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
    }
}