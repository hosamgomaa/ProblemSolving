using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            
                char[,] test =  {{'5', '3', '.', '.', '7', '.', '.', '.', '.'}
                                ,{'6', '.', '.', '1', '9', '5', '.', '.', '.'}
                                ,{'1', '9', '8', '.', '.', '.', '.', '6', '.'}
                                ,{'8', '.', '.', '.', '6', '.', '.', '.', '3'}
                                ,{'4', '.', '.', '8', '.', '3', '.', '.', '1'}
                                ,{'7', '.', '.', '.', '2', '.', '.', '.', '6'}
                                ,{'.', '6', '.', '.', '.', '.', '2', '8', '.'}
                                ,{'.', '.', '.', '4', '1', '9', '.', '.', '5'}
                                ,{'.', '.', '.', '.', '8', '.', '.', '7', '9'} }; 
        



            Console.WriteLine(Sudoku.isCorrectSqurae(test));











        }
       
    }
}
