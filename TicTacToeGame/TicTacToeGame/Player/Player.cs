using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame.Players;
using TicTacToeGame.Pieces; 

namespace TicTacToeGame.Players
{
    public class Player
    {
        public Piece piece;
        public Player(Piece piece)
        {
            this.piece = piece;
        }
    }
}