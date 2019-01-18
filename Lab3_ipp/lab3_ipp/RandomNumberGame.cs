using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ipp
{
    class RandomNumberGame : Game
    {
        Memento mem = new Memento("initialize");
        Originator originator = new Originator();

        int guessNumber = 0;
        int inputInt = 0;
        int triesLeft = 0;
        protected override void Initialize()
        {
            Console.WriteLine("Starting new game");
            Console.Write("Input the range:");
            string input = Console.ReadLine();
            inputInt = Int32.Parse(input);
            Random r = new Random();
            guessNumber = r.Next(0, inputInt);
            triesLeft = 5;
            originator.State = "startgame";
            mem = originator.saveStateToMememnto();
        }
        protected override void StartPlay()
        {
            while (mem.State != "endgame")
            {
                switch(mem.State)
                {
                    case "startgame":
                        Console.WriteLine($"The game has started, guess the number from 0 to ${inputInt}, ${triesLeft} tries left");
                        string guessedNr = Console.ReadLine();
                        if (guessedNr == guessedNr.ToString())
                        {
                            originator.State = "gamewon";
                            mem = originator.saveStateToMememnto();
                        }
                        else
                        {
                            originator.State = "wronganswer";
                            mem = originator.saveStateToMememnto();
                        }
                        if (triesLeft == 0)
                        {
                            originator.State = "endgame";
                            mem = originator.saveStateToMememnto();
                        }
                        break;
                    case "wrongasnwer":
                        Console.WriteLine("Wrong answer.");
                        triesLeft--;
                        originator.State = "initialized";
                        mem = originator.saveStateToMememnto();
                        break;
                    case "gamelost":
                        Console.WriteLine("You have lost.");
                        originator.State = "playagain";
                        mem = originator.saveStateToMememnto();
                        break;
                    case "gamewon":
                        Console.WriteLine("You have won.");
                        originator.State = "playagain";
                        mem = originator.saveStateToMememnto();
                        break;
                    case "playagain":
                        Console.WriteLine("Do you want to play again? (Y/N)");
                        string response = Console.ReadLine();
                        if (response == "Y")
                        {
                            originator.State = "";
                        }
                        else
                        {
                            originator.State = "endgame";
                        }
                        mem = originator.saveStateToMememnto();
                        break;
                }         
            }        
        }
        protected override void EndPlay()
        {
            Console.WriteLine("The game is done.");
        }
    }
}
