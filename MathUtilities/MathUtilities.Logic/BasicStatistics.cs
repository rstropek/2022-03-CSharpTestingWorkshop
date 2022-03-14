using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.Logic
{
    public class BasicStatistics
    {
        public int SumOfNumbers(IEnumerable<int> numbers)
        {
            var sum = 0;
            foreach(var n in numbers)
            {
                sum += n;
            }

            return sum;

            // return numbers.Sum();
        }

        public int SumOfNumbersFromFile()
        {
            var reader = new NumbersReader();
            return SumOfNumbers(reader.ReadNumbers());
        }
    }
}
