namespace VowelCount;

class Program
{
    static void Main(string[] args)
    {
        string[] vowel = { "a", "e", "i", "o", "u"};
        int vowelCount = 0;

        Console.WriteLine("Please enter a word to start the vowel counter!");

        string userInput = Console.ReadLine().ToLower();

        foreach (char c in userInput)
        {
            if (vowel.Contains(c.ToString()))
            {
                vowelCount++;
            }
        }

        Console.WriteLine($"You entered {vowelCount} vowels");
    }
}