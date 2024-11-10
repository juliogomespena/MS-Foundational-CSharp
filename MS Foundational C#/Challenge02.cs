namespace MS_Foundational_C_
{
    internal class Challenge02
    {
        public static void Challenge()
        {
            Random coinFlip = new Random();

            Console.WriteLine(coinFlip.Next(1, 3) == 1 ? "Head" : "Tail");
        }
    }
}
