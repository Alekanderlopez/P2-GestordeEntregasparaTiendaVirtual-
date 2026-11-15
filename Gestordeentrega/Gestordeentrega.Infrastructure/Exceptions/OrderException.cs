namespace Gestordeentrega.Infrastructure.Exceptions;

public class OrderException : Exception
{
    public OrderException(string message) : base(message) { }
}