namespace FizzBuzz;

class Program
{
    static void FizzBuzz()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
                continue;
            }

            if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
                continue;
            }

            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                continue;
            }

            else
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Main(string[] args)
    {
        FizzBuzz();
    }
}