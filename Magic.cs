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

        public int IceBlast(Player player)
        {   
            if(player.Mana < 8)
            {
                Console.WriteLine("You dont have enough mana!");
                Thread.Sleep(750);
                return 0;
            }
            
            else
            {
                Console.WriteLine("You cast Ice Blast!");
                Thread.Sleep(750);
                player.Mana -= 8;
                return 8;
            }
               
        }

        public int CastSpell(string pClass, Player player)
        {
            switch(pClass)
            {
                case "Paladin":
                    return this.IceBlast(player);

                case "Wizard":
                    return this.Fireball(player);
                
                default:
                    return 0;
                
            }   
        }

    }
}