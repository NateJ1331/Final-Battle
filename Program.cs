using System;
namespace FinalBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            Player player = new Player();
            Display display = new Display();
            Magic magic = new Magic();
            Turn turn = new Turn();
            
            
            string quit = "no";

            while(quit != "yes")
            {
                Console.Clear();
                display.MainMenu();
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
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