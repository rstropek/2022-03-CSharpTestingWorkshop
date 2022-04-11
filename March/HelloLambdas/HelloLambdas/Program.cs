var result = Add(21, 21);
Console.WriteLine(result);

CalculateAndPrint(new[] { 1, 1, 2, 3, 5, 8, 13 }, 0, Add);
CalculateAndPrint(new[] { 1, 1, 2, 3, 5, 8, 13 }, 1, Multiply);

CalculateAndPrint(new[] { 1, 1, 2, 3, 5, 8, 13 }, 0, (x, y) => x + y);
CalculateAndPrint(new[] { 1, 1, 2, 3, 5, 8, 13 }, 1, (x, y) => x * y);

CalculateAndPrint(new[] { "Tom", "Hans", "Rainer", "Karin" }, "", (x, y) => x + y);

int Add(int x, int y)
{
    return x + y;
}

void CalculateAndPrint<T>(IEnumerable<T> numbers, T initialValue, Func<T, T, T> operation)
{
    var sum = initialValue;
    foreach (var n in numbers)
    {
        sum = operation(sum, n);
    }

    Console.WriteLine(sum);
}

void AddAndPrint(IEnumerable<int> numbers)
{
    var sum = 0;
    foreach(var n in numbers)
    {
        sum = Add(sum, n);
    }

    Console.WriteLine(sum);
}

int Multiply(int x, int y)
{
    return x * y;
}

void MultiplyAndPrint(IEnumerable<int> numbers)
{
    var sum = 1;
    foreach (var n in numbers)
    {
        sum = Multiply(sum, n);
    }

    Console.WriteLine(sum);
}

//delegate int MathOp(int x, int y);

//delegate T Aggregate<T>(T x, T y);
