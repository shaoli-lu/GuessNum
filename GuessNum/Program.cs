using System;

namespace GuessNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool replay = true;
            string response;
            while (replay)
            {
                Random random = new Random();
                int answer = random.Next(1, 101);
                bool noDeal = true;
                int i = 0;
                bool yesno = false;

                while (noDeal)
                {
                    Console.WriteLine("Guess a number (1 to 100): ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    i++;
                    if (guess == answer)
                    {
                        Console.WriteLine($"You won with only {i} trys! The correct number is {guess}.");
                        noDeal = false;

                        Console.WriteLine("Want to play again? (Y/N)");
                        while (yesno == false)
                        {
                            response = Console.ReadLine();
                            if (response.ToUpper() == "Y")
                            { replay = true;
                              yesno = true;
                            }
                            else if (response.ToUpper() == "N")
                            { replay = false;
                              yesno = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Entry, try again (Y/N)");
                                yesno = false;
                            }
                        }

                    }
                    else if (guess > answer)
                    {
                        Console.WriteLine($"The number is too big.");
                    }
                    else
                    {
                        Console.WriteLine($"The number is too small.");

                    }

                }

            }
        }
        
    }
}
