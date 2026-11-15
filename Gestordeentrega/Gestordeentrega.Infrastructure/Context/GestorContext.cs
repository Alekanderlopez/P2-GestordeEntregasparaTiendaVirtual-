using Gestordeentrega.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gestordeentrega.Infrastructure.Context;

public class GestorContext : DbContext
{
    public GestorContext(DbContextOptions<GestorContext> options) : base(options) { }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Delivery> Deliveries => Set<Delivery>();
    public DbSet<DeliveryDriver> DeliveryDrivers => Set<DeliveryDriver>();
    public DbSet<Order> Orders => Set<Order>();
}