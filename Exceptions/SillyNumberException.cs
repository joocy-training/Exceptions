namespace Exceptions;
class SillyNumberException(long number) : Exception ($"{number} is a silly number!") {} 