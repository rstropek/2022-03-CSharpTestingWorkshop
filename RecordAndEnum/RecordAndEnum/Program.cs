var p = new Point3d(1d, 2d, 3d);
//var p2 = new Point3d(p.X, p.Y, p.Z + 5d);
var p2 = p with { Z = p.Z + 5d }; // Kopie
var p3 = new Point3d(p.X, p.Y, p.Z);
if (p == p3)
{
    Console.WriteLine("Equal");
}

p.Print();

//var x = p3.X;
//var y = p3.Y;
//var z = p3.Z;
var (x, y, z) = p3; // Dekonstruktion

var c = Enum.Parse<Color>("Red");

record Point3d(double X, double Y, double Z)
{
    public Point3d() : this(0d, 0d, 0d) { }

    public void Print()
    {
        Console.WriteLine($"{X}/{Y}/{Z}");
    }
}

//class Point3d
//{
//    public Point3d(double x, double y, double z)
//    {
//        X = x;
//        Y = y;
//        Z = z;
//    }

//    public double X { get; private set; }
//    public double Y { get; private set; }
//    public double Z { get; private set; }
//}

enum Color
{
    Red,
    Blue,
    Green,
    Aqua,
    Lime,
}

enum OpenMode
{
    Read = 1,
    Write = 2,
    ReadWrite = Read | Write,
}

enum OpenMode2
{
    Read = 'r',
    Write = 'w',
    Execute = 'x',
}
