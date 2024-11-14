namespace MS_Foundational_C_
{
    internal class Challenge20
    {
        public static void Challenge()
        {
            if (ShouldPlay())
            {
                PlayGame();
            }

            bool ShouldPlay()
            {
                Console.WriteLine("Lets play the game? (Yes/No)");
                string? readResult = Console.ReadLine();

                if (readResult != null && (readResult.Equals("yes", StringComparison.OrdinalIgnoreCase) || readResult.Equals("y", StringComparison.OrdinalIgnoreCase)))
                {
                    return true;
                }
                else
                    return false;
            }

            int RollDice()
            {
                Random roll = new();
                return roll.Next(1, 7);
            }

            int SetTarget()
            {
                Random target = new();
                return target.Next(1, 6);
            }

            string WinOrLose(int roll, int target)
            {
                return roll > target ? "You win!" : "You loose!";
            }

            void PlayGame()
            {
                bool play = true;

                while (play)
                {
                    var target = SetTarget();
                    var roll = RollDice();

                    Console.WriteLine();
                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine();

                    play = ShouldPlay();
                }
            }
        }
    }
}
