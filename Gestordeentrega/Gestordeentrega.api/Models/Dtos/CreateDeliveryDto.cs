namespace Gestordeentrega.api.Models.Dtos
{
    public class CreateDeliveryDto
    {
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int OrderId { get; set; }
        public int DeliveryDriverId { get; set; }
    }
}