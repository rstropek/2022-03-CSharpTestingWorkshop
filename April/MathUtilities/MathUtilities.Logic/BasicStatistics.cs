using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.Logic
{
    public static class BasicStatistics
    {
        public static int SumOfNumbers(IEnumerable<int> numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
