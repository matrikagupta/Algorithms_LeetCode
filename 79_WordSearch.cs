using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
    {
    class _79_WordSearch
        {
        public bool Exist(char[,] board, string word)
            {
            if (board == null || board.GetLength(0) == 0 || board.GetLength(1) == 0)
                return false;
            if (string.IsNullOrEmpty(word))
                return true;
            for (int i = 0; i < board.GetLength(0); i++)
                for (int j = 0; j < board.GetLength(1); j++)
                    {
                    if (Helper(board, i, j, word, 0, new bool[board.GetLength(0), board.GetLength(1)]))
                        return true;
                    }
            return false;
            }

        private bool Helper(char[,] board, int m, int n, string word, int index, bool[,] visited)
            {
            if (index == word.Length)
                {
                return true;
                }
            if (m < 0 || m >= board.GetLength(0) || n < 0 || n >= board.GetLength(1) || visited[m, n] || word[index] != board[m, n])
                {
                return false;
                }
            visited[m, n] = true;
            if (Helper(board, m, n + 1, word, index + 1, visited) || Helper(board, m, n - 1, word, index + 1, visited)
            || Helper(board, m + 1, n, word, index + 1, visited) || Helper(board, m - 1, n, word, index + 1, visited))
                {
                return true;
                }
            else
                {
                visited[m, n] = false;
                return false;
                }
            }

        //public static void Main()
        //    {
        //    _79_WordSearch s = new _79_WordSearch();
        //    char[,] grid = new char[,] { { 'A','B','C','E' },
        //                                 { 'S','F','C','S'},
        //                                { 'A','D','E','E' } };
        //    // 31
        //    //42
        //    s.Exist(grid, "ABCCED");
        //    }
        }
    }
