namespace MS_Foundational_C_
{
    internal class Challenge01
    {
        public static void Challenge()
        {
            string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

            int[] studentScores = new int[7];

            int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = { 90, 95, 87, 88, 96, 96 };
            int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
            int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };

            int currentAssingments = 5;

            Console.WriteLine("Student\t\tExam score\t\tOverall Grade\t\tExtra credits\n");

            foreach (string studentName in studentNames)
            {
                string currentStudent = studentName;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (studentName == "Andrew")
                    studentScores = andrewScores;

                else if (studentName == "Emma")
                    studentScores = emmaScores;

                else if (studentName == "Logan")
                    studentScores = loganScores;

                else if (studentName == "Becky")
                    studentScores = beckyScores;

                else if (studentName == "Chris")
                    studentScores = chrisScores;

                else if (studentName == "Eric")
                    studentScores = ericScores;

                else if (studentName == "Gregor")
                    studentScores = gregorScores;
                else
                    continue;

                decimal studentScore = 0.00m;

                int assingmentsCount = 0;

                int extraCreditCount = 0;

                decimal examScore = 0.00m;

                decimal extraCreditScore = 0.00m;

                foreach (int score in studentScores)
                {
                    if (assingmentsCount < currentAssingments)
                    {
                        examScore += score;
                    }

                    else
                    {
                        extraCreditScore += score;
                        extraCreditCount++;
                    }

                    assingmentsCount++;
                }

                decimal examScoreAverage = examScore / currentAssingments;

                decimal extraCreditScoreAverage = (extraCreditScore / 10) / currentAssingments;

                studentScore = examScoreAverage + (extraCreditScoreAverage);

                string studentLetterGrade = "";

                if (studentScore >= 97)
                    studentLetterGrade = "A+";

                else if (studentScore >= 93)
                    studentLetterGrade = "A";

                else if (studentScore >= 90)
                    studentLetterGrade = "A-";

                else if (studentScore >= 87)
                    studentLetterGrade = "B+";

                else if (studentScore >= 83)
                    studentLetterGrade = "B";

                else if (studentScore >= 80)
                    studentLetterGrade = "B-";

                else if (studentScore >= 77)
                    studentLetterGrade = "C+";

                else if (studentScore >= 73)
                    studentLetterGrade = "C";

                else if (studentScore >= 70)
                    studentLetterGrade = "C-";

                else if (studentScore >= 67)
                    studentLetterGrade = "D+";

                else if (studentScore >= 63)
                    studentLetterGrade = "D";

                else if (studentScore >= 60)
                    studentLetterGrade = "D-";
                else
                    studentLetterGrade = "F";

                Console.WriteLine($"{currentStudent}:\t\t   {examScoreAverage:F2}\t\t   {studentScore:F2} {studentLetterGrade}\t\t   {(int)extraCreditScore / extraCreditCount}({extraCreditScoreAverage:F2})");
            }
            Console.WriteLine("\nPress the Enter key to continue");
            Console.ReadLine();
        }
    }
}
