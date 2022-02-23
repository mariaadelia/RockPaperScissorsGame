using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Welcome to Rock," +
                " Paper, Scissors The Battle -----------------");

            try
            {
                RockPaperScissorsResult();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Options PlayerChoice()
        {
            try
            {
                int option;
                Options testOption = new Options();
                Console.WriteLine("Select your weapon: \n[1] Rock \n[2] Paper" +
                    "\n[3] Scissors \n[4] Or leave the game");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        testOption = Options.Rock;
                        break;
                    case 2:
                        testOption = Options.Paper;
                        break;
                    case 3:
                        testOption = Options.Scissors;
                        break;
                    case 4:
                        testOption = Options.Exit;
                        break;
                    default:
                        Console.WriteLine($"The option {option} is invalid." +
                            " Try again");
                        break;
                }

                Console.WriteLine($"Your choice: {(Options)testOption}");
                return testOption;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Options ComputerChoice()
        {
            try
            {
                var randomNumber = new Random().Next(1, 3);
                Options computerChoice = (Options)randomNumber;
                Console.WriteLine($"Computer choice: {computerChoice}");
                return computerChoice;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RockPaperScissorsResult()
        {
            try
            {
                bool continuePlaying;
                do
                {
                    Options player = PlayerChoice();

                    //Logic to check if the player has exited
                    if (player == Options.Exit)
                    {
                        return;
                    }

                    Options computer = ComputerChoice();

                    //Logic to find the winner/loser
                    if (player != computer)
                    {
                        switch (player)
                        {
                            case Options.Rock:
                                //Rock x Paper
                                if (computer == Options.Paper)
                                {
                                    Console.WriteLine("GAME OVER :(");
                                }
                                //Rock x Scissors
                                else
                                {
                                    Console.WriteLine("VICTORY! :)");
                                }
                                break;

                            case Options.Paper:
                                //Paper x Scissors
                                if (computer == Options.Scissors)
                                {
                                    Console.WriteLine("GAME OVER :(");
                                }
                                //Paper x Rock
                                else
                                {
                                    Console.WriteLine("VICTORY! :)");
                                }
                                break;

                            case Options.Scissors:
                                //Scissors x Rock
                                if (computer == Options.Rock)
                                {
                                    Console.WriteLine("GAME OVER :(");
                                }
                                //Scissors x Paper
                                else
                                {
                                    Console.WriteLine("VICTORY! :)");
                                }
                                break;

                            default:
                                break;
                        }

                    }

                    //In case it's a draw
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }

                    Console.WriteLine("Continue? [Y]es/[N] or Another key");
                    char answer = Convert.ToChar(Console.ReadLine().ToLower());

                    if (answer == 'y')
                    {
                        continuePlaying = true;
                        Console.Clear();
                    }
                    else
                    {
                        continuePlaying = false;
                    }

                } while (continuePlaying == true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
