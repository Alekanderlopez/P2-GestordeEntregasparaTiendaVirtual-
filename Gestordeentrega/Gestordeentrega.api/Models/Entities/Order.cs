namespace Gestordeentrega.api.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Product { get; set; }

        public string Status { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
    }
}
