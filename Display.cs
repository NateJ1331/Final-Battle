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
        public void Health(int currenthealth)
        {
            Console.Write("| ");
            for(int i = 0; i < currenthealth; i++)
            {
                Console.Write("♦");
            }

            Console.Write(" |");
            
        }

        public void BattleScreen(Boss boss, Player player)
        {
            
            Console.WriteLine("\n=========================================================");
            this.Health(boss.Health);
            Console.WriteLine("\n");
            this.Boss();
            Console.WriteLine("\n=========================================================");
                                
            Console.WriteLine("\nYour Health: ");
            this.Health(player.Health);


            Console.WriteLine("\n\n1.Attack     2.Block     3.Magic\n");
        }


        public void Credits()
        {
            Console.Clear();
            Console.WriteLine("All the coding and making it work: Nate J");
            Console.WriteLine("Boss Acii art: John VanderZwaag(www.asciiart.eu)");
            Thread.Sleep(5000);
        }
        
    }
}