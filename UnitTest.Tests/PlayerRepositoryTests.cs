using MiniMineSweeper.Models;
using MiniMineSweeper.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    public class PlayerRepositoryTests
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly Player _player;
        private readonly Board _board;

        public PlayerRepositoryTests()
        {
            _board = new Board(8, 8);
            _playerRepository = new PlayerRepository();
            _player = new Player();
        }

        [Theory]
        [InlineData("up", 0, 0)]
        [InlineData("down", 1, 0)]
        [InlineData("left", 0, 0)]
        [InlineData("right", 0, 1)]
        public void MovePlayer_ShouldUpdatePlayerPosition(string direction, int expectedRow, int expectedCol)
        {
            // Act
            _playerRepository.Move(direction, _board, _player);

            // Assert
            Assert.Equal(expectedRow, _player.Row);
            Assert.Equal(expectedCol, _player.Column);
        }
    }
}
