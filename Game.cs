namespace FinalBattle
{
    class Game
    {
        public int _health;
        private bool _block;
        private int _attack;

        public int Attack
        {
            get {return _attack;}
            set 
            {
                _attack = value;
            }
        }
        
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