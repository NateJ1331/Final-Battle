namespace FinalBattle
{
    class Turn
    {
               public void Player(Player player,Boss boss, Display display)
        {
            display.BattleScreen(boss,player);

            string option = Console.ReadLine();
            int choice = Convert.ToInt32(option);

            switch(choice)
            {
                case 1:
                    boss.Health -= player.Attack();
                    break;

                case 2:
                    
                    break;

                case 3:
                    break;
                }
        }

        public void Boss(Player player,Boss boss, Display display)
        {


        }
        
    }  
}