namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertPalandromeCheck
    {
        public static bool IsParandrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;

            bool isParandrome = false;

            while (left <= right)
            {
                var leftChar = input[left];
                var rightChar = input[right];

                if (leftChar != rightChar)
                {
                    isParandrome = false;
                    break;
                }
                left++;
                right--;

                if (left == right)
                    isParandrome = true;
            }

            return isParandrome;
        }
    }
}