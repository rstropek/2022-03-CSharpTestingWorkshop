using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("MathUtilities.Tests")]

namespace MathUtilities.Logic
{
    public interface INumbersReader
    {
        IEnumerable<int> ReadNumbers();
    }

    internal class NumbersFromFileReader : INumbersReader
    {
        public IEnumerable<int> ReadNumbers()
        {
            var fileText = File.ReadAllText("numbers.txt");
            var numbersTexts = fileText.Split(',');
            foreach (var n in numbersTexts)
            {
                yield return int.Parse(n);
            }

            // Linq
            //return File.ReadAllText("numbers.txt")
            //    .Split(',')
            //    .Select(n => int.Parse(n));
        }
    }
}
