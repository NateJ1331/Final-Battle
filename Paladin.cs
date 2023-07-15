namespace FinalBattle
{
    class Paladin:Player
    {
        public override void SetStats()
        {
            this.Attack = 8;
            this.Health = 45;
            this.Mana = 30;
            this.ManaRegen = 2;
            this.ManaTotal = 30;
            this.Class = "Paladin";
        }
    }       
}