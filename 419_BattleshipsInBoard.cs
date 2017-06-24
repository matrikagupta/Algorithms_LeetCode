using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _419_BattleshipsInBoard
        {


        public int CountBattleships(char[,] board)
            {
            
           
            
            int count = 0;
            for (int i = 0; i < board.GetLength(0); i++)
                {
                for (int j = 0; j < board.GetLength(1); j++)
                    {
                    if (i != 0 && board[i,j] == 'X' && board[i - 1,j] == 'X') continue;
                    if (j != 0 && board[i,j] == 'X' && board[i,j - 1] == 'X') continue;
                    if (board[i,j] == 'X') count++;
                    }
                }
            return count;
            }

      

        //public static void Main()
        //    {
        //    _419_BattleshipsInBoard obj = new _419_BattleshipsInBoard();
        //    char[,] grid = new char[,] { { 'X', '.', '.', 'X' },
        //                               { '.', '.', '.', 'X' },
        //                               { '.', '.', '.', 'X' } };
        //    obj.CountBattleships(grid);

        //    }
        }
    }
