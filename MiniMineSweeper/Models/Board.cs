using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMineSweeper.Models
{
    public class Board
    {
        public char[,] Grid;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Grid = new char[Rows, Columns];
        }

    }
}
