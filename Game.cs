namespace FinalBattle
{
    abstract class Game
    {
        public int _health = 50;
        
        private bool block;
        abstract public int Attack();

        public int Health
        {
            get {return _health;}
            set 
            {
                _health = value;
            }
        }

       
        
        

    }  
}