namespace FinalBattle
{
    class Boss:Game
    {
        public int BossAttack()
        {
            Random num = new Random();
            int action = num.Next(5);

            return action + 5;
        }

    }
}