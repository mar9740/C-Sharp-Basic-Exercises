using System;

namespace Basic_Exercises
{
    class Program
    {
        /// <summary>
        /// This main program is used to execute specific functions that are created off of the site
        /// https://www.w3resource.com/csharp-exercises/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.ex11();
        }

        /// <summary>
        /// Print out my name followed by a newline
        /// </summary>
        public static void ex1()
        {
            Console.WriteLine("Hello:\nMichael Root");
        }

        /// <summary>
        /// Print out the combination of 2 integers
        /// </summary>
        /// <param name="n1">Integer 1</param>
        /// <param name="n2">Integer 2</param>
        public static void ex2(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        /// <summary>
        /// Print out the division of 2 numbers
        /// </summary>
        /// <param name="n1">int 1</param>
        /// <param name="n2">int 2</param>
        public static void ex3(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
        /// <summary>
        /// Program to print out math equation values
        /// </summary>
        public static void ex4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        /// <summary>
        /// Reverse the order of 2 inputted numbers
        /// </summary>
        public static void ex5()
        {
            Console.Write("Enter the first number: ");
            var int1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            var int2 = Console.ReadLine();
            Console.WriteLine("First number: {0}", int2);
            Console.WriteLine("Second number: {0}", int1);
        }

        /// <summary>
        /// multiply 3 given numbers
        /// </summary>
        public static void ex6()
        {
            Console.Write("first number: ");
            var n1 = int.Parse(Console.ReadLine());
            Console.Write("second number: ");
            var n2 = int.Parse(Console.ReadLine());
            Console.Write("first number: ");
            var n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} x {2} = {3}", n1, n2, n3, n1 * n2 * n3);
        }

        /// <summary>
        /// 5 operations enacted on 2 integers
        /// </summary>
        public static void ex7()
        {
            Console.Write("first number: ");
            var n1 = int.Parse(Console.ReadLine());
            Console.Write("second number: ");
            var n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", n1, n2, (n1+n2));
            Console.WriteLine("{0} - {1} = {2}", n1, n2, (n1 - n2));
            Console.WriteLine("{0} x {1} = {2}", n1, n2, (n1 * n2));
            Console.WriteLine("{0} / {1} = {2}", n1, n2, (n1 / n2));
            Console.WriteLine("{0} % {1} = {2}", n1, n2, (n1 % n2));
        }

        /// <summary>
        /// Times table print out on inputted number
        /// </summary>
        public static void ex8()
        {
            Console.Write("Enter number for times table: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }

        /// <summary>
        /// Basic if statement checking
        /// </summary>
        public static void ex11()
        {
            Console.Write("enter your age: ");
            var age = int.Parse(Console.ReadLine());

            if(age > 20)
            {
                Console.WriteLine("you look older than 20");
            }
            else
            {
                Console.WriteLine("you look younger than 20");
            }
        }


    }
}
