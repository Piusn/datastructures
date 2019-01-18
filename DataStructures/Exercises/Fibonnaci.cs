namespace DataStructures.Exercises
{
    public class Fibonnaci
    {
        public static int Fib(int n)
        {
            if (n == 0)
                return 1;
            else if (n == 1)
                return n;
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
