using System.Xml.Linq;

namespace Assignment5._1._1
{
    internal class Program
    {
        static int input;
        static void Main(string[] args)
        {
            GetInputs();
            Console.WriteLine(IsPalindrome(input));
        }

        public static void GetInputs()
        {
            Console.Write($"Enter a positive integer: ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int originalNumber = x;
            int reversedNumber = 0;

            while (x > 0)
            {
                int lastDigit = x % 10;
                reversedNumber = (reversedNumber * 10) + lastDigit;
                x /= 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}
