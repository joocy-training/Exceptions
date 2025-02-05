using Exceptions;

for (var i = 0; i < 10; i++)
{
    long niceNumber = Utils.GenerateNumber();
    Console.WriteLine($"{niceNumber} is a nice number");
}
