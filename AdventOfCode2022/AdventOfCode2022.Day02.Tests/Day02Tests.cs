using System.IO;
using Xunit;

namespace AdventOfCode2022.Day01.Tests
{
    public class Day02Tests
    {
        [Fact]
        public void Part1()
        {
            var lines = File.ReadAllLines("data.txt");
            var solver = new PuzzleSolver();
            var result = solver.SolvePart1(lines);
            Assert.Equal(150, result);
        }

        [Fact]
        public void CalculateHorizontalPositionChange()
        {
            var cmd = new Command("forward", 1);
            Assert.Equal(1, cmd.HorizontalPositionChange);
        }

        [Fact]
        public void CalculateNoHorizontalPositionChange()
        {
            var cmd = new Command("down", 1);
            Assert.Equal(0, cmd.HorizontalPositionChange);
        }
    }
}