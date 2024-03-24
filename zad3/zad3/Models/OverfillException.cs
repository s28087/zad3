namespace Zad3.Models;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message)
    {
        throw new Exception(message);
        
    }
}