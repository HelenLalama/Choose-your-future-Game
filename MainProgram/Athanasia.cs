using static System.Console;

namespace Athanasia // Note: actual namespace depends on the project name.
{
    internal class EasyMode
    {
        //Declaring constant string
        public const string Contine = "\nPress any key to continue: ";

        public static void Main1()
        {
            while (true)
            {
                // Set up of vairables
                int Friendship = 30;
                int Round = 1;

                //Start of the Hard Mode Game
                Clear();
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("----------------------------------------------------");
                WriteLine("---------- Welcome to the Easy Game Mode -----------");
                WriteLine("----------------------------------------------------\n");
                ForegroundColor = ConsoleColor.White;

                WriteLine("In this game, you'll be confronting different situations with the character you chose.");
                WriteLine("Depending on the choices you make your Affection parameter will raise or decrease!");
                WriteLine("Since you have entered the hard mode, you won't easily lose affection. ");
                WriteLine("Additionally, you will easily gain points.");
                ForegroundColor = ConsoleColor.Blue;
                Write(Contine); ReadKey();
                ForegroundColor = ConsoleColor.White;

                //Round #1
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round1(ref Friendship, ref Round);
                ForegroundColor = ConsoleColor.Blue;
                Write(Contine); ReadKey();
                ForegroundColor = ConsoleColor.White;

                //Round #2
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round2(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }

                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(Contine); ReadKey();
                    ForegroundColor = ConsoleColor.White;
                }

                //Round #3
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round3(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(Contine); ReadKey();
                    ForegroundColor = ConsoleColor.White;
                }

                //Round #4 
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round4(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(Contine); ReadKey();
                    ForegroundColor = ConsoleColor.White;
                }

                //Round #5
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round5(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }

            }
        }

        // ============================================ METHODS ============================================

        //This method will determine if the player loses or wins
        public static bool Winner(ref int Friendship, ref int Round)
        {
            if (Friendship >= 100)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n/---------------\\");
                WriteLine("| YOU HAVE WON! |");
                WriteLine("\\---------------/");
                WriteLine("Your level of friendship with Athanasia reached 100Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                Clear();
                return true;
            }
            else if (Round == 6 && Friendship < 100)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n/---------------\\");
                WriteLine("|  YOU'VE LOST! |");
                WriteLine("\\---------------/");
                WriteLine("The rounds have ended and your level Friendship didn't reach 100Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                Clear();
                return true;
            }
            else if (Friendship <= 0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n/---------------\\");
                WriteLine("|  YOU'VE LOST! |");
                WriteLine("\\---------------/");
                WriteLine("You're level of friendship has reached 0Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        // This method will diplay the Status of the player, in which round he/she is and the level of friendship
        public static void DisplayStatus(ref int Round, ref int LevelOfAffection)
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("-------------------------------------------------------------");
            WriteLine($"STATUS: Round: {Round}/5 | Level Of Friendship: {LevelOfAffection}/100");
            ForegroundColor = ConsoleColor.White;
        }

        //This method will diplay the Round 1 of the game
        public static void Round1(ref int LevelofAffection, ref int round)
        {
            WriteLine("\nAthanasia has called you to her house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Athanasia!");

                WriteLine("You've arrived to her house.\n");
                WriteLine("Athanasia tells you that she knows you have been taking her money");
                WriteLine("She demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("You explain her that you needed the money to paid some debts.");
                    WriteLine("She doesn't forgive you but he lets you go home without problems.");
                    WriteLine("You'll gain 15Pts.");
                    LevelofAffection += 15;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("She hears as you try to explain yourself. She knows well that you're lying");
                    WriteLine("She despise you more than before! You'll lose 10Pts.");
                    LevelofAffection -= 10;
                }
            }
            if (response == "no")
            {
                WriteLine("\nYou have decided not to meet Athanasia!");
                WriteLine("Your level of friendship will decrease 5 Pts.");
                LevelofAffection -= 5;
            }
            round++;
        }

        //This method will diplay the Round 2 of the game
        public static void Round2(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nNext day begins!");
            WriteLine("Athanasia comes to find you to talk about the money you've taken.");
            WriteLine("She demands you to return her the money you've taken from her");
            string response = GetAnswerFromUser("\nWill you return the money? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You've decided to return the money! You'll get 5Pts\n");
                LevelOFAffection += 5;

                WriteLine("You explain that right now you don't have enough to pay her back.");
                WriteLine("She tells you to give her what you for the moment and that you have till the end of the month to pay back the amount.");

                string deal = GetAnswerFromUser("\nWill accept the offer? (Yes/No): ", "yes", "no");
                if (deal == "yes")
                {
                    WriteLine("\nYou easily accept the offer. You gave her half of the debt amount.");
                    WriteLine("Athanasia is pleased with the deal. You've gained 15Pts");
                    LevelOFAffection += 15;
                }
                if (deal == "no")
                {
                    WriteLine("\nYou told her that you won't have enough time to get the money. Therefore, you asked her to give you one more weeks.");
                    WriteLine("She accepts the deal, not very convinced.");
                    WriteLine("You've gained 5Pts.");
                    LevelOFAffection -= 5;
                }
            }
            if (response == "no")
            {
                WriteLine("Athanasia is extremely angry at you. She threatned you with a demand.");
                WriteLine("You had to accpet the deal.");
                WriteLine("You lost 5Pts.");
                LevelOFAffection -= 5;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nYou have been working nonstop to get the money.");
            WriteLine("You came across with an interesting job oppotunity. They need a healer in the capital.");
            string response = GetAnswerFromUser("Will you accept this request (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou went to the capital in order to fulfill the request.");
                WriteLine("In there you found Athanasia.");
                string WillyouLeave = GetAnswerFromUser("Will you stay or go? (Stay/Go): ", "stay", "go");
                if (WillyouLeave == "stay")
                {
                    WriteLine("You stayed and greeted Athanasia.");
                    WriteLine("She's surprised to see you. She knows well the you hate making long trips");
                    WriteLine("You both started to talk and had a great time together!");
                    WriteLine("Good decision! You'll gain 15 Pts.");
                    LevelOFAffection += 15;
                }
                if (WillyouLeave == "go")
                {
                    WriteLine("You tried to left but you already accepted the job, you couldn't leave.");
                    WriteLine("For the rest of the request you tried your best to escape from Anasthasia.");
                    WriteLine("You'll gain 5Pts.");
                    LevelOFAffection += 5;
                }
            }
            if (response == "no")
            {
                WriteLine("Two days after that you were called from the capital. Athanasia was in a delicate situation.");
                WriteLine("You'll lose 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nAthanasia was accused of negligence. She is accused of not wanting to cure an important leader.");
            WriteLine("She is not able to do that because the patient can only be healed with a healer of light attribute.");
            WriteLine("Athanasia calls you since you're one of the few light attribute healers.");
            string response = GetAnswerFromUser("Will you help Athanasia? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You explained the people there that if the patient was treated by someone else he could have died.");
                WriteLine("After healing the patience you went to Athanasia. She's extremely thankful towards you.");
                WriteLine("You'll gain 20Pts.");
                LevelOFAffection += 20;
            }
            if (response == "no")
            {
                WriteLine("Athanasia was obligated to heal the patient and he ended up dying.");
                WriteLine("She's extremily angry at you because she lost one of the most important things to her: Her reputataion");
                WriteLine("You've lost 15Pts.");
                LevelOFAffection -= 15;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nYou are supposed to pay the debt that you have with Athanasia today.");
            string response = GetAnswerFromUser("Will you escape from the reunion? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("Athanasia gave up on you.");
                WriteLine("She can't stand your pressence in the group anymore.");
                WriteLine("You'll lose 20Pts.");
                LevelOfAffection -= 20;
            }
            if (response == "no")
            {
                WriteLine("You paied the debt");
                WriteLine("You apologize and then leave the place.");
                WriteLine("You'll earn 20 Pts.");
                LevelOfAffection += 20;
            }
            round++;
        }

        //This method will get the answers of the questions made to the players. It'll verify that they're valid inputs
        public static string GetAnswerFromUser(string prompt, string option1, string option2)
        {
            ForegroundColor = ConsoleColor.Magenta;
            Write(prompt);
            ForegroundColor = ConsoleColor.White;
            string fixedanswer;
            while (true)
            {
                string? answer = ReadLine();
                fixedanswer = answer.ToLower();
                if (fixedanswer == option1 || fixedanswer == option2)
                    break;
                else
                    ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"\nChoose an answer between '{option1}' or '{option2}'!\n");
                ForegroundColor = ConsoleColor.White;
            }
            return fixedanswer;
        }
    }
    public class HardMode
    {
        //Declaring constant string
        public const string Contine = "\nPress any key to continue: ";

        public static void Main2()
        {
            while (true)
            {
                // Set up of vairables
                int Friendship = 20;
                int Round = 1;

                //Start of the Hard Mode Game
                Clear();
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine("----------------------------------------------------");
                WriteLine("---------- Welcome to the Hard Game Mode -----------");
                WriteLine("----------------------------------------------------\n");
                ForegroundColor = ConsoleColor.White;

                WriteLine("In this game, you'll be confronting different situations with the character you chose.");
                WriteLine("Depending on the choices you make your Affection parameter will raise or decrease!");
                WriteLine("Since you have entered the hard mode, you won't easily gain affection. ");
                WriteLine("Additionally, you have a high chance of dying.");
                ForegroundColor = ConsoleColor.Blue;
                Write(Contine); ReadKey();
                ForegroundColor = ConsoleColor.White;

                //Round #1
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round1(ref Friendship, ref Round);
                ForegroundColor = ConsoleColor.Blue;
                Write(Contine); ReadKey();
                ForegroundColor = ConsoleColor.White;

                //Round #2
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round2(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }

                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(Contine); ReadKey();
                    ForegroundColor = ConsoleColor.White;
                }

                //Round #3
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round3(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(Contine); ReadKey();
                    ForegroundColor = ConsoleColor.White;
                }

                //Round #4 
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round4(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }
                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    Write(Contine); ReadKey();
                    ForegroundColor = ConsoleColor.White;
                }

                //Round #5
                Clear();
                DisplayStatus(ref Round, ref Friendship);
                Round5(ref Friendship, ref Round);
                //Deternime of the player won or lost
                if (Winner(ref Friendship, ref Round) == true)
                {
                    break;
                }

            }
        }

        // ============================================ METHODS ============================================

        //This method will determinate if the player wins or loses the game
        public static bool Winner(ref int Friendship, ref int Round)
        {
            if (Friendship >= 100)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n/---------------\\");
                WriteLine("| YOU HAVE WON! |");
                WriteLine("\\---------------/");
                WriteLine("Your level of friendship with Athanasia reached 100Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                Clear();
                return true;
            }
            else if (Round == 6 && Friendship < 100)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n/---------------\\");
                WriteLine("|  YOU'VE LOST! |");
                WriteLine("\\---------------/");
                WriteLine("The rounds have ended and your level Friendship didn't reach 100Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                Clear();
                return true;
            }
            else if (Friendship <= 0)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n/---------------\\");
                WriteLine("|  YOU'VE LOST! |");
                WriteLine("\\---------------/");
                WriteLine("You're level of friendship has reached 0Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        // This method will diplay the Status of the player, in which round he/she is and the level of friendship
        public static void DisplayStatus(ref int Round, ref int LevelOfAffection)
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("-------------------------------------------------------------");
            WriteLine($"STATUS: Round: {Round}/5 | Level Of Friendship: {LevelOfAffection}/100");
            ForegroundColor = ConsoleColor.White;
        }

        //This method will diplay the Round 1 of the game
        public static void Round1(ref int LevelofAffection, ref int round)
        {
            WriteLine("\nAthanasia has called you to her house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Athanasia!");

                WriteLine("You've arrived to her house.\n");
                WriteLine("Athanasia tells you that she knows you have been taking her money");
                WriteLine("She demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("You explain her that you needed the money to paid some debts.");
                    WriteLine("She doesn't forgive you but he lets you go home without problems.");
                    WriteLine("You'll gain 10Pts.");
                    LevelofAffection += 10;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("She hears as you try to explain yourself. She knows well that you're lying");
                    WriteLine("She despise you more than before! You'll lose 10Pts.");
                    LevelofAffection -= 10;
                }
            }
            if (response == "no")
            {
                WriteLine("\nYou have decided not to meet Athanasia!");
                WriteLine("Your level of friendship will decrease 10Pts.");
                LevelofAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 2 of the game
        public static void Round2(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nNext day begins!");
            WriteLine("Athanasia comes to find you to talk about the money you've taken.");
            WriteLine("She demands you to return her the money you've taken from her");
            string response = GetAnswerFromUser("\nWill you return the money? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You've decided to return the money! You'll get 10Pts\n");
                LevelOFAffection += 10;

                WriteLine("You explain that right now you don't have enough to pay her back.");
                WriteLine("She tells you to give her what you for the moment and that you have till the end of the month to pay back the amount.");

                string deal = GetAnswerFromUser("\nWill accept the offer? (Yes/No): ", "yes", "no");
                if (deal == "yes")
                {
                    WriteLine("\nYou easily accept the offer. You gave her half of the debt amount.");
                    WriteLine("Athanasia is pleased with the deal. You've gained 15Pts");
                    LevelOFAffection += 15;
                }
                if (deal == "no")
                {
                    WriteLine("\nYou told her that you won't have enough time to get the money. Therefore, you asked her to give you one more weeks.");
                    WriteLine("She accepts the deal, not very convinced.");
                    WriteLine("You've gained 10Pts.");
                    LevelOFAffection += 10;
                }
            }
            if (response == "no")
            {
                WriteLine("Athanasia is extremely angry at you. She threatned you with a demand.");
                WriteLine("You had to accpet the deal.");
                WriteLine("You lost 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nYou have been working nonstop to get the money.");
            WriteLine("You came across with an interesting job oppotunity. They need a healer in the capital.");
            string response = GetAnswerFromUser("Will you accept this request (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou went to the capital in order to fulfill the request.");
                WriteLine("In there you found Athanasia.");
                string WillyouLeave = GetAnswerFromUser("Will you stay or go? (Stay/Go): ", "stay", "go");
                if (WillyouLeave == "stay")
                {
                    WriteLine("You stayed and greeted Athanasia.");
                    WriteLine("She's surprised to see you. She knows well the you hate making long trips");
                    WriteLine("You both started to talk and had a great time together!");
                    WriteLine("Good decision! You'll gain 15 Pts.");
                    LevelOFAffection += 15;
                }
                if (WillyouLeave == "go")
                {
                    WriteLine("You tried to left but you already accepted the job, you couldn't leave.");
                    WriteLine("For the rest of the request you tried your best to escape from Anasthasia.");
                    WriteLine("You'll gain 5Pts.");
                    LevelOFAffection += 5;
                }
            }
            if (response == "no")
            {
                WriteLine("Two days after that you were called from the capital. Athanasia was in a delicate situation.");
                WriteLine("You'll lose 15Pts.");
                LevelOFAffection -= 15;
            }
            round++;
        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nAthanasia was accused of negligence. She is accused of not wanting to cure an important leader.");
            WriteLine("She is not able to do that because the patient can only be healed with a healer of light attribute.");
            WriteLine("Athanasia calls you since you're one of the few light attribute healers.");
            string response = GetAnswerFromUser("Will you help Athanasia? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You explained the people there that if the patient was treated by someone else he could have died.");
                WriteLine("After healing the patience you went to Athanasia. She's extremely thankful towards you.");
                WriteLine("You'll gain 20Pts.");
                LevelOFAffection += 20;
            }
            if (response == "no")
            {
                WriteLine("Athanasia was obligated to heal the patient and he ended up dying.");
                WriteLine("She's extremily angry at you because she lost one of the most important things to her: Her reputataion");
                WriteLine("You've lost 25Pts.");
                LevelOFAffection -= 25;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nYou are supposed to pay the debt that you have with Athanasia today.");
            string response = GetAnswerFromUser("Will you escape from the reunion? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("Athanasia gave up on you.");
                WriteLine("She can't stand your pressence in the group anymore.");
                WriteLine("You'll lose 25Pts.");
                LevelOfAffection -= 25;
            }
            if (response == "no")
            {
                WriteLine("You paied the debt");
                WriteLine("You apologize and then leave the place.");
                WriteLine("You'll earn 10 Pts.");
                LevelOfAffection += 10;
            }
            round++;
        }

        //This method will get the answers of the questions made to the players. It'll verify that they're valid inputs
        public static string GetAnswerFromUser(string prompt, string option1, string option2)
        {
            ForegroundColor = ConsoleColor.Magenta;
            Write(prompt);
            ForegroundColor = ConsoleColor.White;
            string fixedanswer;
            while (true)
            {
                string? answer = ReadLine();
                fixedanswer = answer.ToLower();
                if (fixedanswer == option1 || fixedanswer == option2)
                    break;
                else
                    ForegroundColor = ConsoleColor.DarkRed;
                WriteLine($"\nChoose an answer between '{option1}' or '{option2}'!\n");
                ForegroundColor = ConsoleColor.White;
            }
            return fixedanswer;
        }
    }
}