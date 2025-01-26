using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMineSweeper.Models
{
    public class Player
    {
        public int Row {  get; set; } = 0;
        public int Column { get; set; } = 0;
        public int Lives { get; set; } = 3;
        public int Moves { get; set; } = 0;
       
    }
}
