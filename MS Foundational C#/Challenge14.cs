using System.Collections.Immutable;

namespace MS_Foundational_C_
{
    internal class Challenge14
    {
        public static void Challenge()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            string[] orderStreamArray = orderStream.Split(',');
            Array.Sort(orderStreamArray);

            foreach (string order in orderStreamArray)
            {
                if (order.Length != 4)
                    Console.WriteLine(order + "\t - Error");
                else
                    Console.WriteLine(order);
            }
        }
    }
}
