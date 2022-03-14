namespace MathUtilities.Logic
{
    public class BasicStatistics
    {
        private readonly INumbersReader reader;

        public BasicStatistics(INumbersReader reader)
        {
            this.reader = reader;
        }

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

        public int SumOfNumbersFromReader()
        {
            return SumOfNumbers(reader.ReadNumbers());
        }
    }
}
