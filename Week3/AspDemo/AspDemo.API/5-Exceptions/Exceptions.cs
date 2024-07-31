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

public class PokemonDoesNotExistException : Exception
{
    public PokemonDoesNotExistException(){}
    public PokemonDoesNotExistException(string message) : base(message){}
    public PokemonDoesNotExistException(string message, Exception inner) : base(message, inner){}
}

public class TrainerDoesNotExistException : Exception
{
    public TrainerDoesNotExistException(){}
    public TrainerDoesNotExistException(string message) : base(message){}
    public TrainerDoesNotExistException(string message, Exception inner) : base(message, inner){}
}