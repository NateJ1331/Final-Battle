namespace FinalBattle
{
    class Wizard:Player
    {
        public override void SetStats()
        {
            this.Health = 25;
            this.Mana = 50;
            this.ManaTotal = 50;
            this.Class = "Wizard";
        }
        override public int Attack()
        {
            return 3;
        }
    }
}