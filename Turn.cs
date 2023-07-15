namespace FinalBattle
{
    class Turn
    {
        public void Player(Player player,Boss boss, Display display,Magic magic)
        {
            display.BattleScreen(boss,player);

            string option = Console.ReadLine();
            int choice = Convert.ToInt32(option);
            player.Block = false;
            
            if(player.Mana < player.ManaTotal)
            {player.Mana += 2;}

            switch(choice)
            {
                case 1:
                    if(!boss.Block)
                    {boss.Health -= player.Attack();}
                    else
                    {
                        Console.WriteLine("Your attaked was blocked!");
                        Thread.Sleep(750);
                    }
                    break;

                case 2:
                    player.Block = true;    
                    
                    break;

                case 3:
                    boss.Health -= magic.CastSpell(player.Class,player);
                    break;
                }
        }

        public void Boss(Player player,Boss boss, Display display)
        {
            Random num = new Random();
            int action = num.Next(3);
            boss.Block = false;
            switch(action)
            {
                case 1:
                    if(!player.Block)
                    {player.Health -= boss.Attack();}
                    else
                    {
                        Console.WriteLine("You blocked their attack!");
                        Thread.Sleep(1000);
                    }
                    break;
                case 2:
                    boss.Block = true;
                    
                    break;

                case 3:
                    break;
           }

        }
        
    }  
}