using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guinness_Book_of_World_Records_Trivia
{
    class Program
    {
        private static string userAnswer2;

        public static string Username { get; private set; }

        static void Main(string[] args)
        {
            int highscore = 0;
            string UserName;
            Console.WriteLine("ENTER YOUR NAME");
            Username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome, " + Username);
            Console.WriteLine("The following Trivia quiz will facinate you on World Records recorded in the Guinness Book of World Records");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Answer 5 questions and you get an unlimited amount of time and tries at each question.");
            Console.WriteLine("To proceed, press enter repeatedly.");
            Console.ReadLine();
            Console.Clear();
            Console.ReadKey();

            Console.WriteLine("READY??");
            Console.ReadKey();
            



            
            Console.WriteLine("Question one: Who is the tallest person in the world?");
            Console.Write("Answer: ");
            Console.WriteLine("Sultan Kosen");
            Console.WriteLine("Shaquile O'Neil");
            Console.WriteLine("Kareem Abdul Jabar");
            
            

            { 
            string userAnswer1;
            userAnswer1 = Console.ReadLine();
            userAnswer1 = userAnswer1.ToLower();
                if (userAnswer1 == answer1)
            {
                    Console.WriteLine("Correct answer!! He is the tallest living person since 17 September 2009, as verified by Guinness World Records. Please press enter repetedly for the next stage.");
                    highscore++;
                    Console.ReadKey();
                    Console.Clear();

                    break;
                }
                else
                    (userAnswer2 != answer1)
                {
                
                string userAnswer2;
                userAnswer2 = Console.ReadLine();
                userAnswer2 = userAnswer2.ToLower();
                Console.WriteLine("Wrong answer. Continue to press Enter to get to next stage");
                Console.ReadKey();
                Console.Clear();
            }
    }
}
    }
