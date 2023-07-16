namespace FinalBattle
{
    class Turn
    {
        public void Player(Player player,Boss boss, Display display,Magic magic)
        {
            display.BattleScreen(boss,player);

            string choice = Console.ReadLine();
            player.Block = false;
            
            if(player.Mana < 0)
            {player.Mana = 0;}

            if(player.Mana < player.ManaTotal) 
            {player.Mana += player.ManaRegen;}
            

            switch(choice)
            {
                case "1":
                    if(!boss.Block)
                    {
                        boss.Health -= player.Attack;
                        Console.WriteLine("You hit your attack!");
                        Thread.Sleep(750);
                    }
                    else
                    {
                        Console.WriteLine("Your attaked was blocked!");
                        Thread.Sleep(750);
                    }
                    break;

                case "2":
                    player.Block = true;    
                    
                    break;

                case "3":
                    if(!boss.Block)
                    {
                        boss.Health -= magic.CastSpell(player);
                    }
                    else
                    {
                        Console.WriteLine("Some of your magic was blocked!");
                        boss.Health -= (magic.CastSpell(player)/2);
                        Thread.Sleep(750);
                    }
                    break;
                
                default:
                    break;
                }
        }

        public void Boss(Player player,Boss boss, Display display, Magic magic)
        {
            Random num = new Random();
            int action = num.Next(3);
            boss.Block = false;
            action += 1;
            switch(action)
            {
                case 1:
                    if(!player.Block)
                    {
                        player.Health -= boss.BossAttack();
                        Console.WriteLine("You were attacked!");
                        Thread.Sleep(750);
                    }
                    else
                    {
                        Console.WriteLine("You blocked their attack!");
                        Thread.Sleep(750);
                    }
                    break;
                case 2:
                    boss.Block = true;
                    
                    break;

                case 3:
                    if(!player.Block)
                    {player.Health -= magic.DragonClaw();}
                    else
                    {
                        Console.WriteLine("You blocked some of their attack!");
                        player.Health -= (magic.DragonClaw()/2);
                        Thread.Sleep(750);
                    }

                    break;
           }

        }
        
    }  
}