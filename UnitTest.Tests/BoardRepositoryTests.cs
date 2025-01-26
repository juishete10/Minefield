using MiniMineSweeper.Models;
using MiniMineSweeper.Repositories;

namespace UnitTest.Tests
{
    public class BoardRepositoryTests
    {
        private readonly IBoardRepository _boardRepository;
        private readonly Board _board;

        public BoardRepositoryTests()
        {
            _boardRepository = new BoardRepository();
            _board = new Board(8,8);
        }
        [Fact]
        public void Initialize_ShouldetUpBoardWithCorrectChar()
        {
            //Act
            _boardRepository.Initialize(_board);

            //Assert
            for(int i = 0;i< _board.Rows; i++)
            {
                for(int j=0; j < _board.Columns; j++)
                {
                    Assert.Equal('.', _board.Grid[i, j]);
                }
            }
        }

        [Fact]
        public void SetMines_ShouldPlaceCorrectNumberOfMine()
        {
            //Arrange
            int minesCount = 0;
            int numberOfMines = 10;

            //Act
            _boardRepository.SetMines(_board, numberOfMines);

            //Assert
            for (int i = 0; i < _board.Rows; i++)
            {
                for (int j = 0; j < _board.Columns; j++)
                {
                    if (_board.Grid[i,j] == '*')
                    {
                        minesCount++;
                    }
                }
            }
            Assert.Equal(numberOfMines, minesCount);
        }

        [Fact]
        public void IsMine_ShouldRetunrTrueforMineExist()
        {
            //Arrange
            _boardRepository.Initialize(_board);
            _board.Grid[0, 1] = '*';

            //Act
            var result = _boardRepository.IsMine(_board, 0, 1);

            //Assert
            Assert.True(result);
        }
    }
}