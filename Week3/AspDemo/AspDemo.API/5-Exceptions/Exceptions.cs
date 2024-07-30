namespace AspDemoApi.Exceptions;

public class EmptyListException : Exception
{
    public EmptyListException(){}
    public EmptyListException(string message) : base(message){}
    public EmptyListException(string message, Exception inner) : base(message, inner){}
}

public class InvalidPokemonException : Exception
{
    public InvalidPokemonException(){}
    public InvalidPokemonException(string message) : base(message){}
    public InvalidPokemonException(string message, Exception inner) : base(message, inner){}
}