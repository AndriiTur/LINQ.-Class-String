using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Class_String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task8_1
            List<int> digits = new List<int>();
            Random rand = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                digits.Add(rand.Next(-20, 21));
            }

            foreach (int dig in digits)
                Console.WriteLine("All digit(s) from list: {0}", dig);

            Console.WriteLine("");

            IEnumerable<int> digitLessThanZero =
                               digits.Where(i => i < 0);

            foreach (int dig in digitLessThanZero)
                Console.WriteLine("Negativ digit(s) from list: {0}", dig);

            Console.WriteLine("");

            IEnumerable<int> pairedDigits =
                               digits.Where(i => i > 0 && i % 2 == 0);

            foreach (int dig in pairedDigits)
                Console.WriteLine("Paired digit(s) from list: {0}", dig);

            Console.WriteLine("\nMax digit(s) from list: {0}", digits.Max());
            Console.WriteLine("\nMin digit(s) from list: {0}", digits.Min());

            var sum = digits.Sum(x => x);
            Console.WriteLine("\nSum digit(s) from list: {0}", sum);

            Console.WriteLine("\nDigits AVG from list: {0}", digits.Average());
            Console.WriteLine("\nLess than AVG digit from list: {0}", digits.First(i => i < digits.Average()));

            Console.WriteLine("");

            var sorted = from digit in digits
                          orderby digit
                          select digit;

            foreach (int dig in sorted)
                Console.WriteLine("Sorted digit from list: {0}", dig);

            Console.ReadKey();
            #endregion
        }
    }
}
