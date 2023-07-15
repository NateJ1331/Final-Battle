namespace FinalBattle
{
     class Player:Game
    {
        
        private int _mana;
        private int _manatotal;
        private int _manaregen;
        private string _class;
        public virtual void SetStats(){}

        public int Mana
        {
            get {return _mana;}
            set 
            {
                _mana = value;
            }
        }

        public int ManaRegen
        {
            get {return _manaregen;}
            set 
            {
                _manaregen = value;
            }
        }

        public int ManaTotal
        {
            get {return _manatotal;}
            set 
            {
                _manatotal = value;
            }
        }
        public string Class
        {
            get {return _class;}
            set 
            {
                _class = value;
            }
        }
    }
}