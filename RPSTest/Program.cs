using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("Welcome to the Rock Paper Scissors Game");
                Console.WriteLine("The rules are standard RPS rules. First to win 3 rounds will win the game.");
                Console.WriteLine("Good Luck!");

                Game RPS = new Game();
                RPS.initPlayers();

                Console.WriteLine("Player 1, please enter a name: ");
                string p1name = Console.ReadLine();

                Console.WriteLine("Player 2, please enter a name: ");
                string p2name = Console.ReadLine();

                RPS.setNames(p1name, p2name);

                Console.WriteLine(RPS.curentScore());

                bool hasWon = false;
                while (!hasWon)
                {

                    Console.WriteLine("Player 1: {0}; please select a move: ", RPS.p1.userName);
                    string p1move = moveChoice();
                    Console.WriteLine("Player 2: {0}; please select a move: ", RPS.p2.userName);
                    string p2move = moveChoice();

                    RPS.setMove(p1move, p2move);
                    RPS.checkRPS();

                    Console.WriteLine(RPS.curentScore());
                    hasWon = RPS.checkWinner();

                }

                Console.WriteLine("Enter 1 to keep playing or 0 to quit.");
                int keep = Int32.Parse(Console.ReadLine());
                if (keep == 1)
                {
                    keepPlaying = true;
                }
                else if (keep == 0)
                {
                    keepPlaying = false;
                }


            }
            







            Console.WriteLine("Program has finished executing.\nPress any key to continue...");
            Console.ReadKey();
        }

        static string moveChoice()
        {
            int choice;
            string move = String.Empty;
            Console.WriteLine("Select a valid option:\n\t1 - Rock\n\t2- Paper\n\t3 - Scissors");
            choice = Int32.Parse(Console.ReadLine());
            if (choice == 1)
            {
                move = "ROCK";
            }
            else if (choice == 2)
            {
                move = "PAPER";
            }
            else if (choice == 3)
            {
                move = "SCISSORS";
            }



            return move;
        }
    }
}
