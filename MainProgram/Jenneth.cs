using System;
using static System.Console;


namespace Jenneth // Note: actual namespace depends on the project name.
{
    public class EasyMode
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
                if (NewMethod(ref Friendship, ref Round) == true)
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
                if (NewMethod(ref Friendship, ref Round) == true)
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
                if (NewMethod(ref Friendship, ref Round) == true)
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
                if (NewMethod(ref Friendship, ref Round) == true)
                {
                    break;
                }

            }
        }

        // ============================================ METHODS ============================================
        //This method will determine if the player wins or loses.
        public static bool NewMethod(ref int Friendship, ref int Round)
        {
            if (Friendship >= 100)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n/---------------\\");
                WriteLine("| YOU HAVE WON! |");
                WriteLine("\\---------------/");
                WriteLine("Your level of Love with Izekiel reached 100Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                // Clear();
                return true;
            }
            else if (Round == 6 && Friendship < 100)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n/---------------\\");
                WriteLine("|  YOU'VE LOST! |");
                WriteLine("\\---------------/");
                WriteLine("The rounds have ended and your level Love didn't reach 100Pts!");
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
                WriteLine("You're level of Love has reached 0Pts!");
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
            WriteLine($"STATUS: Round: {Round}/5 | Level Of Love: {LevelOfAffection}/100");
            ForegroundColor = ConsoleColor.White;
        }

        //This method will diplay the Round 1 of the game
        public static void Round1(ref int LevelofAffection, ref int round)
        {
            WriteLine("\nJenneth has called you to her house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Jenneth!");

                WriteLine("You've arrived to her house.\n");
                WriteLine("Jenneth tries to tells what she knows so far, and asked you if it was true that you cheated on her.");
                WriteLine("He demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("\nYou explained her that it was just a mistake and that you will never do it again.");
                    WriteLine("She's hurt but she forgives you.");
                    WriteLine("You'll gain 20Pts.");
                    LevelofAffection += 20;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("\nShe hears your lame excuses. She knows you're lying, even she decides to forgive you.");
                    WriteLine("You'll lose 15Pts.");
                    LevelofAffection -= 15;
                }
            }
            if (response == "no")
            {
                WriteLine("\nJenneth is deaply hurt by your actions. However, she decides to let it pass");
                WriteLine("You'll lose 5Pts.");
                LevelofAffection -= 5;
            }
            round++;
        }

        //This method will diplay the Round 2 of the game
        public static void Round2(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nThe time passed and you kept cheating on Jenneth.");
            WriteLine("Soon is going to be her birthday. As the leader mercenary group she has to make a huge party.");
            WriteLine("You knew about this so at the middle of the celebration you went to see your other date.");
            WriteLine("Jenneth was keeping a eye on you. She follows you to a side of the forest.");
            WriteLine("Jenneth confronts you.");
            string response = GetAnswerFromUser("\nWill you tell her the truth? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou are brave!");
                WriteLine("You tell her that you've been cheating on her.");
                WriteLine("She tells that the relationship can't go further.");

                string AcceptOffer = GetAnswerFromUser("\nDo you agree with Jenneth? (Yes/No): ", "yes", "no");
                if (AcceptOffer == "yes")
                {
                    WriteLine("\nYou agree with her you both ended the relationship.");
                    WriteLine("You'll gain 15Pts.");
                    LevelOFAffection += 15;
                }
                if (AcceptOffer == "no")
                {
                    WriteLine("\nYou don't want to let her go even when you know is the right thing to do.");
                    WriteLine("You've lost 10Pts.");
                    LevelOFAffection -= 10;
                }
            }
            if (response == "no")
            {
                WriteLine("\nYou kept on lying about the situation.");
                WriteLine("Jenneth couldn't take more your lies and broke up with you.");
                WriteLine("You lost 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nShe was about to leave when out of nowhere a dragon appeared!");
            WriteLine("The both ended up fighting with the dragon");
            WriteLine("At the end you couldn't stop the dragon from kidnapping Jenneth.");
            string response = GetAnswerFromUser("Will ask for help or go alone (For help/Alone): ", "for help", "alone");
            if (response == "for help")
            {
                WriteLine("\nYou went back to the party and asked for help.");
                WriteLine("All the members were with you trying to find Jenneth.");
                WriteLine("You maneged to find the hideout.");
                WriteLine("You took the smartest decision! You'll gain 10Pts.");
                LevelOFAffection += 10;
            }
            if (response == "alone")
            {
                WriteLine("\nYou went after the dragon alone and find where he put Jenneth.");
                WriteLine("You tried to rescue her but you weren't able.");
                WriteLine("You had to go look for help leaving Jenneth with the dragon alone.");
                WriteLine("That wasn's a smart election. You'll lose 20Pts.");
                LevelOFAffection -= 20;
            }
            round++;

        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nThe members and you planned a way to help Jenneth");
            WriteLine("Everything is setled but they need a bait.");
            string response = GetAnswerFromUser("Will you be the bait? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou were in charge of distracting the drangon while everyone rescue Jenneth.");
                WriteLine("You maneged to accomplish your mission.");
                WriteLine("You'll gain 20Pts.");
                LevelOFAffection += 20;
            }
            if (response == "no")
            {
                WriteLine("\nYou witnessed how everyone helped Jenneth and you just saw from afar.");
                WriteLine("You feel guilty about it.");
                WriteLine("You've lost 25Pts.");
                LevelOFAffection -= 25;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nJenneth was saved from the dragon. She wants to talk to you.");
            string response = GetAnswerFromUser("Will go meet him? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou both talked about the situation.");
                WriteLine("You both ended the relationship and had a good goodbye.");
                WriteLine("You'll win 30Pts.");
                LevelOfAffection += 30;
            }
            if (response == "no")
            {
                WriteLine("\nJenneth is extremely angry for your indiference.");
                WriteLine("After that day she never talked to you again.");
                WriteLine("You'll lose 20Pts.");
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

    internal class HardMode
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
                if (NewMethod(ref Friendship, ref Round) == true)
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
                if (NewMethod(ref Friendship, ref Round) == true)
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
                if (NewMethod(ref Friendship, ref Round) == true)
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
                if (NewMethod(ref Friendship, ref Round) == true)
                {
                    break;
                }

            }
        }

        // ============================================ METHODS ============================================
        //This method will determine if the player wins or loses.
        public static bool NewMethod(ref int Friendship, ref int Round)
        {
            if (Friendship >= 100)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n/---------------\\");
                WriteLine("| YOU HAVE WON! |");
                WriteLine("\\---------------/");
                WriteLine("Your level of Love with Izekiel reached 100Pts!");
                Write("Press any key to return to the main menu: "); ReadKey();
                // Clear();
                return true;
            }
            else if (Round == 6 && Friendship < 100)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("\n/---------------\\");
                WriteLine("|  YOU'VE LOST! |");
                WriteLine("\\---------------/");
                WriteLine("The rounds have ended and your level Love didn't reach 100Pts!");
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
                WriteLine("You're level of Love has reached 0Pts!");
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
            WriteLine($"STATUS: Round: {Round}/5 | Level Of Love: {LevelOfAffection}/100");
            ForegroundColor = ConsoleColor.White;
        }

        //This method will diplay the Round 1 of the game
        public static void Round1(ref int LevelofAffection, ref int round)
        {
            WriteLine("\nJenneth has called you to her house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Jenneth!");

                WriteLine("You've arrived to her house.\n");
                WriteLine("Jenneth tries to tells what she knows so far, and asked you if it was true that you cheated on her.");
                WriteLine("He demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("\nYou explained her that it was just a mistake and that you will never do it again.");
                    WriteLine("She's hurt but she forgives you.");
                    WriteLine("You'll gain 15Pts.");
                    LevelofAffection += 15;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("\nShe hears your lame excuses. She knows you're lying, even she decides to forgive you.");
                    WriteLine("You'll lose 10Pts.");
                    LevelofAffection -= 10;
                }
            }
            if (response == "no")
            {
                WriteLine("\nJenneth is deaply hurt by your actions. However, she decides to let it pass");
                WriteLine("You'll lose 5Pts.");
                LevelofAffection -= 5;
            }
            round++;
        }

        //This method will diplay the Round 2 of the game
        public static void Round2(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nThe time passed and you kept cheating on Jenneth.");
            WriteLine("Soon is going to be her birthday. As the leader mercenary group she has to make a huge party.");
            WriteLine("You knew about this so at the middle of the celebration you went to see your other date.");
            WriteLine("Jenneth was keeping a eye on you. She follows you to a side of the forest.");
            WriteLine("Jenneth confronts you.");
            string response = GetAnswerFromUser("\nWill you tell her the truth? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou are brave!");
                WriteLine("You tell her that you've been cheating on her.");
                WriteLine("She tells that the relationship can't go further.");

                string AcceptOffer = GetAnswerFromUser("\nDo you agree with Jenneth? (Yes/No): ", "yes", "no");
                if (AcceptOffer == "yes")
                {
                    WriteLine("\nYou agree with her you both ended the relationship.");
                    WriteLine("You'll gain 10Pts.");
                    LevelOFAffection += 10;
                }
                if (AcceptOffer == "no")
                {
                    WriteLine("\nYou don't want to let her go even when you know is the right thing to do.");
                    WriteLine("You've lost 10Pts.");
                    LevelOFAffection -= 10;
                }
            }
            if (response == "no")
            {
                WriteLine("\nYou kept on lying about the situation.");
                WriteLine("Jenneth couldn't take more your lies and broke up with you.");
                WriteLine("You lost 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nShe was about to leave when out of nowhere a dragon appeared!");
            WriteLine("The both ended up fighting with the dragon");
            WriteLine("At the end you couldn't stop the dragon from kidnapping Jenneth.");
            string response = GetAnswerFromUser("Will ask for help or go alone (For help/Alone): ", "for help", "alone");
            if (response == "for help")
            {
                WriteLine("\nYou went back to the party and asked for help.");
                WriteLine("All the members were with you trying to find Jenneth.");
                WriteLine("You maneged to find the hideout.");
                WriteLine("You took the smartest decision! You'll gain 10Pts.");
                LevelOFAffection += 10;
            }
            if (response == "alone")
            {
                WriteLine("\nYou went after the dragon alone and find where he put Jenneth.");
                WriteLine("You tried to rescue her but you weren't able.");
                WriteLine("You had to go look for help leaving Jenneth with the dragon alone.");
                WriteLine("That wasn's a smart election. You'll lose 20Pts.");
                LevelOFAffection -= 20;
            }
            round++;

        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nThe members and you planned a way to help Jenneth");
            WriteLine("Everything is setled but they need a bait.");
            string response = GetAnswerFromUser("Will you be the bait? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou were in charge of distracting the drangon while everyone rescue Jenneth.");
                WriteLine("You maneged to accomplish your mission.");
                WriteLine("You'll gain 15Pts.");
                LevelOFAffection += 15;
            }
            if (response == "no")
            {
                WriteLine("\nYou witnessed how everyone helped Jenneth and you just saw from afar.");
                WriteLine("You feel guilty about it.");
                WriteLine("You've lost 15Pts.");
                LevelOFAffection -= 15;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nJenneth was saved from the dragon. She wants to talk to you.");
            string response = GetAnswerFromUser("Will go meet him? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou both talked about the situation.");
                WriteLine("You both ended the relationship and had a good goodbye.");
                WriteLine("You'll win 30Pts.");
                LevelOfAffection += 30;
            }
            if (response == "no")
            {
                WriteLine("\nJenneth is extremely angry for your indiference.");
                WriteLine("After that day she never talked to you again.");
                WriteLine("You'll lose 30Pts.");
                LevelOfAffection += 30;
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