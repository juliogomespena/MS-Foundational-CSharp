namespace MS_Foundational_C_
{
    internal class Challenge08
    {
        public static void Challenge()
        {
            string? input;
            int numericInput;
            bool validInput = false;

            Console.WriteLine("Enter an integer numeric value between 5 and 10: ");

            do
            {
                input = Console.ReadLine();

                if (input != null)
                {
                    if (int.TryParse(input, out numericInput))
                    {
                        if (numericInput >= 5 && numericInput <= 10)
                            validInput = true;
                        else
                            Console.WriteLine("Enter a integer between 5 and 10!");
                    }
                    else
                        Console.WriteLine("Input not a integer numeric value!");
                }
                else
                    Console.WriteLine("Enter a numeric value between 5 and 10!");

            } while (!validInput);

            Console.WriteLine("Valid input -> " + input);
        }
    }
}
