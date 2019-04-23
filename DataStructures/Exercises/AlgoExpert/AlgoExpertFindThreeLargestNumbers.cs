namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertFindThreeLargestNumbers
    {
        public AlgoExpertFindThreeLargestNumbers()
        {
            var results = FindThreeLargestNumbers(new[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 });
        }

        public int[] FindThreeLargestNumbers(int[] arr)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < arr.Length; i++)
            {
                Shift(numbers, arr[i]);
            }

            return numbers;
        }

        public void Shift(int[] numbers, int num)
        {
            if (numbers[2] < num)
            {
                ShiftAndUpdate(numbers, 2, num);
            }
            else if (numbers[1] < num)
                ShiftAndUpdate(numbers, 1, num);
            else if (numbers[0] < num)
                ShiftAndUpdate(numbers, 0, num);
        }

        public void ShiftAndUpdate(int[] numbers, int idx, int num)
        {
            for (int i = 0; i <= idx; i++)
            {
                if (i == idx)
                {
                    numbers[i] = num;
                }
                else
                    numbers[i] = numbers[i + 1];
            }
        }
    }
}