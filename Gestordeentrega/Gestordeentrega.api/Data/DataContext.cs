using Gestordeentrega.api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gestordeentrega.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<DeliveryDriver> DeliveryDrivers { get; set; }

        public DbSet<Delivery> Deliveries { get; set; }
    }
}