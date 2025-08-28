// data type variable_name = value
Random r = new Random();
// int, bool, char are all primitive data types

int rando = r.Next(1, 6); // generate random number between 1 and 5 and stores to value rando.
                          // Could make rando a "var" instead of "int" and it would still work.
int guess;
int count = 0;

do
{
    Console.WriteLine("Guess a number between 1 and 5: ");
    string userGuess = Console.ReadLine();
    guess = Convert.ToInt32(userGuess); // converts userGuess from string to int
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


