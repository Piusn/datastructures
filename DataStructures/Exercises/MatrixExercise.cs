using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Exercises
{
    public class MatrixExercise
    {
        #region Print a given matrix in spiral form
        //1    2   3   4
        //5    6   7   8
        //9   10  11  12
        //13  14  15  16

        //OUTPUT - 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10

        private static int[,] GetMatrix()
        {
            //int[,] input = new int[4, 4]
            //{
            //    {1 ,     2 ,   3 ,   4 },
            //    {5  ,    6 ,   7 ,   8 },
            //    {9  ,   10 ,  11 ,  12 },
            //    {13 ,   14 ,  15 ,  16 }
            //};
            int[,] input = new int[3, 6]
            {
                {1 ,  2  , 3,   4 , 5,   6 },
                {7 ,  8  , 9 , 10 , 11 , 12 },
                {13,  14 , 15 ,16 , 17 , 18 }
            };
            return input;
        }

        public static void PrintArrayInSpiral()
        {
            //1    2   3   4
            //5    6   7   8
            //9   10  11  12
            //13  14  15  16

            int[,] input = GetMatrix();

            int topRow = 0;
            int bottomRow = 3;

            int leftColumn = 0;
            int rightColumn = 3;

            int index = 0;

            while (leftColumn <= rightColumn && topRow <= bottomRow)
            {
                if (leftColumn == rightColumn)
                    break;

                //Move right
                while (index <= rightColumn)
                {
                    Console.Write($"{input[topRow, index]},");
                    index++;
                }

                if (topRow == bottomRow)
                    break;

                //Increment topRow
                topRow += 1;

                //Index will be at top row now
                index = topRow;

                //Move down
                while (index <= bottomRow)
                {
                    Console.Write($"{input[index, rightColumn]},");
                    index++;
                }

                if (leftColumn == rightColumn)
                    break;

                //right column shift left
                rightColumn--;
                index = rightColumn;

                while (index >= leftColumn)
                {
                    Console.Write($"{input[bottomRow, index]},");
                    index--;
                }

                if (topRow == bottomRow)
                    break;

                bottomRow--;
                index = bottomRow;

                while (index >= topRow)
                {
                    Console.Write($"{input[index, leftColumn]},");
                    index--;
                }

                leftColumn++;
                index = leftColumn;
            }
        }

        public static void PrintArrayInSpiralRecursive()
        {
            int[,] input = GetMatrix();

            PrintArrayInSpiralRecursiveHelper(input, 0, 2, 0, 5);
        }

        public static void PrintArrayInSpiralRecursiveHelper(int[,] matrix, int rowStart, int rowLength, int colStart, int colLength)
        {
            if (rowStart <= rowLength)
            {
                for (int i = rowStart; i <= colLength; i++)
                {
                    Console.Write(matrix[rowStart, i] + " ");
                }
            }

            for (int i = rowStart + 1; i <= rowLength; i++)
            {
                Console.Write(matrix[i, colLength] + " ");
            }

            if (rowStart + 1 <= rowLength)
            {
                for (int i = colLength - 1; i >= colStart; i--)
                {
                    Console.Write(matrix[rowLength, i] + " ");
                }
            }

            if (colStart + 1 <= colLength)
            {
                for (int i = rowLength - 1; i > rowStart; i--)
                {
                    Console.Write(matrix[i, colStart] + " ");
                }
            }

            if (rowStart + 1 <= rowLength - 1 && colStart + 1 <= colLength - 1)
            {
                PrintArrayInSpiralRecursiveHelper(matrix, rowStart + 1, rowLength - 1, colStart + 1, colLength - 1);
            }
        }

        #endregion
    }
}
