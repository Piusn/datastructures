using System;

namespace DataStructures.Exercises
{
    public class PowerOfNumber
    {
        public static double Power(int value, int power)
        {
            if (power == 0)
                return 1;

            double result = 1;

            var abs = Math.Abs(power);

            for (int i = 0; i < abs; i++)
            {
                result *= value;
            }

            if (power < 0)
            {
                return 1 / result;
            }

            return result;
        }
    }
}