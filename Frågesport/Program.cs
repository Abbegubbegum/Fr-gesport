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
            string a1c = "0";

            string q2 = "Second question, This one is a douzie! Var lägger gökar ägg?";
            string a21 = "I en grop i marken";
            string a2c = "I andra fåglars bo";
            string a22 = "I vanliga bon av pinnar";


            string q3 = "Third question, What is this planet called?";
            string a3c = "Saturn";
            string a32 = "Neptune";
            string a31 = "Uranus";

            while (spela)
            {
                points = 0;
                System.Console.WriteLine("Welcome to the show! 1 right answer is 100 points, let's see who's a dumb boi!");

                points += Fråga(q1, a1c, a11, a12);

                points += Fråga(q2, a2c, a21, a22);

                points += BFråga(q3, a3c, a31, a32);

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
        static int Fråga(string q, string ac, string a1, string a2)
        {
            Random rnd = new Random();
            int ans = 0;
            int c = rnd.Next(0, 3);
            int a = rnd.Next(0, 3);
            string[] options = { "", "", "" };

            options[c] = ac;

            while (options[a] == ac)
            {
                a = rnd.Next(0, 3);
            }
            options[a] = a1;

            a = rnd.Next(0, 3);

            while (options[a] == ac || options[a] == a1)
            {
                a = rnd.Next(0, 3);
            }
            options[a] = a2;

            while (ans != 1 && ans != 2 && ans != 3)
            {
                System.Console.WriteLine(q);
                System.Console.WriteLine("1: " + options[0]);
                System.Console.WriteLine("2: " + options[1]);
                System.Console.WriteLine("3: " + options[2]);

                ans = Convert.ToInt32(Console.ReadLine());
            }

            if (ans == c + 1)
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
        static int BFråga(string q, string ac, string a1, string a2)
        {
            Random rnd = new Random();
            int ans = 0;
            int c = rnd.Next(0, 3);
            int a = rnd.Next(0, 3);
            string[] options = { "", "", "" };

            options[c] = ac;

            while (options[a] == ac)
            {
                a = rnd.Next(0, 3);
            }
            options[a] = a1;

            a = rnd.Next(0, 3);

            while (options[a] == ac || options[a] == a1)
            {
                a = rnd.Next(0, 3);
            }
            options[a] = a2;
            while (ans != 1 && ans != 2 && ans != 3)
            {
                Console.WriteLine("    _...MMMMM88&&&&..._");
                Console.WriteLine(" .::'''MMMMM88&&&&&&'''::.");
                Console.WriteLine("::     MMMMM88&&&&&&     ::");
                Console.WriteLine("'::....MMMMM88&&&&&&....::'");
                Console.WriteLine("   `''''MMMMM88&&&&''''`");
                Console.WriteLine("         'MMM8&&&'");
                System.Console.WriteLine(q);
                System.Console.WriteLine("1: " + options[0]);
                System.Console.WriteLine("2: " + options[1]);
                System.Console.WriteLine("3: " + options[2]);

                ans = Convert.ToInt32(Console.ReadLine());
            }

            if (ans == c + 1)
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