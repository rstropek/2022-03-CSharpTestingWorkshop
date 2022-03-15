var adder = GetAdder();
Console.WriteLine(adder(1, 2));

Func<int, int, int> GetAdder()
{
    var z = new Random().Next(100);
    return (x, y) => x + y + z;
}
