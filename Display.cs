namespace FinalBattle
{  
    class Display
    { 

        public void MainMenu()
        {
            Console.WriteLine("     =======================");
            Console.WriteLine("     |                     |");
            Console.WriteLine("     |    Final Battle     |");
            Console.WriteLine("     |                     |");
            Console.WriteLine("     =======================");
            Console.WriteLine();
            Console.WriteLine("     1.  Play");
            Console.WriteLine("     2.  Credits");
            Console.WriteLine("     3.  Quit");
            Console.WriteLine();
            Console.Write("> ");

        }

        public void ClassMenu()
        {
            Console.Clear();
            Console.WriteLine(" Which Class would you like to play?");
            Console.WriteLine(" 1. Barbarian");
            Console.WriteLine(" 2. Paladin");
            Console.WriteLine(" 3. Wizard");
        }

        public void Boss()
        {
            Console.WriteLine("                      ______________                           ");  
            Console.WriteLine("                ,===:'.,            `-._                       ");    
            Console.WriteLine("                 `:.`---.__         `-._                       ");
            Console.WriteLine("                   `:.     `--.         `.                     ");
            Console.WriteLine("                     \\.        `.         `.                   ");
            Console.WriteLine("             (,,(,    \\.         `.   ____,-`.,                ");
            Console.WriteLine("          (,'     `/   \\.   ,--.___`.'                       ");  
            Console.WriteLine("      ,  ,'  ,--.  `,   \\.;'         `                    ");     
            Console.WriteLine("       `{D, {    \\  :    \\;                            ");        
            Console.WriteLine("         V,,'    /  /    //                         ");           
            Console.WriteLine("         j;;    /  ,' ,-//.    ,---.      ,      ");              
            Console.WriteLine("         \\;'   /  ,' /  _  \\  /  _  \\   ,'/   ");                 
            Console.WriteLine("               \\   `'  / \\  `'  / \\  `.' / ");                    
            Console.WriteLine("                `.___,'   `.__,'   `.__,'  ");
        }
        public void Health(int health)
        {
            Console.Write("| ");
            for(int i = 0; i < health; i++)
            {
                Console.Write("■");
            }
            Console.Write(" |");
            
        }

        public void Mana(int mana)
        {
            Console.Write("  | ");
            for(int i = 0; i < mana; i++)
            {
                Console.Write("♦");
            }

            Console.Write(" |");
                
            
        }

        public void BattleScreen(Boss boss, Player player)
        {
            this.Health(boss.Health);
            Console.WriteLine("\n");
            this.Boss();
            Console.WriteLine("\n=========================================================");
            Console.WriteLine(player.Class);
            Console.Write("Mana: ");
            this.Mana(player.Mana);                  
            Console.Write("\nHealth: ");
            this.Health(player.Health);


            Console.WriteLine("\n\n1.Attack     2.Block     3.Magic\n");
        }

        public void WinScreen()
        {
            Console.Clear();
            Console.WriteLine("____    ____  ______    __    __     ____    __    ____  __  .__   __.     __  ");  
            Console.WriteLine("\\   \\  /   / /  __  \\  |  |  |  |    \\   \\  /  \\  /   / |  | |  \\ |  |    |  | ");
            Console.WriteLine(" \\   \\/   / |  |  |  | |  |  |  |     \\   \\/    \\/   /  |  | |   \\|  |    |  | ");
            Console.WriteLine("  \\_    _/  |  |  |  | |  |  |  |      \\            /   |  | |  . `  |    |  | ");
            Console.WriteLine("    |  |    |  `--'  | |  `--'  |       \\    /\\    /    |  | |  |\\   |    |__| ");
            Console.WriteLine("    |__|     \\______/   \\______/         \\__/  \\__/     |__| |__| \\__|    (__) ");
            Thread.Sleep(3000);
        }

        public void LoseScreen()
        {
            Console.Clear();
            Console.WriteLine("____    ____  ______    __    __      __        ______        _______. _______     __ ");
            Console.WriteLine("\\   \\  /   / /  __  \\  |  |  |  |    |  |      /  __  \\      /       ||   ____|   |  | ");
            Console.WriteLine(" \\   \\/   / |  |  |  | |  |  |  |    |  |     |  |  |  |    |   (----`|  |__      |  | ");
            Console.WriteLine("  \\_    _/  |  |  |  | |  |  |  |    |  |     |  |  |  |     \\   \\    |   __|     |  | ");
            Console.WriteLine("    |  |    |  `--'  | |  `--'  |    |  `----.|  `--'  | .----)   |   |  |____    |__| ");
            Console.WriteLine("    |__|     \\______/   \\______/     |_______| \\______/  |_______/    |_______|   (__)");
            Thread.Sleep(3000);
        }
        public void Credits()
        {
            Console.Clear();
            Console.WriteLine("All the coding and making it work: Nate J");
            Console.WriteLine("Boss Acii art: John VanderZwaag(www.asciiart.eu)");
            Console.Write("\nHit enter to continue:");
            Console.ReadLine();
        }
        
    }
}