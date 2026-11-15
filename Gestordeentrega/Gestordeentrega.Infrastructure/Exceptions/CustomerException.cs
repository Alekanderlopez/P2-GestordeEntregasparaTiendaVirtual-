namespace Gestordeentrega.Infrastructure.Exceptions;

public class CustomerException : Exception
{
    public CustomerException(string message) : base(message) { }
}