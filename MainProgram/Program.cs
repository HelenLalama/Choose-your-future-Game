// See https://aka.ms/new-console-template for more information
using System;
using Lucas;
using Athanasia;
using Izekiel;
using Jenneth;

using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public const string Contine = "\nPress any key to continue: ";
        static void Main(string[] args)
        {
            Clear();

            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("----------------------------------------------------");
            WriteLine("------------ Welcome to the Fate Game -------------");
            WriteLine("----------------------------------------------------");

            int choice;
            do
            {
                choice = MainMenu();
                Clear();
                switch (choice)
                {
                    case 1:
                        while (true)
                        {
                            BackGround();
                            break;
                        }
                        break;
                    case 2:
                        int Profiles;
                        while (true)
                        {
                            Profiles = CharactersMenu();
                            Console.Clear();
                            switch (Profiles)
                            {
                                case 1:
                                    LucasInformation("You've chosen Lucas!\n");
                                    break;
                                case 2:
                                    AthanasiaInformation("You've chosen Athanasia!\n");
                                    break;
                                case 3:
                                    IzekielInformation("You've chosen Nicolas!\n");
                                    break;
                                case 4:
                                    JennethInformation("You've chosen Jenneth!\n");
                                    break;
                                case 5:
                                    PlayerInformation("You've chosen to see your information!\n");
                                    break;
                            }
                            if (Profiles == 6)
                                break;
                        } while (Profiles >= 1 && Profiles <= 3) ;

                        break;
                    case 3:
                        while (true)
                        {
                            StartGame();
                            break;
                        }
                        break;
                }
                if (choice == 4)
                    break;
            } while (choice >= 1 && choice <= 3);

        }

        public static int MainMenu()
        {
            while (true)
            {
                try
                {
                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("\n-------- Game Menu --------\n");
                    ForegroundColor = ConsoleColor.White;

                    WriteLine("1.- BackGround of the story");
                    WriteLine("2.- Characters profiles");
                    WriteLine("3.- Start the game!");
                    WriteLine("4.- Exit the Game");

                    Write("\nPut the number of the character you choose: ");

                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
                        return choice;
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not in the options. TRY AGAIN");
                        ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not in the options. TRY AGAIN");
                    ForegroundColor = ConsoleColor.White;
                }

            }
        }

        private static void BackGround()
        {

            WriteLine("Since 2017 the world has been infested by monsters. Due to the appearance of these monsters, humans began to evolve.");
            WriteLine("They developed abilities eventually called gifts that allowed them to fight this threat. \n");
            WriteLine("Nowadays in the year 2022, society has been able to avoid the imminent danger of monsters.");
            WriteLine("This was accomplished thanks to the groups formed by people with gifts.");
            WriteLine("You are part of one of these groups. However, you have earned the hatred of one of your companions.");
            WriteLine("Now you are in danger of imminent death as you are the weakest of the group.");
            WriteLine("You must mend your relationship with this member or you will die.");
            Write(Contine); ReadKey();
            Clear();
        }
        public static int CharactersMenu()
        {
            while (true)
            {
                try
                {
                    Clear();

                    ForegroundColor = ConsoleColor.DarkMagenta;
                    WriteLine("\n-------- Characters Menu --------\n");
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("1.- Lucas");
                    WriteLine("2.- Athanasia");
                    WriteLine("3.- Izekiel");
                    WriteLine("4.- Jenneth");
                    WriteLine("5.- Player");
                    WriteLine("6.- Back to Main Menu");

                    Write("\nPut the number of the character you choose: ");

                    int choice = Convert.ToInt32(ReadLine());
                    if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6)
                        return choice;
                    else
                    {
                        Clear();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("That is not in the options. TRY AGAIN");
                        ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
                catch
                {
                    Clear();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("That is not in the options. TRY AGAIN");
                    ForegroundColor = ConsoleColor.White;
                }

            }
        }

        private static void StartGame()
        {
            WriteLine("\nIn the game you'll be trying to stop that characters from killing you.");
            WriteLine("First you'll need to select a character from the list:\n");

            WriteLine("1. Lucas");
            WriteLine("2. Athanasia");
            WriteLine("3. Nicolas");
            WriteLine("4. Jenneth\n");

            WriteLine("To deternime the level of dificulty of the game we'll check the level of hate the character has towards you.");
            GetNameFromUser("Let's get started! Insert your name and your character choice name:\n");
        }

        public static void GetNameFromUser(string prompt)
        {
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(prompt);
            ForegroundColor = ConsoleColor.White;
            while (true)
            {
                List<string> characters = new List<string> { "Lucas", "Athanasia", "Nicolas", "Jenneth" };

                string? input1 = ReadLine();
                string? input2 = ReadLine();

                if (input2 == characters[0] || input2 == characters[1] || input2 == characters[2] || input2 == characters[3])
                {
                    if (input2 == characters[0])
                    {
                        int hatred = 0;
                        HatredCalculation(ref hatred);
                         if (hatred <= 50)
                        {
                            ForegroundColor = ConsoleColor.Blue;
                            Write(Contine); ReadKey();
                            Lucas.EasyMode.Main1();
                        }
                        else
                        {
                            Write(Contine);
                            ReadKey();
                            Lucas.HardMode.Main2();
                        }
                    }
                    else if (input2 == characters[1])
                    {
                        int hatred = 0;
                        HatredCalculation(ref hatred);
                        if (hatred <= 50)
                        {
                            Write(Contine);
                            ReadKey();
                            Athanasia.EasyMode.Main1();
                        }
                        else
                        {
                            Write(Contine);
                            ReadKey();
                            Athanasia.HardMode.Main2();
                        }
                    }
                    else if (input2 == characters[2])
                    {
                        int hatred = 0;
                        HatredCalculation(ref hatred);
                        if (hatred <= 50)
                        {
                            Write(Contine);
                            ReadKey();
                            Izekiel.EasyMode.Main1();
                        }
                        else
                        {
                            Write(Contine);
                            ReadKey();
                            Izekiel.HardMode.Main2();
                        }
                    }
                    else if (input2 == characters[3])
                    {
                        int hatred = 0;
                        HatredCalculation(ref hatred);
                        if (hatred <= 50)
                        {
                            Write(Contine);
                            ReadKey();
                            Jenneth.EasyMode.Main1();
                        }
                        else
                        {
                            Write(Contine);
                            ReadKey();
                            Jenneth.HardMode.Main2();
                        }
                    }
                    break;
                }

                else
                    WriteLine("\nThat is not a character!\n");
            }
        }

        private static int HatredCalculation(ref int randomNumber)
        {
            Random generator = new Random();
            randomNumber = generator.Next(1, 100);
            WriteLine("\nThe hatred amount is of " + randomNumber + "%");

            if (randomNumber <= 50)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("The hatred amount is Low! You'll be playing the easy mode.");
            }

            if (randomNumber >= 51 && randomNumber <= 100)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("The hatred amount is High! You'll be playing the hard mode.");
            }
            return randomNumber;
        }

        public static void LucasInformation(string prompt)
        {
            WriteLine(prompt);
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("Lucas");
            WriteLine("Job: Magician\n");
            WriteLine("Personality: Honest and generous. He's always trying to help others.");
            WriteLine("hates selfish and ambicious people.\n");
            WriteLine("Lucas and you have know each other since you were kids.");
            WriteLine("You both were the first members of the team, even so, in the past year you have been");
            WriteLine("using his name to intimidate other groups. This helped you get solo job oporutnities.");
            WriteLine("He recently found out about your actions and is extremily angry with you.\n");
            Write(Contine); ReadKey();
        }

        public static void AthanasiaInformation(string prompt)
        {
            WriteLine(prompt);
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("Athanasia");
            WriteLine("Job: Healer\n");
            WriteLine("Personality: Ambitious and intelligent. Constantly seeks to raise her potion..");
            WriteLine("Recognized for the level of her gift. Does n't like to lose her money.\n");
            WriteLine("Athanasia and you used to have a romantic relationship.");
            WriteLine("You both had a good relationship, even so, things didn't end well and you broke up.");
            WriteLine("Both endened in good terms and were still friend. However, she recently found out");
            WriteLine("that you were secretly stealing her precious money.");
            Write(Contine); ReadKey();
        }

        public static void IzekielInformation(string prompt)
        {
            WriteLine(prompt);
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("Izekiel");
            WriteLine("Job: Swordsman\n");
            WriteLine("Personality: Loyal and generous with the people around him.");
            WriteLine("He is one of the most powerful swordsmans in the country.\n");
            WriteLine("You've always been good friends. He'd usually help you with your training with the sword.");
            WriteLine("He's currently mad at you since he found out that you know who killed his previous master.");
            WriteLine("You didn't tell him even though you knew he was trying to find the culprit desperately.");
            Write(Contine); ReadKey();
        }

        public static void JennethInformation(string prompt)
        {
            WriteLine(prompt);
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("Athanasia");
            WriteLine("Job: Healer\n");
            WriteLine("Personality: Ambitious and intelligent. Constantly seeks to raise her potion..");
            WriteLine("Recognized for the level of her gift. Does n't like to lose her money.\n");
            WriteLine("Athanasia and you used to have a romantic relationship.");
            WriteLine("You both had a good relationship, even so, things didn't end well and you broke up.");
            WriteLine("Both endened in good terms and were still friend. However, she recently found out");
            WriteLine("that you were secretly stealing some of her precious savings.");
            Write(Contine); ReadKey();
        }

        public static void PlayerInformation(string prompt)
        {
            WriteLine(prompt);
            WriteLine("-----------------------------------------------------------------------");
            WriteLine("Athanasia");
            WriteLine("Job: Healer\n");
            WriteLine("Personality: Ambitious and intelligent. Constantly seeks to raise her potion..");
            WriteLine("Recognized for the level of her gift. Does n't like to lose her money.\n");
            WriteLine("Athanasia and you used to have a romantic relationship.");
            WriteLine("You both had a good relationship, even so, things didn't end well and you broke up.");
            WriteLine("Both endened in good terms and were still friend. However, she recently found out");
            WriteLine("that you were secretly stealing some of her precious savings.");
            Write(Contine); ReadKey();
        }
    }
}


