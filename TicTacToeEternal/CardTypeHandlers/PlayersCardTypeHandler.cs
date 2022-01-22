using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeEternal.CardTypeHandlers
{
    public class PlayersCardTypeHandler : CardTypeHandler
    {
        public PlayersCardTypeHandler(Player player) : base(player) { }

        public override IEnumerable<(int, int)> GetAvailableMoves(short[,] field)
        {
            List<(int, int)> result = new();

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 0) result.Add((i, j));
                }
            }

            return result;
        }

        public override void PerformMove(int x, int y, short[,] field)
        {
            field[x, y] = Player.Id;
        }
    }
}
