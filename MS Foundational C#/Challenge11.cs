namespace MS_Foundational_C_
{
    internal class Challenge11
    {
        public static void Challenge()
        {
            string[] values = { "12,3", "45", "ABC", "11", "DEF" };
            string finalMessage = "";
            float finalSum = 0;

            foreach (string value in values)
            {
                if (float.TryParse(value, out float number))
                    finalSum += number;
                else
                    finalMessage += value;
            }
            Console.WriteLine(finalMessage);
            Console.WriteLine(finalSum);
        }
    }
}
