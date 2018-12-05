using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BacktrackingCharacterMatrix
    {
        //| M | S | E | F
        //| R | A | T | D
        //| L | O | N | E
        //| K | A | F | B

        //FIND - START, NOTE ,  SAND, STONED

        //Use a matrix
        //at any index [row,column]move
        //              west         (row     ,  column - 1 ),
        //              east         (row     ,  column + 1 ),
        //              north,       (row - 1 ,  column     )
        //              south,       (row + 1 ,  column + 1 )

        //              north-west,  (row - 1 ,  column - 1 )
        //              north-east,  (row - 1 ,  column + 1 )
        //              south-east,  (row + 1 ,  column + 1 )
        //              south-west   (row + 1 ,  column - 1 )

        public static char[,] GetMatrix()
        {
            char[,] matrix = new char[4, 4];

            matrix[0, 0] = 'M';
            matrix[0, 1] = 'S';
            matrix[0, 2] = 'E';
            matrix[0, 3] = 'F';

            matrix[1, 0] = 'R';
            matrix[1, 1] = 'A';
            matrix[1, 2] = 'T';
            matrix[1, 3] = 'D';

            matrix[2, 0] = 'L';
            matrix[2, 1] = 'O';
            matrix[2, 2] = 'N';
            matrix[2, 3] = 'E';

            matrix[3, 0] = 'K';
            matrix[3, 1] = 'A';
            matrix[3, 2] = 'F';
            matrix[3, 3] = 'B';

            return matrix;
        }

        public static bool FindWordHelper(char[,] matrix, int row, int column, ref int startRow, ref int startColumn, char characterToFind, bool[,] processed, bool isSecondLetter)
        {
            if (isSecondLetter && (row - startRow > 1 || column - startColumn > 1))
            {
                return false;
            }
            else if (char.IsWhiteSpace(characterToFind) || row < 0 || column < 0 || column > 3 || row > 3 || processed[row, column])
                return false;
            else
            {
                var characterFound = matrix[row, column];

                processed[row, column] = true;

                //Console.WriteLine($"Finding Character- {characterToFind} found on row - {row} column - {column}");
                if (characterToFind == characterFound)
                {
                    startColumn = column;
                    startRow = row;                    
                    return true;
                }

                var isFound = FindWordHelper(matrix, row, column - 1, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter) ||  //Go west               
                FindWordHelper(matrix, row, column + 1, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter) ||                //Go East              
                FindWordHelper(matrix, row + 1, column, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter) ||                //Go South                
                FindWordHelper(matrix, row - 1, column, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter) ||                //Go North                
                FindWordHelper(matrix, row - 1, column - 1, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter) ||            //Go North-West              
                FindWordHelper(matrix, row - 1, column + 1, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter) ||            //Go North-East             
                FindWordHelper(matrix, row + 1, column - 1, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter) ||            //Go South-West              
                FindWordHelper(matrix, row + 1, column + 1, ref startRow, ref startColumn, characterToFind, processed, isSecondLetter);              //Go South-East

                return isFound;
            }
        }

        public static void FindWord(string dictionaryWordToFind)
        {
            var matrix = GetMatrix();
            int startColumn = 0, startRow = 0;

            //Find NOTE          
            for (int i = 0; i < dictionaryWordToFind.Length; i++)
            {
                var processed = new bool[4, 4];

                int row = startRow, column = startColumn;

                var character = dictionaryWordToFind[i];

                var characterFound = FindWordHelper(matrix, row, column, ref startRow, ref startColumn, character, processed, i > 0)
 ;
                if(!characterFound)
                {
                    Console.WriteLine($"{dictionaryWordToFind} -NOT FOUND");
                    break;
                }
                if(i == dictionaryWordToFind.Length - 1)
                {
                    Console.WriteLine($"{dictionaryWordToFind} - FOUND");
                }
            }

        }
    }
}
