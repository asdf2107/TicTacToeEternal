using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeEternal.CardTypeHandlers
{
    public abstract class CardTypeHandler
    {
        public Player Player { get; protected set; }

        public CardTypeHandler(Player player)
        {
            Player = player;
        }

        public abstract IEnumerable<(int, int)> GetAvailableMoves(short[,] field);
        public abstract void PerformMove(int x, int y, short[,] field);
    }
}
