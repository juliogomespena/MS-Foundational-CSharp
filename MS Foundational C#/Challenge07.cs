namespace MS_Foundational_C_
{
    internal class Challenge07
    {
        public static void Challenge()
        {
            int heroHealth = 10, monsterHealth = 10;
            Random attack = new Random();

            do
            {
                int heroAttack = attack.Next(1, 11);
                monsterHealth -= heroAttack;

                Console.WriteLine($"Hero made an attack of {heroAttack} damage!");
                Console.WriteLine($"Remaining Monster health: {monsterHealth}");

                if (monsterHealth > 0)
                {
                    int monsterAttack = attack.Next(1, 11);
                    heroHealth -= monsterAttack;

                    Console.WriteLine($"Monster made an attack of {monsterAttack} damage!");
                    Console.WriteLine($"Remaining Hero health: {heroHealth}");

                }

            } while (heroHealth > 0 && monsterHealth > 0);

            Console.WriteLine("\n" + (heroHealth > monsterHealth ? "Hero won!" : "Monster won!"));
        }
    }
}
