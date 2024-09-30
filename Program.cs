using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\r\n  __  __       _ _   _       _ _           _   _                _____                      \r\n |  \\/  |     | | | (_)     | (_)         | | (_)              / ____|                     \r\n | \\  / |_   _| | |_ _ _ __ | |_  ___ __ _| |_ _  ___  _ __   | |  __  __ _ _ __ ___   ___ \r\n | |\\/| | | | | | __| | '_ \\| | |/ __/ _` | __| |/ _ \\| '_ \\  | | |_ |/ _` | '_ ` _ \\ / _ \\\r\n | |  | | |_| | | |_| | |_) | | | (_| (_| | |_| | (_) | | | | | |__| | (_| | | | | | |  __/\r\n |_|  |_|\\__,_|_|\\__|_| .__/|_|_|\\___\\__,_|\\__|_|\\___/|_| |_|  \\_____|\\__,_|_| |_| |_|\\___|\r\n                      | |                                                                  \r\n                      |_|                                                                  \r\n"); // outputs this line, meaning this will display when the user launches up the program
        Console.ForegroundColor = ConsoleColor.Yellow; // makes the text green
        int correctAnswers = 0; // sets the correct answer score to 0 
        int wrongAnswers = 0; // sets the wrong answers score to 0 
        Random random = new Random(); // this will let it generate a random number
        for (int i = 1; i <= 10; i++) // sets up minimum and maximum of randomised numbers
        {
            int number1 = random.Next(1, 11); // generates a random number between from 1 to 10 
            int number2 = random.Next(1, 11); // same as above 
            Console.WriteLine("Question {0} | {1} x {2} = ?", i, number1, number2); // outputs the question, meaning the question will display 

            int playerGuess; // this is where the users type their answer 

            bool letters = false; // disallows letters
            do
            {
                string input = Console.ReadLine();
                letters = int.TryParse(input, out playerGuess);

                if (!letters)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; // makes the text dark red
                    Console.WriteLine("Please enter a number.");    // it will display this if someone types a non-number (could be a letter or a spacebar) 
                    Console.ForegroundColor = ConsoleColor.Yellow; // makes the text yellow
                }
            } while (!letters);
            int correctAnswer = number1 * number2; // calculates the generated question so it can find the answer to see if the user's answer is correct or not
            if (playerGuess == correctAnswer) // so if the answer is correct.
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!"); // it will display this message that's in quotes
                Console.ForegroundColor = ConsoleColor.Yellow; // makes the text yellow
                correctAnswers++; // adds 1 to the correct answers score
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong. The answer is: {0}", correctAnswer); // it will display the correct answer
                Console.ForegroundColor = ConsoleColor.Yellow; // makes the text yellow
                wrongAnswers++; // adds 1 to the wrong answers score
            }
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan; // makes the text yellow
        Console.WriteLine("You've got {0} out of 10 correct", correctAnswers); // displays how many you've got right, like a marking system.
        if (correctAnswers == 10) // if the user got all the questions right
        {
            Console.WriteLine("Well done! You are now The Maths Superstar!"); // displays this if the user got it all right
        }
        else
        {
            Console.WriteLine("Good try, but be sure to keep practicing to become The Maths Superstar!"); // displays this if the user didn't get it all right
        }
    }
}
