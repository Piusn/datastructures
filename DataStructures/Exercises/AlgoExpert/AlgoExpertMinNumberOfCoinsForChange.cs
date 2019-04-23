using System;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertMinNumberOfCoinsForChange
    {
        public AlgoExpertMinNumberOfCoinsForChange()
        {
            var numberOfCoins = Find(new[] {1, 5, 10}, 7);
        }
        public int Find(int[] denominations, int target)
        {
            var numOfCoins = new int[target + 1];

            for (int i = 0; i <= target; i++)
            {
                numOfCoins[i] = int.MaxValue;
            }

            numOfCoins[0] = 0;

            for (int denomination = 0; denomination < denominations.Length; denomination++)
            {
                for (int amount = 0; amount < numOfCoins.Length; amount++)
                {
                    if (denominations[denomination] <= amount)
                        numOfCoins[amount] = Math.Min(numOfCoins[amount], 1 + numOfCoins[amount - denominations[denomination]]);
                }
            }

            return numOfCoins[target];
        }
    }
}