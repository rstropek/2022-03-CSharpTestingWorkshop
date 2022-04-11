using System.Text;

var myNumbers = new List<int> { 1, 2, 3, 4 };

var myEvenNumbers = Filter(GetNumbers(), (number) => number < 50);
var myWords = Filter(GetWords(), (word) => word.StartsWith('E'));
foreach (var number in myEvenNumbers)
{
    Console.WriteLine(number);
    if (number >= 10)
    {
        break;
    }
}

foreach (var word in GetWords())
{
    Console.WriteLine(word);
    if (word.StartsWith('A'))
    {
        break;
    }
}

IEnumerable<int> GetNumbers()
{
    //yield return 1;
    //yield return 2;
    //yield return 3;
    //yield return 4;

    var i = 0;
    while (true)
    {
        yield return ++i;
    }
}

IEnumerable<T> Filter<T>(IEnumerable<T> items, ShouldKeepCondition<T> condition)
{
    foreach (var item in items)
    {
        if (condition(item))
        {
            yield return item;
        }
    }
}

IEnumerable<string> GetWords()
{
    while (true)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < 5; i++)
        {
            sb.Append((char)('A' + Random.Shared.Next(26)));
        }

        yield return sb.ToString();
    }
}

bool IsEven(int number) => number % 2 == 0;
bool IsOdd(int number) => number % 2 != 0;
bool IsSmall(int number) => number < 50;

delegate bool ShouldKeepCondition<T>(T number);
