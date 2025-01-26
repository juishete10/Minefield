using MiniMineSweeper.Services;

namespace MiniMineSweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mine Sweeper Game");
            GameService gameService = new GameService();
            gameService.GameStart();
        }
    }
}
