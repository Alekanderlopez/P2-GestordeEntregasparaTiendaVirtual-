namespace Gestordeentrega.api.Models.Dtos
{
    public class UpdateDeliveryDto
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int OrderId { get; set; }
        public int DeliveryDriverId { get; set; }
    }
}