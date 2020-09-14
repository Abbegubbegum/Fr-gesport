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

            while (spela)
            {
                points = 0;
                answer = "";

                System.Console.WriteLine("Welcome to the show! 1 right answer is 100 points, let's see who's a dumb boi!");

                while (answer != "1" && answer != "2" && answer != "3")
                {
                    System.Console.WriteLine("First question, How many bones in a shark?");
                    System.Console.WriteLine("1: 250");
                    System.Console.WriteLine("2: 100");
                    System.Console.WriteLine("3: 0");

                    answer = Console.ReadLine();
                }

                if (answer == "3")
                {
                    System.Console.WriteLine("Correct!");
                    points += 100;
                }
                else
                {
                    System.Console.WriteLine("Fail!");
                }

                answer = "";
                while (answer != "1" && answer != "2" && answer != "3")
                {

                    System.Console.WriteLine("Second question, This one is a douzie! Var lägger gökar ägg?");
                    System.Console.WriteLine("1: I en grop i marken");
                    System.Console.WriteLine("2: I andra fåglars bo");
                    System.Console.WriteLine("3: I vanliga bon av pinnar");

                    answer = Console.ReadLine();
                }

                if (answer == "2")
                {
                    System.Console.WriteLine("Correct!");
                    points += 100;
                }
                else
                {
                    System.Console.WriteLine("Fail!");
                }

                answer = "";
                while (answer != "1" && answer != "2" && answer != "3")
                {


                    Console.WriteLine("    _...MMMMM88&&&&..._");
                    Console.WriteLine(" .::'''MMMMM88&&&&&&'''::.");
                    Console.WriteLine("::     MMMMM88&&&&&&     ::");
                    Console.WriteLine("'::....MMMMM88&&&&&&....::'");
                    Console.WriteLine("   `''''MMMMM88&&&&''''`");
                    Console.WriteLine("         'MMM8&&&'");
                    System.Console.WriteLine("Third question, What is this planet called?");
                    System.Console.WriteLine("1: Saturn");
                    System.Console.WriteLine("2: Neptune");
                    System.Console.WriteLine("3: Uranus");


                    answer = Console.ReadLine();
                }

                if (answer == "1")
                {
                    System.Console.WriteLine("Correct!");
                    points += 100;
                }
                else
                {
                    System.Console.WriteLine("Fail!");
                }

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

                    }

                }


            }
        }
    }
}




