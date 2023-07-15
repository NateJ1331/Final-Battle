namespace FinalBattle
{
    class Barbarian:Player
    {
        public override void SetStats()
        {
            this.Attack = 10;
            this.Health = 50;
            this.Mana = 15;
            this.ManaRegen = 1;
            this.ManaTotal = 15;
            this.Class = "Barbarian";
        }
    
    }
}