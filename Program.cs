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
            Turn turn = new Turn();

            Console.Clear();
            while(player.Health > 0 && boss.Health >0)
            {
                turn.Player(player,boss,display);
            }
        }
    }
}