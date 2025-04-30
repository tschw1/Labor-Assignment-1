namespace Quersumme;

class Program
{
    static int Quersumme(string zahl)
    {
        int quersumme = 0;
        foreach (char c in zahl)
        {
            quersumme += (int) char.GetNumericValue(c);
        }

        return quersumme;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bitte gib eine Zahl ein, aus der die Quersumme gebildet werden soll:");

        string zahl = Console.ReadLine();

        Console.WriteLine($"Die Quersumme von {zahl} lautet {Quersumme(zahl)}!");
    }
}