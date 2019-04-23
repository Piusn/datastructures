using System.Collections.Generic;

namespace DataStructures.Exercises.AlgoExpert
{
    public class AlgoExpertDiskStack
    {
        public AlgoExpertDiskStack()
        {
            //List<int[]> input = new List<int[]>()
            //                   {
            //                       new []{1, 2, 1},
            //                       new []{2, 1, 2},
            //                       new []{3, 2, 3},
            //                       new []{2, 3, 4},
            //                       new []{4, 4, 5 },
            //                       new []{2, 2, 8},
            //                       new []{2, 3, 11},
            //                   };

            List<int[]> input = new List<int[]>()
                                {
                                    new []{2,2,1},
                                    new []{2, 1, 2},
                                    new []{3, 2, 3},
                                    new []{2, 3, 4},
                                    new []{4, 4, 5 },
                                    new []{2, 2, 8}
                                };

            //heights = [1,2,3,4,5,8]

            Stack(input);
        }

        public void Stack(List<int[]> input)
        {
            int[] heights = new int[input.Count];
            int index = 0;

            foreach (var intse in input)
            {
                heights[index] = intse[2];
                index++;
            }

            var arr = input.ToArray();

            for (int i = 1; i < arr.Length; i++)
            {
                var currentDisk = arr[i];

                for (int j = 0; j < i; j++)
                {
                    var otherDisk = arr[j];

                    if (otherDisk[0] < currentDisk[0] && otherDisk[1] < currentDisk[1] && otherDisk[2] < currentDisk[2])
                    {
                        if (heights[i] <= heights[j] + currentDisk[2])
                            heights[i] = heights[j] + currentDisk[2];
                    }
                }
            }
        }
    }
}