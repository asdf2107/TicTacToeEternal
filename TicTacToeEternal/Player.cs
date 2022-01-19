using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeEternal.CardTypeHandlers;

namespace TicTacToeEternal
{
    public class Player
    {
        public int Id { get; private set; }

        private Dictionary<CardType, CardTypeHandler> _CardTypeHandlers;

        public Player(int id)
        {
            if (id < 1) throw new ArgumentOutOfRangeException(nameof(id));
            Id = id;

            _CardTypeHandlers = new()
            {
                { CardType.PlayersCard, new PlayersCardTypeHandler(this) },
            };
        }

        public IEnumerable<(int, int)> GetCardMoves(CardType cardType, int[,] field)
        {
            return _CardTypeHandlers[cardType].GetAvailableMoves(field);
        }

        public void SetCard(int x, int y, CardType cardType, int[,] field)
        {
            _CardTypeHandlers[cardType].PerformMove(x, y, field);
        }
    }
}
