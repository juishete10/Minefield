using MiniMineSweeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMineSweeper.Repositories
{
    public interface IBoardRepository
    {
        void Initialize(Board board);
        void showBoard(Player player, Board board);
        void SetMines(Board board, int mineCount);
        Boolean IsMine(Board board, int row, int column);
        string GetChessNotation(int row, int column);

    }
}
