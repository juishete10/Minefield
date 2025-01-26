using MiniMineSweeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMineSweeper.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public void Move(string direction, Board board, Player player)
        {
            switch (direction) 
            { 
                case "up":
                    if (player.Row > 0) player.Row--; 
                    break; 
                case "down": 
                    if (player.Row < board.Rows - 1) player.Row++;
                    break; 
                case "left":
                    if (player.Column > 0) player.Column--; 
                    break; 
                case "right": 
                    if (player.Column < board.Columns - 1) player.Column++;
                    break; 
                default: Console.WriteLine("Invalid move. Try again."); 
                    break; 
            }
        }
    }
}
