using MiniMineSweeper.Models;
using MiniMineSweeper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MiniMineSweeper.Services
{
    internal class GameService
    {
        private Player _player;
        private Board _board;
        private IBoardRepository _boardRepository;
        private IPlayerRepository _playerRepository;

        public GameService()
        {
            _board = new Board(8, 8);
            _player = new Player();
            _boardRepository = new BoardRepository();
            _playerRepository = new PlayerRepository();
        }

        public void GameStart()
        {
            _boardRepository.Initialize(_board);
            _boardRepository.SetMines(_board, 10); 
            _boardRepository.showBoard(_player, _board);

            while(_player.Lives > 0 && _player.Row < _board.Rows -1)
            {
                Console.Write("Enter move (up, down, left, right): ");

                string move = Console.ReadLine().ToLower();

                _playerRepository.Move(move, _board, _player);
                _boardRepository.showBoard(_player, _board); 

                if (_boardRepository.IsMine(_board, _player.Row, _player.Column)) 
                { 
                    _player.Lives--; Console.WriteLine("Boom! You hit a mine. Lives remaining: " + _player.Lives); 
                }
                _player.Moves++;
            }

            if (_player.Lives > 0) 
            { 
                Console.WriteLine("Congratulations! You reached the other side in " + _player.Moves + " moves."); 
            } 
            else 
            { 
                Console.WriteLine("Game Over! You ran out of lives."); 
            }
        }
    }
}
