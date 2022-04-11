namespace DistributedSystemBasics.WebApi
{
    public interface IMathUtilities
    {
        int Add(int x, int y);
    }

    public class MathUtilities : IMathUtilities
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
