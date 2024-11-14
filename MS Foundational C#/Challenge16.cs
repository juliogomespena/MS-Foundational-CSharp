namespace MS_Foundational_C_
{
    internal class Challenge16
    {
        public static void Challenge()
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int openSpanPosition = input.IndexOf(openSpan);
            int closeSpanPosition = input.IndexOf(closeSpan);
            openSpanPosition += openSpan.Length;

            string quantity = input.Substring(openSpanPosition, closeSpanPosition - openSpanPosition);

            string output = input;

            const string openDiv = "<div>";
            const string closeDiv = "</div>";

            int openDivPosition = output.IndexOf(openDiv);
            output = output.Remove(openDivPosition, openDiv.Length);

            int closeDivPosition = output.IndexOf(closeDiv);
            output = output.Remove(closeDivPosition, closeDiv.Length);

            output = output.Replace("&trade", "&reg");

            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Output: " + output);
        }
    }
}
