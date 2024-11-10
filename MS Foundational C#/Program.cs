using System.Xml;

namespace MS_Foundational_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChalengeProject01();
        }

        private static void ChalengeProject01()
        {
            // the ourAnimals array will store the following: 
            string animalSpecies = "";
            string animalID = "";
            string animalAge = "";
            string animalPhysicalDescription = "";
            string animalPersonalityDescription = "";
            string animalNickname = "";

            // variables that support data entry
            int maxPets = 8;
            string? readResult;
            string menuSelection = "";

            // array used to store runtime data, there is no persisted data
            string[,] ourAnimals = new string[maxPets, 6];

            bool validEntry = false;

            // create some initial ourAnimals array entries
            for (int i = 0; i < maxPets; i++)
            {
                switch (i)
                {
                    case 0:
                        animalSpecies = "dog";
                        animalID = "d1";
                        animalAge = "2";
                        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                        animalNickname = "lola";
                        break;

                    case 1:
                        animalSpecies = "dog";
                        animalID = "d2";
                        animalAge = "9";
                        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                        animalNickname = "loki";
                        break;

                    case 2:
                        animalSpecies = "cat";
                        animalID = "c3";
                        animalAge = "1";
                        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                        animalPersonalityDescription = "friendly";
                        animalNickname = "Puss";
                        break;

                    case 3:
                        animalSpecies = "cat";
                        animalID = "c4";
                        animalAge = "?";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;

                    default:
                        animalSpecies = "";
                        animalID = "";
                        animalAge = "";
                        animalPhysicalDescription = "";
                        animalPersonalityDescription = "";
                        animalNickname = "";
                        break;
                }

                ourAnimals[i, 0] = "ID #: " + animalID;
                ourAnimals[i, 1] = "Species: " + animalSpecies;
                ourAnimals[i, 2] = "Age: " + animalAge;
                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
            }

            // display the top-level menu options
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
                Console.WriteLine(" 1. List all of our current pet information");
                Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
                Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
                Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
                Console.WriteLine(" 5. Edit an animal’s age");
                Console.WriteLine(" 6. Edit an animal’s personality description");
                Console.WriteLine(" 7. Display all cats with a specified characteristic");
                Console.WriteLine(" 8. Display all dogs with a specified characteristic");
                Console.WriteLine();
                Console.Write("Enter your selection number (or type Exit to exit the program): ");

                readResult = Console.ReadLine();

                if (readResult != null)
                    menuSelection = readResult;

                Console.WriteLine();

                if (menuSelection.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine("Have a nice day!");
                else if (int.TryParse(menuSelection, out int menuNumber) == false)
                    Console.WriteLine("Please select a valid menu option!");
                else
                {
                    switch (menuNumber)
                    {
                        case 1:                            
                            for (int i = 0; i < maxPets; i++)
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    if (ourAnimals[i, j] == "ID #: ")
                                        break;

                                    Console.WriteLine(ourAnimals[i, j]);
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                            break;

                        case 2:
                            // Add a new animal friend to the ourAnimals array
                            string anotherPet = "y";
                            int petCount = 0;

                            for (int i = 0; i < maxPets; i++)
                            {
                                if (ourAnimals[i, 0] != "ID #: ")
                                    petCount++;
                            }

                            if (petCount < maxPets)
                            {
                                while (petCount < maxPets && anotherPet.Equals("y", StringComparison.OrdinalIgnoreCase))
                                {
                                    Console.WriteLine($"\nWe currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");

                                    validEntry = false;

                                    do
                                    {
                                        Console.WriteLine("Enter 'dog' or 'cat' to begin a new entry");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                            animalSpecies = readResult;

                                        if (animalSpecies.Equals("cat", StringComparison.OrdinalIgnoreCase) || animalSpecies.Equals("dog", StringComparison.OrdinalIgnoreCase))
                                            validEntry = true;

                                    } while (validEntry == false);

                                    animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString().ToLower();

                                    validEntry = false;

                                    do
                                    {
                                        Console.WriteLine("Enter the pet's age or enter ? if unknown");
                                        readResult = Console.ReadLine();

                                        if (readResult != null && (readResult == "?" || int.TryParse(readResult, out _)))
                                        {
                                            animalAge = readResult;
                                            validEntry = true;
                                        }

                                    } while (validEntry == false);

                                    do
                                    {
                                        Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                        {
                                            animalPhysicalDescription = readResult;

                                            if (animalPhysicalDescription == "")
                                                animalPhysicalDescription = "tbd";
                                        }

                                    } while (animalPhysicalDescription == "");

                                    do
                                    {
                                        Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                        {
                                            animalPersonalityDescription = readResult;

                                            if (animalPersonalityDescription == "")
                                                animalPersonalityDescription = "tbd";
                                        }

                                    } while (animalPersonalityDescription == "");

                                    do
                                    {
                                        Console.WriteLine("Enter a nickname for the pet");
                                        readResult = Console.ReadLine();

                                        if (readResult != null)
                                        {
                                            animalNickname = readResult;

                                            if (animalNickname == "")
                                                animalNickname = "tbd";
                                        }
                                    } while (animalNickname == "");

                                    petCount++;

                                    ourAnimals[petCount, 0] = "ID #: " + animalID;
                                    ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                                    ourAnimals[petCount, 2] = "Age: " + animalAge;
                                    ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                                    ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                                    ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                                    if (petCount >= maxPets)
                                    {
                                        Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                                        Console.WriteLine("Press the Enter key to continue.");
                                        readResult = Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nDo you want to enter info for another pet (y/n)");

                                        do
                                        {
                                            readResult = Console.ReadLine();

                                            if (readResult != null)
                                                anotherPet = readResult;

                                        } while (!(anotherPet.Equals("y", StringComparison.OrdinalIgnoreCase) || anotherPet.Equals("n", StringComparison.OrdinalIgnoreCase)));
                                    }
                                }
                            }
                            break;

                        case 3:
                            // Ensure animal ages and physical descriptions are complete / AGE [2] PHYSICAL DESCRIPTION [4]
                            for (int i = 0; i < maxPets; i++)
                            {
                                if (ourAnimals[i, 0] == "ID #: ")
                                    continue;


                                if (ourAnimals[i, 2] == "Age: ?" || ourAnimals[i, 2] == "Age: ")
                                {
                                    validEntry = false;

                                    do
                                    {
                                        Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                                        readResult = Console.ReadLine();

                                        if (readResult != null && int.TryParse(readResult, out _))
                                        {
                                            animalAge = readResult;
                                            validEntry = true;
                                        }

                                    } while (validEntry == false);
                                }

                                if (ourAnimals[i, 4] == "Physical description: tbd" || ourAnimals[i, 4] == "Physical description: ")
                                {
                                    validEntry = false;

                                    do
                                    {
                                        Console.WriteLine($"Enter an physical description of at least 20 characters for {ourAnimals[i, 0]}");
                                        readResult = Console.ReadLine();

                                        if (readResult != null && readResult.Length > 20)
                                        {
                                            animalPhysicalDescription = readResult;
                                            validEntry = true;
                                        }
                                        else
                                            Console.WriteLine("Description should cointain all infos requested and be at least 20 characters long!");

                                    } while (validEntry == false);
                                }

                                ourAnimals[i, 2] = "Age: " + animalAge;
                                ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;

                                Console.WriteLine();
                            }

                            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                            break;

                        case 4:
                            //Ensure animal nicknames and personality descriptions are complete
                            for (int i = 0; i < maxPets; i++)
                            {
                                if (ourAnimals[i, 0] == "ID #: ")
                                    continue;


                                if (ourAnimals[i, 3] == "Nickname: tbd" || ourAnimals[i, 3] == "Nickname: ")
                                {
                                    validEntry = false;

                                    do
                                    {
                                        Console.WriteLine($"Enter an nickname of at least 2 characters for {ourAnimals[i, 0]}");
                                        readResult = Console.ReadLine();

                                        if (readResult != null && readResult.Length > 2)
                                        {
                                            animalNickname = readResult;
                                            validEntry = true;
                                        }
                                        else
                                            Console.WriteLine("Nickname should cointain at least 2 characters!");


                                    } while (validEntry == false);
                                }

                                if (ourAnimals[i, 5] == "Personality: tbd" || ourAnimals[i, 5] == "Personality: ")
                                {
                                    validEntry = false;

                                    do
                                    {
                                        Console.WriteLine($"Enter an personality of at least 5 characters for {ourAnimals[i, 0]}");
                                        readResult = Console.ReadLine();

                                        if (readResult != null && readResult.Length > 5)
                                        {
                                            animalPersonalityDescription = readResult;
                                            validEntry = true;
                                        }
                                        else
                                            Console.WriteLine("Personality should cointain at least 5 characters!");

                                    } while (validEntry == false);
                                }

                                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

                                Console.WriteLine();
                            }

                            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                            break;

                        case 5:
                            //Edit an animal’s age
                            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                            break;

                        case 6:
                            //Edit an animal’s personality description
                            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                            break;

                        case 7:
                            //Display all cats with a specified characteristic
                            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                            break;

                        case 8:
                            //Display all dogs with a specified characteristic
                            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                            Console.WriteLine("Press the Enter key to continue.");
                            readResult = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Please select a valid menu option!");
                            break;

                    }
                }
            } while (!menuSelection.Equals("exit", StringComparison.OrdinalIgnoreCase));

        }

        private static void Challenge10()
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

        private static void Challenge09()
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

        private static void Challenge08()
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

        private static void Challenge07()
        {
            int heroHealth = 10, monsterHealth = 10;
            Random attack = new Random();

            do
            {
                int heroAttack = attack.Next(1, 11);
                monsterHealth -= heroAttack;

                Console.WriteLine($"Hero made an attack of {heroAttack} damage!");
                Console.WriteLine($"Remaining Monster health: {monsterHealth}");

                if (monsterHealth > 0)
                {
                    int monsterAttack = attack.Next(1, 11);
                    heroHealth -= monsterAttack;

                    Console.WriteLine($"Monster made an attack of {monsterAttack} damage!");
                    Console.WriteLine($"Remaining Hero health: {heroHealth}");

                }

            } while (heroHealth > 0 && monsterHealth > 0);

            Console.WriteLine("\n" + (heroHealth > monsterHealth ? "Hero won!" : "Monster won!"));
        }

        private static void Challenge06()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i + " FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine(i + " Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine(i + " Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        private static void Challenge05()
        {
            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }

        private static void Challenge04()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;

            bool found = false;

            foreach (int number in numbers)
            {
                total += number;

                if (number == 42)
                    found = true;
            }

            if (found)
                Console.WriteLine("Set contains 42");

            Console.WriteLine($"Total: {total}");
        }

        private static void Challenge03()
        {
            string permission = "caller";
            int level = 30;

            if (permission.Contains("Admin"))
                Console.WriteLine($"Welcome, {(level > 55 ? "Super Admin" : "Admin")} user.");
            else if (permission.Contains("Manager"))
                Console.WriteLine($"{(level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")}");
            else
                Console.WriteLine("You do not have sufficient privileges.");
        }

        private static void Challenge02()
        {
            Random coinFlip = new Random();

            Console.WriteLine(coinFlip.Next(1, 3) == 1 ? "Head" : "Tail");
        }

        private static void Challenge01()
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
