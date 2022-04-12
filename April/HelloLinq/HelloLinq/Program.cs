var numbers = new[] { 1, 2, 3, 4, 5 };

// Print even numbers
var evenNumbers = numbers.Where(n => n % 2 == 0);

// Print odd numbers
var oddNumbers = numbers.Where(n => n % 2 != 0);

// Print first number
var firstNumber = numbers.First();
// Print first number that is >= 3
firstNumber = numbers.First(n => n >= 3);

// Print last number
var lastNumber = numbers.Last();

// Print 3rd number
var thirdNumber = numbers.ElementAt(2);
thirdNumber = numbers.Skip(2).First();

// Print first even number
var firstEvenNumber = numbers.Where(n => n % 2 == 0).First();

// Print even numbers >= 3
var bigEvenNums = numbers
    .Where(n => n % 2 == 0)
    .Where(n => n >= 3);

bigEvenNums = numbers.Where(n => n % 2 == 0);
//if (onlyLargeNumbers)
{
    bigEvenNums = bigEvenNums.Where(n => n >= 3);
}

// Get numbers and multiply each number by 2
var doubledNumbers = numbers
    .Select(n => n * 2)
    .Where(n => n >= 5);

var numbersAsString = numbers.Select(n => n.ToString());

// Get sum of numbers
var sum = numbers.Sum();

// Get average of numbers
var average = numbers.Average();

// Get sum of first three numbers
var sumFirstThree = numbers.Skip(1).Take(3).Sum();

// Get numbers order descending
var descendingNumbers = numbers.OrderByDescending(n => n);

var numbersAsText = "1,2,3,4,5,6";
// Split text by comma, turn elements into numbers, calculate sum
var sumOfNumbers = numbersAsText.Split(',')
    .Select(n => int.Parse(n))
    .Sum();

var people = new Person[]
{
    new() { Name = "A", Age = 10 },
    new() { Name = "B", Age = 20 },
    new() { Name = "C", Age = 30 },
    new() { Name = "D", Age = 40 },
    new() { Name = "E", Age = 50 },
};

// People older than 30
var oldPeople = people.Where(p => p.Age > 30);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
