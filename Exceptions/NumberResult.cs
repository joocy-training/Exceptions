namespace Exceptions;

public readonly struct NumberResult<T, E>
{
    private readonly T _value;
    private readonly E _error;
    private readonly bool _success;

    private NumberResult(T value, E error, bool success)
    {
        _value = value;
        _error = error;
        _success = success;
    }

    public static NumberResult<T, E> Ok(T value)
    {
        return new NumberResult<T, E>(value, default!, true);
    }

    public static NumberResult<T, E> Err(E error)
    {
        return new NumberResult<T, E>(default!, error, false);
    }

    public bool IsOk()
    {
        return _success;
    }

    public T GetValue()
    {
        return _value;
    }

    public E GetError()
    {
        return _error;
    }
}
