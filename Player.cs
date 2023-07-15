namespace FinalBattle
{
     class Player:Game
    {
        private int _mana;
        private int _manatotal;

        public virtual void SetStats(){}

        private string _class;

        public int Mana
        {
            get {return _mana;}
            set 
            {
                _mana = value;
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
        override public int Attack()
        {
            return 0;
        }
    }
}