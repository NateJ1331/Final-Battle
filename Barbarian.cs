namespace FinalBattle
{
    class Barbarian:Player
    {
        public override void SetStats()
        {
            this.Attack = 12;
            this.Health = 50;
            this.Mana = 20;
            this.ManaRegen = 1;
            this.ManaTotal = 20;
            this.Class = "Barbarian";
        }
    
    }
}