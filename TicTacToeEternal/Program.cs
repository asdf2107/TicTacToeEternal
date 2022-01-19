using System;

namespace TicTacToeEternal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(6, 6);
            Player p1 = new Player(1);
            Player p2 = new Player(2);
            board.AddPlayer(p1);
            board.AddPlayer(p2);
            while (true)
            {
                Console.WriteLine(board.ToString());
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                board.TrySetCardByCurrnetPlayer(int.Parse(parts[0]), int.Parse(parts[1]), CardType.PlayersCard);
            }
        }
    }
}
