namespace MathUtilities.Logic
{
    public static class BasicMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y) => x - y;

        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(y));
            }

            return x / y;
        }
    }
}
