namespace FinalBattle
{
    class Barbarian:Player
    {
        public override void SetStats()
        {
            this.Health = 50;
            this.Mana = 20;
            this.ManaTotal = 20;
            this.Class = "Barbarin";
        }
        override public int Attack()
        {
            return 12;
        }
    }
}