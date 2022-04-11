using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.Logic
{
    public interface INumbersReader
    {
        IEnumerable<int> ReadNumbersFromFile(string filePath);
    }

    public class NumbersReader : INumbersReader
    {
        public IEnumerable<int> ReadNumbersFromFile(string filePath)
        {
            var fileContent = File.ReadAllText(filePath);
            var numbersAsText = fileContent.Split(',');

            foreach (var numberAsText in numbersAsText)
            {
                var number = int.Parse(numberAsText);
                yield return number;
            }
        }
    }
}
