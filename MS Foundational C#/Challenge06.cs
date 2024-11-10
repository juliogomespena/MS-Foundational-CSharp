namespace MS_Foundational_C_
{
    internal class Challenge06
    {
        private static void Challenge()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine(i + " Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine(i + " Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
