var myNumbers = GetNumbersBetter();
var filteredNumbers = RemoveOddNumbersBetter(myNumbers);
foreach(var number in filteredNumbers)
{
    Console.WriteLine(number);
}

IEnumerable<int> GetNumbers()
{
    var numbers = new List<int>();
    for (var i = 0; i < 10; i++)
    {
        numbers.Add(i);
    }

    return numbers;
}

IEnumerable<int> GetNumbersBetter()
{
    for (var i = 0; i < 10; i++)
    {
        yield return i;
    }
}

IEnumerable<int> RemoveOddNumbers(IEnumerable<int> numbers)
{
    var result = new List<int>();
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            result.Add(number);
        }
    }

    return result;
}

IEnumerable<int> RemoveOddNumbersBetter(IEnumerable<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            yield return number;
        }
    }
}