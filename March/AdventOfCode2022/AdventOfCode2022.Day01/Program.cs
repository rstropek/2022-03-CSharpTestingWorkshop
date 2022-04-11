var lines = File.ReadAllLines("data.txt");
var solver = new PuzzleSolver();
var result = solver.SolvePart1(lines);
Console.WriteLine(result);

var result2 = solver.SolvePart2(lines);
Console.WriteLine(result2);

public class PuzzleSolver
{
    public int SolvePart1(IEnumerable<string> lines)
        => SolvePart1(lines.Select(line => int.Parse(line)));

    public int SolvePart1(IEnumerable<int> values)
    {
        int? previous = null;
        var increaseCount = 0;
        foreach (var number in values)
        {
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
        => SolvePart1(GetWindows(lines));

    public IEnumerable<int> GetWindows(IEnumerable<string> lines)
        => GetWindows(lines.Select(line => int.Parse(line)));

    public IEnumerable<int> GetWindows(IEnumerable<int> numbers)
    {
        var numbersArray = numbers.ToArray();
        for (var i = 0; i < numbersArray.Length - 2; i++)
        {
            yield return numbersArray[i] + numbersArray[i + 1] + numbersArray[i + 2];
        }
    }
}