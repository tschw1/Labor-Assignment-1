namespace Palindrome;

class Program
{
    static bool IsPalindrom(string s)
    {
        s = s.ToLower();
        string reversed = new string(s.Reverse().ToArray());
        return s == reversed;
    }

    static void Main()
    {
        Console.WriteLine("Bitte geben sie ein Wort ein, um zu prüfen, ob es ein Palindrom ist:");

        string enteredWord = Console.ReadLine();

        Console.WriteLine(enteredWord.Reverse().ToArray());

        if (IsPalindrom(enteredWord))
        {
            Console.WriteLine($"Das Wort {enteredWord} ist ein Palindrom");
        }
        else
        {
            Console.WriteLine($"Das Wort {enteredWord} ist kein Palindrom");
        }
    }
}