namespace Exceptions;

public class Utils
{
    public static long GenerateNumber()
    {
        long number = new Random().NextInt64() % 100;
        if (number % 2 != 0)
        {
            throw new SillyNumberException(number);
        }
        return number;
    }


    public static NumberResult<long, string> GenerateNiceNumberWithResult()
    {
        long number = new Random().NextInt64() % 100;
        if (number % 2 != 0)
        {
            return NumberResult<long, string>.Err($"{number} is a silly number");
        }
        return NumberResult<long, string>.Ok(number);
    }
}
