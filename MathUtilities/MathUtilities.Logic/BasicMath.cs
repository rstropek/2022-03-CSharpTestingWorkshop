namespace MathUtilities.Logic
{
    public static class BasicMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y) => x - y;

        public static int Div(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(y), "Value must not be 0");
            }

            return x / y;
        }
    }
}
