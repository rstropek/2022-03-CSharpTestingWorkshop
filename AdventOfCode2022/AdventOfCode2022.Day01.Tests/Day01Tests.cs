using System.IO;
using Xunit;

namespace AdventOfCode2022.Day01.Tests
{
    public class Day01Tests
    {
        [Fact]
        public void Part1()
        {
            var lines = File.ReadAllLines("data.txt");
            var solver = new PuzzleSolver();
            var result = solver.SolvePart1(lines);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Part2()
        {
            var lines = File.ReadAllLines("data.txt");
            var solver = new PuzzleSolver();
            var result = solver.SolvePart2(lines);
            Assert.Equal(5, result);
        }
    }
}