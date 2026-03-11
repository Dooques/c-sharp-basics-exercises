using System.Diagnostics;

namespace c_sharp_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Print(string output) { Console.WriteLine(output); }
            static void Challenge1()
            {
                double pi = 3.14;
                bool islearningCSharp = true;
                string favouriteFilm = "High School Musical";

                favouriteFilm = "Blue Velvet";
                Console.WriteLine($"My favourite film is: {favouriteFilm}");
            }

            void Challenge2()
            {
                PrintGreeting("Vic");
            }

            static void Challenge3()
            {
               Print(SubtractNumbers(new int[] { 1, 2 }).ToString());
            }

            static void Challenge4()
            {
                Print(isStringLonger("Laptop", 7).ToString().ToUpper());
            }

            static void Challenge5()
            {
                int addResult = SumNumbers(3, 4);
            }

            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();

        }

        private static int SumNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        private static bool isStringLonger(string word, int number)
        {
            return word.Length > number;
        }

        private static int SubtractNumbers(int[] numbers)
        {
            return numbers[0] - numbers[1];
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }

    }
}
