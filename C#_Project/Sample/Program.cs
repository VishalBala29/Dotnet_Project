using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine("Hello " + Convert.ToString(num));

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum: " + (num + num1));

            string str = Convert.ToString(num1);
            Console.WriteLine("String version of input: " + str);
            Console.WriteLine("Concatenation: " + num + str); // concatenating
            Console.WriteLine("Square root: " + Math.Sqrt(num1));
            Console.WriteLine("String length: " + str.Length);

            // Using Sample class
            Sample sample = new Sample();
            int result = sample.Add(num, num1);
            Console.WriteLine("Sum using class method: " + result);
        }
    }

    class Sample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
