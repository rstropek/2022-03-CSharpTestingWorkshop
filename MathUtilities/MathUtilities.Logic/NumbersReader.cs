namespace MathUtilities.Logic
{
    public class NumbersReader
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
