namespace MS_Foundational_C_
{
    internal class Challenge09
    {
        private static void Challenge()
        {
            Console.WriteLine("Enter role: (Administrator / Manager / User)");

            string? role;
            bool validRole = false;

            do
            {
                role = Console.ReadLine();

                if (role != null)
                {
                    if (role.Trim().Equals("Administrator", StringComparison.OrdinalIgnoreCase))
                        validRole = true;
                    else if (role.Trim().Equals("Manager", StringComparison.OrdinalIgnoreCase))
                        validRole = true;
                    else if (role.Trim().Equals("User", StringComparison.OrdinalIgnoreCase))
                        validRole = true;
                    else
                        Console.WriteLine("Enter a valid role!");
                }

            } while (!validRole);

            Console.WriteLine("Valid role!");
        }
    }
}
