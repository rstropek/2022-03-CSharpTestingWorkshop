CalculateAndPrint(1, 2, Add);
CalculateAndPrint(1, 2, delegate (int x, int y)
{
    return x + y;
});
CalculateAndPrint(1, 2, (int x, int y) =>
{
    return x + y;
});
CalculateAndPrint(1, 2, (int x, int y) => x + y);
CalculateAndPrint(1, 2, (c, d) => c + d);

GetValueAndPrint(() => 42);

ConvertAndPrint(41, e => e + 1);
ConvertAndPrint(41, (e) => e + 1);

ConvertAndPrintWithPrinter(41, (e) => e + 1, (f) => Console.WriteLine(f));

var myAdder = GetRandomAdder(5);
Console.WriteLine(myAdder());
Console.WriteLine(myAdder());

//void CalculateAndPrint(int a, int b, MathOp f)
void CalculateAndPrint(int a, int b, Func<int, int, int> f)
{
    var result = f(a, b);
    Console.WriteLine(result);
}

//void GetValueAndPrint(ValueGenerator f)
void GetValueAndPrint(Func<int> f)
{
    Console.WriteLine(f());
}

//void ConvertAndPrint(int a, Convert f)
void ConvertAndPrint(int a, Func<int, int> f)
{
    Console.WriteLine(f(a));
}

void ConvertAndPrintWithPrinter(int a, Func<int, int> f, Action<int> printer)
{
    printer(f(a));
}

/// <summary>
/// Lorem ipsum
/// </summary>
int Add(int x, int y)
{
    return x + y;
}

Func<int> GetRandomAdder(int x)
{
    var r = new Random();
    if (x % 2 == 0) return () => x + r.Next(0, 100);
    return () => x - r.Next(0, 100);
}

delegate int MathOp(int i, int j);
delegate int ValueGenerator();
delegate int Convert(int i);