namespace Gestordeentrega.api.Models.Entities
{
    public class Delivery
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int OrderId { get; set; }

        public int DeliveryDriverId { get; set; }
    }
}