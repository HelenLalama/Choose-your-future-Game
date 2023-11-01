using System;
using static System.Console;

namespace Lucas // Note: actual namespace depends on the project name.
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
                WriteLine("Your level of friendship with Lucas reached 100Pts!");
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
            WriteLine("\nLucas has called you to his house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Lucas!");

                WriteLine("You've arrived to his house.\n");
                WriteLine("Lucas tells you that he knows that you've been using his name without his consent.");
                WriteLine("He demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("You explain that you were mowed down by your greed and ask for forgiveness.");
                    WriteLine("He doesn't forgive you but he lets you go home without problems.");
                    WriteLine("You'll gain 20Pts.");
                    LevelofAffection += 20;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("Lucas hears your excuses and sees through them. He kicks you out of his house.");
                    WriteLine("He hates you more than he did before! You'll lose 10Pts.");
                    LevelofAffection -= 10;
                }
            }
            if (response == "no")
            {
                WriteLine("\nYou have decided not to meet Lucas!");
                WriteLine("Your level of friendship will decrease 5 Pts.");
                LevelofAffection -= 5;
            }
            round++;
        }

        //This method will diplay the Round 2 of the game
        public static void Round2(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nNext day begins!");
            WriteLine("Your group has received a job request.");
            WriteLine("You have to defeat a group of monsters that are abusing a city. They need help form a magician and a healer.");
            WriteLine("Athanasia and you are the healers of the group. Athanasia was the first option but she's busy in another job.");
            string response = GetAnswerFromUser("\nWill you accept the request? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You've decided to accept the job! Lucas is thankful for your action. You'll get 10Pts\n");
                LevelOFAffection += 10;

                WriteLine("You arrive in the city. Lucas went to defeat the monsters while you are in charge of the wounded people.");
                WriteLine("It's been a few hours and he hasn't come back.");

                string LookForLucas = GetAnswerFromUser("\nWill you go find Lucas? (Yes/No): ", "yes", "no");
                if (LookForLucas == "yes")
                {
                    WriteLine("\nYou went to find Lucas and you find him wounded because of a monster.");
                    WriteLine("As soon as you saw that you started treating him. You brought him back to his house.");
                    WriteLine("Lucas is grateful for your help. You've gained 20Pts");
                    LevelOFAffection += 20;
                }
                if (LookForLucas == "no")
                {
                    WriteLine("\nSeveral hours later he comes back with a big wound.");
                    WriteLine("You had to heal him. Afterwards, you left him in his house.\n");
                    WriteLine("You've gained 15 Pts.");
                    LevelOFAffection += 15;
                }
            }
            if (response == "no")
            {
                WriteLine("Lucas went to the mission alone as Athanasia couldn't go with him.");
                WriteLine("Later that day he came back from his mission with several wounds.");
                WriteLine("You had to go treat his wounds. You lost 5Pts.");
                LevelOFAffection -= 5;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nYou have treated Lucas. He's currently in his house bedridden.");
            WriteLine("Your members have asked you look after him.");
            string response = GetAnswerFromUser("Will you accept this request (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou stayed all night looking after Lucas.");
                WriteLine("The next day he woke up. He's still mad at you, therefore, he asked you to leave.");
                string WillyouLeave = GetAnswerFromUser("Will you stay? (Stay/Go): ", "stay", "go");
                if (WillyouLeave == "stay")
                {
                    WriteLine("You stayed even when he told you to do so.");
                    WriteLine("You both started to talk, recalled memories, and had a great time together!");
                    WriteLine("Good decision! You'll gain 25 Pts.");
                    LevelOFAffection += 25;
                }
                if (WillyouLeave == "go")
                {
                    WriteLine("You left the house. Lucas is helpful for your help.");
                    WriteLine("You'll gain 20 Pts.");
                    LevelOFAffection += 20;
                }
            }
            if (response == "no")
            {
                WriteLine("You went home, however, the members of the group were resentful towards you.");
                WriteLine("You'll lose 5Pts.");
                LevelOFAffection -= 5;
            }
            round++;
        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nLucas's situation has improved");
            WriteLine("The members have noticed the problems between you and Lucas.");
            string response = GetAnswerFromUser("Will you tell the members? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("The members promise to help you out with Lucas situation.");
                WriteLine("They will make you both talk about the problems so you can reach an agreement.");
                WriteLine("You'll gain 25Pts.");
                LevelOFAffection += 25;
            }
            if (response == "no")
            {
                WriteLine("The members are done with the problems you've made.");
                WriteLine("They'll make you talk with Lucas or you'll have to leave the group");
                WriteLine("Your members are really angry. You've lost 10 Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nYou are supposed to meet Lucas this afternoon.");
            string response = GetAnswerFromUser("Will you escape from the reunion? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("The members and Lucas are extremely mad at you.");
                WriteLine("They can't stand your pressence in the group anymore.");
                WriteLine("They have decided to leave your luck to Lucas.");
                WriteLine("You'll lose 10Pts.");
                LevelOfAffection -= 10;
            }
            if (response == "no")
            {
                WriteLine("You went to talk to Lucas about all the problems you've made");
                WriteLine("You apologize and then leave the place.");
                WriteLine("You'll earn 30 Pts.");
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
                WriteLine("Your level of friendship with Lucas reached 100Pts!");
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
            WriteLine("\nLucas has called you to his house to discuss what you have done.");
            string response = GetAnswerFromUser("Will you accept this invitation? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou have decided to meet Lucas!");

                WriteLine("You've arrived to his house.\n");
                WriteLine("Lucas tells you that he knows that you've been using his name without his consent.");
                WriteLine("He demands an explanation from you.\n");

                string explanation = GetAnswerFromUser("What will you respond with? (Explanation/Excuse): ", "explanation", "excuse");
                if (explanation == "explanation")
                {
                    WriteLine("You explain that you were mowed down by your greed and ask for forgiveness.");
                    WriteLine("He doesn't forgive you but he lets you go home without problems.");
                    LevelofAffection += 10;
                }
                else if (explanation == "excuse")
                {
                    WriteLine("Lucas hears your excuses and sees through them. He kicks you out of his house.");
                    WriteLine("He hates you more than he did before! You'll lose 15Pts.");
                    LevelofAffection -= 15;
                }
            }
            if (response == "no")
            {
                WriteLine("\nYou have decided not to meet Lucas!");
                WriteLine("Your level of friendship will decrease 10 Pts.");
                LevelofAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 2 of the game
        public static void Round2(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nNext day begins!");
            WriteLine("Your group has received a job request.");
            WriteLine("You have to defeat a group of monsters that are abusing a city. They need help form a magician and a healer.");
            WriteLine("Athanasia and you are the healers of the group. Athanasia was the first option but she's busy in another job.");
            string response = GetAnswerFromUser("\nWill you accept the request? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("You've decided to accept the job! Lucas is thankful for your action. You'll get 5Pts\n");
                LevelOFAffection += 5;

                WriteLine("You arrive in the city. Lucas went to defeat the monsters while you are in charge of the wounded people.");
                WriteLine("It's been a few hours and he hasn't come back.");

                string LookForLucas = GetAnswerFromUser("\nWill you go find Lucas? (Yes/No): ", "yes", "no");
                if (LookForLucas == "yes")
                {
                    WriteLine("\nYou went to find Lucas and you find him wounded because of a monster.");
                    WriteLine("As soon as you saw that you started treating him. You brought him back to his house.");
                    WriteLine("Lucas is grateful for your help. You've gained 15Pts");
                    LevelOFAffection += 15;
                }
                if (LookForLucas == "no")
                {
                    WriteLine("\nSeveral hours later he comes back with a big wound.");
                    WriteLine("You had to heal him. Afterwards, you left him in his house.\n");
                    WriteLine("You've gained 10 Pts.");
                    LevelOFAffection += 10;
                }
            }
            if (response == "no")
            {
                WriteLine("Lucas went to the mission alone as Athanasia couldn't go with him.");
                WriteLine("Later that day he came back from his mission with several wounds.");
                WriteLine("You had to go treat his wounds. You lost 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 3 of the game
        public static void Round3(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nYou have treated Lucas. He's currently in his house bedridden.");
            WriteLine("Your members have asked you look after him.");
            string response = GetAnswerFromUser("Will you accept this request (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("\nYou stayed all night looking after Lucas.");
                WriteLine("The next day he woke up. He's still mad at you, therefore, he asked you to leave.");
                string WillyouLeave = GetAnswerFromUser("Will you stay? (Stay/Go): ", "stay", "go");
                if (WillyouLeave == "stay")
                {
                    WriteLine("You stayed even when he told you to do so.");
                    WriteLine("You both started to talk, recalled memories, and had a great time together!");
                    WriteLine("Good decision! You'll gain 20 Pts.");
                    LevelOFAffection += 20;
                }
                if (WillyouLeave == "go")
                {
                    WriteLine("You left the house. Lucas is helpful for your help.");
                    WriteLine("You'll gain 10 Pts.");
                    LevelOFAffection += 10;
                }
            }
            if (response == "no")
            {
                WriteLine("You went home, however, the members of the group were resentful towards you.");
                WriteLine("You'll lose 10Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 4 of the game
        public static void Round4(ref int LevelOFAffection, ref int round)
        {
            WriteLine("\nLucas's situation has improved");
            WriteLine("The members have noticed the problems between you and Lucas.");
            string response = GetAnswerFromUser("Will you tell the members? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("The members promise to help you out with Lucas situation.");
                WriteLine("They will make you both talk about the problems so you can reach an agreement.");
                WriteLine("You'll gain 10Pts.");
                LevelOFAffection += 10;
            }
            if (response == "no")
            {
                WriteLine("The members are done with the problems you've made.");
                WriteLine("They'll make you talk with Lucas or you'll have to leave the group");
                WriteLine("Your members are really angry. You've lost 10 Pts.");
                LevelOFAffection -= 10;
            }
            round++;
        }

        //This method will diplay the Round 5 of the game
        public static void Round5(ref int LevelOfAffection, ref int round)
        {
            WriteLine("\nYou are supposed to meet Lucas this afternoon.");
            string response = GetAnswerFromUser("Will you escape from the reunion? (Yes/No): ", "yes", "no");
            if (response == "yes")
            {
                WriteLine("The members and Lucas are extremely mad at you.");
                WriteLine("They can't stand your pressence in the group anymore.");
                WriteLine("They have decided to leave your luck to Lucas.");
                WriteLine("You'll lose 15 Pts.");
                LevelOfAffection -= 15;
            }
            if (response == "no")
            {
                WriteLine("You went to talk to Lucas about all the problems you've made");
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
}