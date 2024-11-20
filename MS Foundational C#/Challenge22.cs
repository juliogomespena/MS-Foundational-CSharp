namespace MS_Foundational_C_
{
    internal class Challenge22
    {
        public static void Challenge()
        {
            try
            {
                Process1();
            }
            catch
            {
                Console.WriteLine("An exception has occurred");
            }

            Console.WriteLine("Exit program");

            static void Process1()
            {
                try
                { 
                    WriteMessage(); 
                }
                catch
                {
                    Console.WriteLine("Caught in process1");
                }
            }

            static void WriteMessage()
            {
                double float1 = 3000.0;
                double float2 = 0.0;
                int number1 = 3000;
                int number2 = 0;

                Console.WriteLine(float1 / float2);
                Console.WriteLine(number1 / number2);
            }
        }
    }
}
