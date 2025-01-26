using MiniMineSweeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMineSweeper.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private Random _randomNumber = new Random();
        public string GetChessNotation(int row, int column)
        {
            char file = (char)('A' + column); 
            int rank = 8 - row; 
            return $"{file}{rank}";
        }

        public void Initialize(Board board)
        {
            for (int row = 0; row < board.Rows; row++)
            {
                for (int column = 0; column < board.Columns; column++)
                {
                    board.Grid[row, column] = '.';
                }
            }
        }

        public bool IsMine(Board board, int row, int column)
        {
            return board.Grid[row, column] == '*';
        }

        public void SetMines(Board board, int mineCount)
        {
            for (int i = 0; i < mineCount; i++)
            {
                int randRow = 0;
                int randColumn = 0;
                do
                {
                    randRow = _randomNumber.Next(board.Rows);
                    randColumn = _randomNumber.Next(board.Columns);
                }
                while (board.Grid[randRow, randColumn] == '*' || (randRow == 0 && randColumn == 0));
                board.Grid[randRow, randColumn] = '*';
            }
        }

        public void showBoard(Player player, Board board)
        {
            Console.Clear();
            Console.WriteLine("Board:");
            for (int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    if (i == player.Row && j == player.Column)
                    {
                        Console.Write('P' + " ");
                    }
                    else
                    {
                        Console.Write(board.Grid[i, j] + " ");
                    }
                } Console.WriteLine();
            }
            Console.WriteLine("Lives: " + player.Lives + " Moves: " + player.Moves); 
            Console.WriteLine("Current Position: " + GetChessNotation(player.Row, player.Column));
        }
     }
}
