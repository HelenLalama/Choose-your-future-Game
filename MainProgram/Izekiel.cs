using static System.Console;

namespace Izekiel// Note: actual namespace depends on the project name.
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

        public static bool NewMethod(ref int Friendship, ref int Round)
        {
            if (Friendship >= 100)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\n/---------------\\");
                WriteLine("| YOU HAVE WON! |");
                WriteLine("\\---------------/");
                WriteLine("Your level of friendship with Athanasia reached 100Pts!");
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

        // ============================================ METHODS ============================================

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
            WriteLine("\nIzekiel has called you to his house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Izekiel!");

                WriteLine("You've arrived to his house.\n");
                WriteLine("Izekiel tells you that he knows you've keeping the name of his master's killer from him.");
                WriteLine("He demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("You explain him that you didn't tell him since you don't want him to suffer.");
                    WriteLine("You refuse to tell you name of the culprit.");
                    WriteLine("You'll gain 15Pts.");
                    LevelofAffection += 15;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("He hears as you try to explain yourself. He knows well that you're lying");
                    WriteLine("He despise you more than before! You'll lose 5Pts.");
                    LevelofAffection -= 5;
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
            WriteLine("Izekiel has asked you to come the training.");
            WriteLine("You know that he just wants to make you say the culprit");
            string response = GetAnswerFromUser("\nWill you help him? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You are brave! You'll get 5Pts\n");
                LevelOFAffection += 5;

                WriteLine("You had to go through the most exhausting training of your life");
                WriteLine("He tells you that if you want him to stop you just have to tell him.");

                string AcceptOffer = GetAnswerFromUser("\nWill accept the offer? (Yes/No): ", "yes", "no");
                if (AcceptOffer == "yes")
                {
                    WriteLine("\nYou couldn't handel it and you told him the truth.");
                    WriteLine("You tell him that you witnesses a dragon killing his master");
                    WriteLine("He doesn't believe you and let you go dissapointed. You'll lose 10Pts.");
                    LevelOFAffection -= 10;
                }
                if (AcceptOffer == "no")
                {
                    WriteLine("\nYou refuse to tell him, you had to endure the training for the rest of the day.");
                    WriteLine("You've gained 15Pts.");
                    LevelOFAffection += 15;
                }
            }
            if (response == "no")
            {
                WriteLine("He comes to find you and make you go through the training process");
                WriteLine("He made you do an extreme training and wouldn't let you rest");
                WriteLine("You lost 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nOn the next day. He comes looking for you");
            WriteLine("The both of you ended up fighting again");
            WriteLine("You told him that the culprit was a dragon but he wouldn't believe");
            WriteLine("He ask for a proof and you have it.");
            string response = GetAnswerFromUser("Will you give him the proof (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou gave him the recording you had of the incident.");
                WriteLine("He starts going mad. He tries to go find the dragon.");
                string LetHimLeave = GetAnswerFromUser("Will you stop him or let him go? (Stop him/Let him go): ", "stop him", "let him go");
                if (LetHimLeave == "stop him")
                {
                    WriteLine("You tried by all means to stop him but you couldn't.");
                    WriteLine("You went after him but couldn't catch up! You'll gain 20 Pts.");
                    LevelOFAffection += 20;
                }
                if (LetHimLeave == "let him go")
                {
                    WriteLine("You know you wouldn't be able to stop him so you just let him go.");
                    WriteLine("You'll gain 10Pts.");
                    LevelOFAffection += 10;
                }
            }
            if (response == "no")
            {
                WriteLine("He doesn't believe in you, even so, he tries to go find the so called dragon.");
                WriteLine("You tried to stop him but couldn't do anything about it.");
                WriteLine("You'll lose 15Pts.");
                LevelOFAffection -= 15;
            }
            round++;
        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nYou haven't seen Izekiel for two days.");
            WriteLine("You think that he may be traped in the forest.");
            string response = GetAnswerFromUser("Will you go to the forest? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You went to the forest and found Izekiel in a delicate state.");
                WriteLine("After healing him you brougth him back home.");
                WriteLine("You'll gain 20Pts.");
                LevelOFAffection += 20;
            }
            if (response == "no")
            {
                WriteLine("\nBy the end of the week Athanasia came back with an unconscious Izekiel.");
                WriteLine("You know that is your fault and you feel guilty about it.");
                WriteLine("You've lost 25Pts.");
                LevelOFAffection -= 25;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nToday Izekiel woke up after one week of beign unconscious.");
            string response = GetAnswerFromUser("Will go meet him? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("He tells you that he's sorry for not believe in you.");
                WriteLine("He understands why you didn't tell him the culprit.");
                WriteLine("You'll win 25Pts.");
                LevelOfAffection += 25;
            }
            if (response == "no")
            {
                WriteLine("That day in the afternoon he comes to find you.");
                WriteLine("He tells you sorry for not believe in you, however, he's still mad at you for lying.");
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
                WriteLine("Your level of friendship with Izekiel reached 100Pts!");
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
            WriteLine("\nIzekiel has called you to his house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Izekiel!");

                WriteLine("You've arrived to his house.\n");
                WriteLine("Izekiel tells you that he knows you've keeping the name of his master's killer from him.");
                WriteLine("He demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("You explain him that you didn't tell him since you don't want him to suffer.");
                    WriteLine("You refuse to tell you name of the culprit.");
                    WriteLine("You'll gain 15Pts.");
                    LevelofAffection += 15;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("He hears as you try to explain yourself. He knows well that you're lying");
                    WriteLine("He despise you more than before! You'll lose 15Pts.");
                    LevelofAffection -= 15;
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
            WriteLine("Izekiel has asked you to come the training.");
            WriteLine("You know that he just wants to make you say the culprit");
            string response = GetAnswerFromUser("\nWill you help him? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You are brave!");
                WriteLine("You had to go through the most exhausting training of your life");
                WriteLine("He tells you that if you want him to stop you just have to tell him.");

                string AcceptOffer = GetAnswerFromUser("\nWill accept the offer? (Yes/No): ", "yes", "no");
                if (AcceptOffer == "yes")
                {
                    WriteLine("\nYou couldn't handel it and you told him the truth.");
                    WriteLine("You tell him that you witnesses a dragon killing his master");
                    WriteLine("He doesn't believe you and let you go dissapointed. You'll lose 20Pts.");
                    LevelOFAffection -= 20;
                }
                if (AcceptOffer == "no")
                {
                    WriteLine("\nYou refuse to tell him, you had to endure the training for the rest of the day.");
                    WriteLine("You've gained 20Pts.");
                    LevelOFAffection += 20;
                }
            }
            if (response == "no")
            {
                WriteLine("He comes to find you and make you go through the training process");
                WriteLine("He made you do an extreme training and wouldn't let you rest");
                WriteLine("You lost 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nOn the next day. He comes looking for you");
            WriteLine("The both of you ended up fighting again");
            WriteLine("You told him that the culprit was a dragon but he wouldn't believe");
            WriteLine("He ask for a proof and you have it.");
            string response = GetAnswerFromUser("Will you give him the proof (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou gave him the recording you had of the incident.");
                WriteLine("He starts going mad. He tries to go find the dragon.");
                string LetHimLeave = GetAnswerFromUser("Will you stop him or let him go? (Stop him/Let him go): ", "stop him", "let him go");
                if (LetHimLeave == "stop him")
                {
                    WriteLine("You tried by all means to stop him but you couldn't.");
                    WriteLine("You went after him but couldn't catch up! You'll gain 20Pts.");
                    LevelOFAffection += 15;
                }
                if (LetHimLeave == "let him go")
                {
                    WriteLine("You know you wouldn't be able to stop him so you just let him go.");
                    WriteLine("You'll gain 10Pts.");
                    LevelOFAffection += 10;
                }
            }
            if (response == "no")
            {
                WriteLine("He doesn't believe in you, even so, he tries to go find the so called dragon.");
                WriteLine("You tried to stop him but couldn't do anything about it.");
                WriteLine("You'll lose 20Pts.");
                LevelOFAffection -= 20;
            }
            round++;
        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nYou haven't seen Izekiel for two days.");
            WriteLine("You think that he may be traped in the forest.");
            string response = GetAnswerFromUser("Will you go to the forest? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You went to the forest and found Izekiel in a delicate state.");
                WriteLine("After healing him you brougth him back home.");
                WriteLine("You'll gain 15Pts.");
                LevelOFAffection += 15;
            }
            if (response == "no")
            {
                WriteLine("\nBy the end of the week Athanasia came back with an unconscious Izekiel.");
                WriteLine("You know that is your fault and you feel guilty about it.");
                WriteLine("You've lost 25Pts.");
                LevelOFAffection -= 25;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nToday Izekiel woke up after one week of beign unconscious.");
            string response = GetAnswerFromUser("Will go meet him? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("He tells you that he's sorry for not believe in you.");
                WriteLine("He understands why you didn't tell him the culprit.");
                WriteLine("You'll win 20Pts.");
                LevelOfAffection += 25;
            }
            if (response == "no")
            {
                WriteLine("That day in the afternoon he comes to find you.");
                WriteLine("He tells you sorry for not believe in you, however, he's still mad at you for lying.");
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
