namespace TemperatureConverter;

/*
 * °C = (°F - 32) * 5/9 (von Fahrenheit in Celsius)
 * °F = °C * 1,8 + 32 (von Celsius nach Fahrenheit)
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the type of your value (Celsius / C or Fahrenheit / F):");
        string userInput = Console.ReadLine();
        if (userInput is "C" or "Celsius")
        {
            Console.WriteLine("Please enter your value:");
            float celsius = Convert.ToSingle(Console.ReadLine());
            float fahrenheit = celsius * 1.8f + 32;
            Console.WriteLine($"{celsius} is {fahrenheit} in fahrenheit");
        }
        if (userInput is "F" or "Fahrenheit")
        {
            Console.WriteLine("Please enter your value:");
            float fahrenheit = Convert.ToSingle(Console.ReadLine());
            float celsius = (fahrenheit - 32) * 5/9;
            Console.WriteLine($"{fahrenheit} is {celsius} in celsius");
        }
    }
}