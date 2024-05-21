using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame.Boards;
using TicTacToeGame.Players;

namespace TicTacToeGame.Games
{
    public class Game
    {
        Board _board;
        Player _player1;
        Player _player2;
        public Game(Board board,Player player1, Player player2) { 
            _board= board;
            _player1= player1;
            _player2 = player2;
        }
        public void StartGame()
        {
            bool isEmptyCellLeft = _board.isEmptyCellLeft();
            int i = 0;
            while (isEmptyCellLeft)
            {
                int player;
                if (i % 2 == 0) player = 1;
                else player = 2;
                Console.WriteLine($"Player {player} enter cell");
                string input = Console.ReadLine();
                // Parse the input string
                string[] parts = input.Split(',');
      
                if (parts.Length == 2 && int.TryParse(parts[0], out int x) && int.TryParse(parts[1], out int y) )
                {
                    if(!_board.validValue(x, y) != "." || _board.getValue(x,y) !=".")
                    {
                        Console.WriteLine("Invalid Value");
                        continue;
                    }
                    _board.setValue(x, y, _player1.piece);

                    // Print the updated board
                    Console.WriteLine("The board:");
                    _board.printBoard();
                    int result = isGameOver();
                    if(result)
                    {
                        Console.WriteLine("Game Over");
                        printResult(result);
                        break;
                    }
                }
                isEmptyCellLeft = _board.isEmptyCellLeft();
            }
        }
    }
}
