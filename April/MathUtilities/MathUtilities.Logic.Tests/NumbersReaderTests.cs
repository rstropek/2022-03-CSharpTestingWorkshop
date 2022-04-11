using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathUtilities.Logic.Tests
{
    public class NumbersReaderTests
    {
        [Fact]
        public void ReadNumberFromFile()
        {
            var reader = new NumbersReader();
            var numbers = reader.ReadNumbersFromFile("numbers.txt");
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, numbers);
        }
    }
}
