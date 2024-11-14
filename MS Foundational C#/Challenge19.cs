namespace MS_Foundational_C_
{
    internal class Challenge19
    {
        public static void Challenge()
        {
            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            DisplayEmails(corporate);
            DisplayEmails(external, externalDomain);
        }

        public static void DisplayEmails(string[,] name, string domain = "contoso.com")
        {
            for (int i = 0; i < name.GetLength(0); i++)
            {
                string email = name[i, 0].Substring(0, 2).ToLower() + name[i, 1].ToLower() + "@" + domain;
                Console.WriteLine(email);
            }
        }
    }
}
