for (int i = 0; i < int.MaxValue; i++) // highlight, then hit ctrl + k + s to encase all in a loop.
                                       // Could move the beginning of loop below where you ask for the range
{
    Console.WriteLine("Please input the lower bound value: ");
    string answer = Console.ReadLine();
    int lowerBound = 0;

    lowerBound = ValidateInput(answer);

    //try
    //{
    //    lowerBound = int.Parse(answer);                    //control + k + c to comment out
    //}
    //catch (FormatException ex)
    //{
    //    Console.WriteLine("Please enter a number, not a string.");
    //}
    //catch (OverflowException ex)
    //{
    //    Console.WriteLine("The number you entered is too large or too small. Please enter a valid integer.");
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine("I don't know what went wrong ");
    //}

    Console.WriteLine("Please input the upper bound value: ");
    answer = Console.ReadLine();
    int upperBound = ValidateInput(answer, "Invalid input for uper bound, please try again.");

    // data type variable_name = value
    Random r = new Random();
    // int, bool, char are all primitive data types

    int rando = r.Next(lowerBound, upperBound + 1); // generate random number between 1 and 5 and stores to value rando.
                                                    // Could make rando a "var" instead of "int" and it would still work.
    int guess;
    int count = 0;

    do
    {
        Console.WriteLine($"Guess a number between {lowerBound} and {upperBound}: ");
        string userGuess = Console.ReadLine();
        guess = ValidateInput(userGuess, "Invalid input for guess, please try again"); // converts userGuess from string to int
                                            // or int guess = int.Parse(userGuess);
        count++; // increments count by 1 each time the loop runs, could say count = count + 1 or count += 1

        Console.WriteLine($"You guessed {userGuess}");

        //if (rando == guess)
        //{
        //    Console.WriteLine("You guessed correctly!");
        //}
        //else
        //{
        //    Console.WriteLine("You guessed incorrectly.");
        //} or the below if with the you guessed correctly outside the loop
        if (rando != guess)
        {
            if (guess > rando)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your guess was too high.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your guess was too low.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    } while (guess != rando);

    Console.WriteLine($"You guessed correctly! It took you {count} attempts.");

    Console.WriteLine($"Generated a random number with the value {rando}");
    //or Console.WriteLine("Generated a random number with the value " + rando); 

    Console.WriteLine("Would you like to play again? yes or no: ");
    answer = Console.ReadLine().ToLower();
    if (answer != "yes") // or (answer == "no")
    {
        break; // breaks out of the for loop
        i = int.MaxValue; // sets i to the max value so the for loop condition is false
        return; // exits the Main method and ends the program
    }
}


static int ValidateInput(string answer, string msg = "Invalid input for lower bound, please try again") // control + a + a to rename stuff
{
    int result;
    while (int.TryParse(answer, out result) == false)
    {
        Console.WriteLine(msg);
        answer = Console.ReadLine();
    }

    return result;
}