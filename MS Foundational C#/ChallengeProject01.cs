﻿namespace MS_Foundational_C_
{
    internal class ChallengeProject01
    {
        public static void Challenge()
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
    }
}
