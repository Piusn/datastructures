using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertMinHeap
    {
        private static int[] arr = new[] { 48, 12, 24, 7, 8, -5, 24, 391, 24, 56, 2, 6, -5, 8, 41, 5697 };

        public AlgoExpertMinHeap()
        {
            BuildHeap(arr, arr.Length - 1);
        }

        public static void BuildHeap(int[] input, int endIdex)
        {
            var mid = endIdex / 2;

            while (mid >= 0)
            {
                SiftDown(mid, endIdex, input);
                mid--;
            }
        }

        public List<int> Remove()
        {
            List<int> sorted = new List<int>();
            int endIdx = arr.Length - 1;

            while (endIdx >= 0)
            {
                var temp = arr[0];
                arr[0] = arr[endIdx];
                arr[endIdx] = temp;

                sorted.Add(arr[endIdx]);
                endIdx -= 1;

                BuildHeap(arr, endIdx);
            }

            return sorted;
        }

        private static void SiftUp(int currentIndex, int[] input)
        {
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && input[currentIndex] < input[parentIndex])
            {
                Swap(currentIndex, parentIndex, input);
                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        private static void SiftDown(int currentIndex, int endIdx, int[] input)
        {
            var leftValue = GetLeftIndex(currentIndex, endIdx);

            while (leftValue <= endIdx && leftValue >= 0)
            {
                int idToSwap = leftValue;

                var rightValue = GetRightIndex(currentIndex, endIdx);

                if (rightValue != -1 && input[rightValue] < input[leftValue])
                {
                    idToSwap = rightValue;
                }

                if (input[idToSwap] < input[currentIndex])
                {
                    Swap(idToSwap, currentIndex, input);
                    currentIndex = idToSwap;
                    leftValue = GetLeftIndex(currentIndex, endIdx);
                }
                else
                {
                    break;
                }
            }
        }

        private static int GetLeftIndex(int index, int endIdx)
        {
            var leftIndex = index * 2 + 1;

            return leftIndex > endIdx ? -1 : leftIndex;
        }

        private static int GetRightIndex(int index, int endIdx)
        {
            var rightIndex = index * 2 + 2;

            return rightIndex > endIdx ? -1 : rightIndex;
        }

        private static int GetParentIndex(int index) => index - 1 / 2;

        private static void Swap(int left, int right, int[] input)
        {
            var temp = input[left];
            input[left] = input[right];
            input[right] = temp;
        }
    }
}