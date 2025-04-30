namespace NumberGuesser;

class Program
{
    static void Main(string[] args)
    {
        //create a random number using the Random class
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 101);

        bool numberGuessed = false;

        Console.WriteLine("Welcome to the Number Guesser!\nPlease enter a number to start the game!");

        while (!numberGuessed)
        {
            //get guessed number
            int userInput = Convert.ToInt32(Console.ReadLine());

            //check if user entered the right number
            if (userInput == randomNumber)
            {
                Console.WriteLine($"You guessed the right number! The number was {randomNumber}");
                numberGuessed = true;   //ends while loop
            }

            if (userInput < randomNumber)
            {
                Console.WriteLine($"The number {userInput} was wrong! The number needs to be higher!");
            }

            if (userInput > randomNumber)
            {
                Console.WriteLine($"The number {userInput} was wrong! The number needs to be lower!");
            }
        }
    }
}