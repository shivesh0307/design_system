using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Boards
{
    public class Board
    {
        int n;
        public char[,] _board { get; private set; }

        public Board(int n)
        {
            this.n = n;
            _board = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _board[i, j] = '.'; // Example initialization
                }
            }

        }
        public bool isEmptyCellLeft()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(_board[i, j] == '.')
                        return true;
                }
            }
            return false;
        }
    }
}
