using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(1, 100).ToList();

            DivisibilityChecker dc = new DivisibilityChecker(new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
                { 7, "Jazz" },
            });

            foreach (var number in numbers)
            {
                Console.Write(dc.EvenlyDivisable(number));
            }

            Console.ReadLine();
        }
    }
}
