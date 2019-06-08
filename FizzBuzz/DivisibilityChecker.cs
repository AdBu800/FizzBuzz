using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class DivisibilityChecker
    {
        public Dictionary<int, string> NumberStringMapping { get; private set; }

        public DivisibilityChecker(Dictionary<int, string> numberStringMapping)
        {
            NumberStringMapping = numberStringMapping;
        }

        public string EvenlyDivisable(int number)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var kvp in NumberStringMapping)
            {
                if(number % kvp.Key == 0)
                {
                    sb.Append(kvp.Value);
                }
            }

            if(sb.Length != 0)
            {
                sb.AppendLine(string.Format(" ({0})", number));
            }

            return sb.ToString();
        }
    }
}
