namespace MS_Foundational_C_
{
    internal class Challenge13
    {
        public static void Challenge()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] pangramWords = pangram.Split(' ');
            string[] pangramWordsResult = new string[pangramWords.Length];

            int pangramWordsCounter = 0;
            foreach (string word in pangramWords)
            {
                char[] wordArray = word.ToCharArray();
                Array.Reverse(wordArray);
                pangramWordsResult[pangramWordsCounter] = new string(wordArray);
                pangramWordsCounter++;
            }

            string pangramReversed = string.Join(' ', pangramWordsResult);
            Console.WriteLine(pangramReversed);
        }
                
    }
}
