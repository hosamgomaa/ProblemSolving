using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Sudoku
    {
     public static bool isCorrectRow(char[,] board)
        {

            for (int i = 0; i < 9; i++)
            {
                bool[] row_set = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    int val = board[i,j] - '0';
                    if(board[i,j]!='.')
                    { 
                        if (row_set[val - 1])
                            return false;
                        row_set[val - 1] = true;
                    }
                }
            }
            return true;
        }
        public static bool isCorrectCol(char[,] board)
        {

            for (int i = 0; i < 9; i++)
            {
                bool[] row_set = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    int val = board[j, i] - '0';
                    if (board[j, i] != '.')
                    {
                        if (row_set[val - 1])
                            return false;
                        row_set[val - 1] = true;
                    }
                }
            }
            return true;
        }
        public static bool isCorrectSqurae(char[,] board)
        {

            for (int i = 0; i < 9; i++)
            {
                bool[] row_set = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    int val = board[j/3, j%3] - '0';
                    if (board[j / 3, j % 3] != '.')
                    {
                        if (row_set[val - 1])
                            return false;
                        row_set[val - 1] = true;
                    }
                }
            }
            return true;
        }
    }
}
