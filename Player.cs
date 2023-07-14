namespace FinalBattle
{
    class Player:Game
    {
        private int _mana = 30;
        public int Mana
        {
            get {return _mana;}
            set 
            {
                _mana = value;
            }
        }
        override public int Attack()
        {
            return 8;
        }
    }
}