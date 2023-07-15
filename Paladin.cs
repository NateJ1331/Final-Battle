namespace FinalBattle
{
    class Paladin:Player
    {
        public override void SetStats()
        {
            this.Health = 40;
            this.Mana = 30;
            this.ManaRegen = 2;
            this.ManaTotal = 30;
            this.Class = "Paladin";
        }
        override public int Attack()
        {
            return 8;
        }
    }
}