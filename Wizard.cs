namespace FinalBattle
{
    class Wizard:Player
    {
        public override void SetStats()
        {
            this.Attack = 5;
            this.Health = 25;
            this.Mana = 50;
            this.ManaRegen = 5;
            this.ManaTotal = 50;
            this.Class = "Wizard";
        }
    }
}