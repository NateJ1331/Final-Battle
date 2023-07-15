namespace FinalBattle
{
    abstract class Game
    {
        public int _health;
        private bool _block;
        abstract public int Attack();

        
        public int Health
        {
            get {return _health;}
            set 
            {
                _health = value;
            }
        }

        public bool Block
        {
            get {return _block;}
            set 
            {
                _block = value;
            }
        }

       
        
        

    }  
}