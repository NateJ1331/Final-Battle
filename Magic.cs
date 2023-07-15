namespace FinalBattle
{
    class Magic
    {

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
                Console.WriteLine("You cast Fireball!");
                Thread.Sleep(750);
                player.Mana -= 13;
                return 12;
            }
               
        }

        public int HolySlash(Player player)
        {   
            if(player.Mana < 8)
            {
                Console.WriteLine("You dont have enough mana!");
                Thread.Sleep(750);
                return 0;
            }
            
            else
            {
                Console.WriteLine("You cast Holy Slash");
                Thread.Sleep(750);
                player.Mana -= 8;
                return 8;
            }
               
        }

        public int Rage(Player player)
        {   
            if(player.Mana < 15)
            {
                Console.WriteLine("You dont have enough mana!");
                Thread.Sleep(750);
                return 0;
            }
            
            else
            {
                Console.WriteLine("You Become enraged!");
                Thread.Sleep(750);
                player.Mana -= 18;
                return 10;
            }
               
        }

        public int CastSpell(string pClass, Player player)
        {
            switch(pClass)
            {
                case "Paladin":
                    return this.HolySlash(player);

                case "Wizard":
                    return this.Fireball(player);
                
                case "Barbarian":
                    return this.Rage(player);

                default:
                    return 0;
                
            }   
        }

    }
}