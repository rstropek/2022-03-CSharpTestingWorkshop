var solver = new PuzzleSolver();
var result = solver.SolvePart1();
Console.WriteLine(result);

public record Command(string Direction, int Value)
{
    public int HorizontalPositionChange => Direction is "forward" ? Value : 0;

    public int DepthChange => Direction switch
        {
            "up" => -Value,
            "down" => Value,
            _ => 0
        };
}

public class PuzzleSolver
{
    internal IEnumerable<Command> ParseCommandStrings(IEnumerable<string> lines)
    {
        //foreach(var line in lines)
        //{
        //    yield return ParseCommand(line);
        //}
        return lines.Select(ParseCommand);
    }

    internal Command ParseCommand(string line)
    {
        var lineSegments = line.Split(' ');
        return new Command(lineSegments[0], int.Parse(lineSegments[1]));
    }

    public int SolvePart1(IEnumerable<string> lines)
    {
        var horizontalPosition = 0;
        var depth = 0;
        foreach(var command in ParseCommandStrings(lines))
        {
            horizontalPosition += command.HorizontalPositionChange;
            depth += command.DepthChange;
        }

        return horizontalPosition * depth;
    }

    public int SolvePart1()
    {
        var lines = File.ReadAllLines("data.txt");
        return SolvePart1(lines);
    }
}