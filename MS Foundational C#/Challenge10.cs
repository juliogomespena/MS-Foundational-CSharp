namespace MS_Foundational_C_
{
    internal class Challenge10
    {
        private static void Challenge()
        {
            string[] myStrings = { "I like pizza. I like roast chicken. I like salad. I like meat. I like potatoes. I like tomatoes", "I like all three of the menu choices. I like anything" };

            int periodLocation;

            for (int i = 0; i < myStrings.Length; i++)
            {
                string myString = myStrings[i];
                periodLocation = myString.IndexOf('.');

                while (periodLocation != -1)
                {
                    Console.WriteLine(myString.Substring(0, periodLocation));

                    myString = myString.Remove(0, periodLocation + 1).TrimStart();

                    periodLocation = myString.IndexOf('.');
                }

                if (!string.IsNullOrWhiteSpace(myString))
                {
                    Console.WriteLine(myString);
                }
            }
        }
    }
}
