namespace FinalBattle
{
    class Magic
    {

        public int DragonClaw(Player player)
        {
            Console.WriteLine("Dragon Claw!");
            Thread.Sleep(750);
            return 16;
        }

        public int Fireball(Player player)
        {   
            if(player.Mana < 13)
            {
                Console.WriteLine("You dont have enough mana!");
                Thread.Sleep(750);
                return 0;
            }
            
            else
            {
                Console.WriteLine("Fireball!");
                Thread.Sleep(750);
                player.Mana -= 13;
                return 12;
            }
               
        }

        public int DivineSmite(Player player)
        {   
            if(player.Mana < 8)
            {
                Console.WriteLine("You dont have enough mana!");
                Thread.Sleep(750);
                return 0;
            }
            
            else
            {
                Console.WriteLine("Divine Smite");
                Thread.Sleep(750);
                player.Mana -= 12;
                return 8;
            }
               
        }

        public int RecklessAttack(Player player)
        {   
            if(player.Mana < 10)
            {
                Console.WriteLine("You dont have enough mana!");
                Thread.Sleep(750);
                return 0;
            }
            
            else
            {
                Console.WriteLine("You attack Recklessly");
                Thread.Sleep(750);
                player.Mana -= 13;
                player.Health -= 3;
                return player.Attack*2;
            }
               
        }

        public int CastSpell(Player player)
        {
            switch(player.Class)
            {
                case "Paladin":
                    return this.DivineSmite(player);

                case "Wizard":
                    return this.Fireball(player);
                
                case "Barbarian":
                    return this.RecklessAttack(player);

                default:
                    return 0;
                
            }   
        }

    }
}