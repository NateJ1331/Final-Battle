namespace FinalBattle
{
    class Boss:Game
    {
        public int BossAttack()
        {
            Random num = new Random();
            int action = num.Next(8);

            return action + 5;
        }

    }
}