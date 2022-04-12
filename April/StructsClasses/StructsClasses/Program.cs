var p1 = new Person()
{
    FirstName = "Foo",
    LastName = "Bar",
};

Console.WriteLine(p1.GetFullName());

var p2 = new Person()
{
    FirstName = "Foo",
    LastName = "Bar",
};

if (p1 == p2)
{
    Console.WriteLine("Equal");
}

ChangeFirstName(p1);

var n1 = 42;
var n2 = 42;
if (n1 == n2)
{
    Console.WriteLine("Equal");
}

var v1 = new Vector2D { X = 1d, Y = 2d };
ChangeX(v1);
var v2 = v1;

if (v1 == v2)
{
    Console.WriteLine("The vectors are equal");
}

void ChangeX(Vector2D v)
{
    v.X = 3d;
}

void ChangeFirstName(Person p)
{
    p.FirstName = p.FirstName.ToUpper();
}

class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}

//struct Vector2D : IEquatable<Vector2D>
//{
//    public double X { get; set; }
//    public double Y { get; set; }

//    public bool Equals(Vector2D other) => X == other.X && Y == other.Y;

//    public static bool operator ==(Vector2D v1, Vector2D v2) => v1.Equals(v2);
//    public static bool operator !=(Vector2D v1, Vector2D v2) => !v1.Equals(v2);
//}

record struct Vector2D(double X, double Y);
