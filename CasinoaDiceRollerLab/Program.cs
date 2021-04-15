using System;

namespace CasinoaDiceRollerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Casino Dice Roller");
            Console.WriteLine();
            Console.WriteLine("How many sides should each die have?");
            int sides = int.Parse(Console.ReadLine());
            Console.WriteLine("Press enter to roll dice");
            Console.WriteLine();
      
            bool loopAgain = true;
            while (loopAgain)
            {
                
                for (int i = 0; i < 6; i++)
                {

                    int roll;
                    int rollAgain;
                    Random randomizer = new Random();
                    roll = randomizer.Next(1, 7);
                    rollAgain = randomizer.Next(1, 7);
                    int total = roll + rollAgain;

                    Console.WriteLine($"You rolled a {roll} and a {rollAgain}. Your total is {total}");


                    if (total == 7 || total == 11)
                    {
                        Console.WriteLine("Win!");
                    }
                    else if (total == 2 || total == 3 || total == 12)
                    {
                        Console.WriteLine("Craps!");
                    }
                    else if (roll == 6 && rollAgain == 6)
                    {
                        Console.WriteLine("Box Cars");
                    }
                    else if (roll == 1 && rollAgain == 2)
                    {
                        Console.WriteLine("Ace Deuces");
                    }
                    else if (roll == 1 && rollAgain == 1)
                    {
                        Console.WriteLine("Snake Eyes");
                    }
                    else
                    {
                        break;
                    }
                }
                    Console.WriteLine("Roll Again? y/n");
                    string result = Console.ReadLine().ToLower();
                    while (true)
                    {
                        if (result == "y")
                        {
                            break;
                        }
                        else if (result == "n")
                        {
                            Console.WriteLine("Thanks for playing!");
                            loopAgain = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not a y/n");
                            break;
                        }
                    }

                    Console.ReadLine();

                
            }



        }


    }
}

