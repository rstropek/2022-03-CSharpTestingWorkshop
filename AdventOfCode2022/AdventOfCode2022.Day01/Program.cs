var lines = File.ReadAllLines("data.txt");
var solver = new PuzzleSolver();
var result = solver.SolvePart1(lines);
Console.WriteLine(result);

public class PuzzleSolver
{
    public int SolvePart1(IEnumerable<string> lines)
    {
        int? previous = null;
        var increaseCount = 0;
        foreach (var line in lines)
        {
            var number = int.Parse(line);
            if (previous.HasValue && number > previous)
            {
                increaseCount++;
            }

            previous = number;
        }

        return increaseCount;
    }

    public int SolvePart1()
    {
        var numbers = File.ReadAllLines("data.txt")
            .Select(l => int.Parse(l))
            .ToArray();
        return numbers
            .Select((l, ix) => (l, ix))
            .Skip(1)
            .Count(l => l.l > numbers[l.ix - 1]);
    }

    public int SolvePart2(IEnumerable<string> lines)
    {

    }
}