using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            string answer = "";
            bool spela = true;

            string q1 = "First question, How many bones in a shark?";
            string a11 = "250";
            string a12 = "100";
            string a13 = "0";
            string c1 = "3";

            string q2 = "Second question, This one is a douzie! Var lägger gökar ägg?";
            string a21 = "I en grop i marken";
            string a22 = "I andra fåglars bo";
            string a23 = "I vanliga bon av pinnar";
            string c2 = "2";

            string q3 = "Third question, What is this planet called?";
            string a31 = "Saturn";
            string a32 = "Neptune";
            string a33 = "Uranus";
            string c3 = "1";

            while (spela)
            {
                points = 0;
                System.Console.WriteLine("Welcome to the show! 1 right answer is 100 points, let's see who's a dumb boi!");

                points += Fråga(q1, a11, a12, a13, c1);

                points += Fråga(q2, a21, a22, a23, c2);

                points += BFråga(q3, a31, a32, a33, c3);

                System.Console.WriteLine("Alright results are in!");
                System.Console.WriteLine("You got: " + points + " points!");

                if (points == 300)
                {
                    System.Console.WriteLine("Perfect quiz! Amazing");
                }
                else if (points == 200)
                {
                    System.Console.WriteLine("Good enough!");
                }
                else
                {
                    System.Console.WriteLine("Kinda Trash, ngl");
                }

                Console.ReadLine();

                answer = "";
                while (answer != "n" && answer != "y")
                {
                    System.Console.WriteLine("Vill du spela igen? Y/N");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "n")
                    {
                        spela = false;
                    }
                    else if (answer == "y")
                    {
                        System.Console.WriteLine("Let's goo!");
                    }
                }
            }
        }
        static int Fråga(string q, string a1, string a2, string a3, string c)
        {
            string ans = "";
            while (ans != "1" && ans != "2" && ans != "3")
            {
                System.Console.WriteLine(q);
                System.Console.WriteLine("1: " + a1);
                System.Console.WriteLine("2: " + a2);
                System.Console.WriteLine("3: " + a3);

                ans = Console.ReadLine();
            }

            if (ans == c)
            {
                System.Console.WriteLine("Correct!");
                return 100;
            }
            else
            {
                System.Console.WriteLine("Fail!");
                return 0;
            }



        }
        static int BFråga(string q, string a1, string a2, string a3, string c)
        {
            string ans = "";
            while (ans != "1" && ans != "2" && ans != "3")
            {
                Console.WriteLine("    _...MMMMM88&&&&..._");
                Console.WriteLine(" .::'''MMMMM88&&&&&&'''::.");
                Console.WriteLine("::     MMMMM88&&&&&&     ::");
                Console.WriteLine("'::....MMMMM88&&&&&&....::'");
                Console.WriteLine("   `''''MMMMM88&&&&''''`");
                Console.WriteLine("         'MMM8&&&'");
                System.Console.WriteLine(q);
                System.Console.WriteLine("1: " + a1);
                System.Console.WriteLine("2: " + a2);
                System.Console.WriteLine("3: " + a3);

                ans = Console.ReadLine();
            }

            if (ans == c)
            {
                System.Console.WriteLine("Correct!");
                return 100;
            }
            else
            {
                System.Console.WriteLine("Fail!");
                return 0;
            }
        }
    }
}