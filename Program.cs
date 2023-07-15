using System;
namespace FinalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            Display display = new Display();
            Magic magic = new Magic();
            Turn turn = new Turn();
            Player player = new Player();
            
            boss.Health = 100;
            string quit = "no";

            while(quit != "yes")
            {
                Console.Clear();
                display.MainMenu();
                string choice = Console.ReadLine();
                
                switch(choice)
                {
                    case "1":
                        display.ClassMenu();
                        string choice2 = Console.ReadLine();
                        switch(choice2)
                        {
                            case "1":
                                player = new Barbarian();
                                player.SetStats();
                                break;
                            case "2":
                                player = new Paladin();
                                player.SetStats();
                                break;
                            case "3":
                                player = new Wizard();
                                player.SetStats();
                                break;
                        }
    
                        while(player.Health > 0 && boss.Health >0)
                        {
                            Console.Clear();
                            turn.Player(player,boss,display,magic);
                            turn.Boss(player,boss,display);
                        }
                    break;

                    case "2":
                    display.Credits();
                    break;

                    case "3":
                    quit = "yes";
                    break;
                }
            }
        }
    }
}