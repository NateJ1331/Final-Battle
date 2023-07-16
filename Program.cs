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
            
            
            string quit = "no";

            while(quit != "yes")
            {
                Console.Clear();
                display.MainMenu();
                string choice = Console.ReadLine();
                boss.Health = 80;
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
                            if(boss.Health <= 0)
                            {
                                display.WinScreen();
                                break;
                            }
                            turn.Boss(player,boss,display,magic);
                            if(player.Health <= 0)
                            {
                                display.LoseScreen();
                                break;
                            }
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