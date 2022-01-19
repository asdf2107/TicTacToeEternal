using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeEternal.CardTypeHandlers;

namespace TicTacToeEternal
{
    public class Board
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int[,] Field { get; private set; }
        public Player CurrentPlayer { get => _Players[_CurrentPlayerIndex]; }

        private List<Player> _Players = new();
        private int _CurrentPlayerIndex = 0;

        public Board(int width, int height)
        {
            Width = width; 
            Height = height;

            ResetBoard();
        }

        public void AddPlayer(Player player)
        {
            _Players.Add(player);
        }

        public bool TrySetCardByCurrnetPlayer(int x, int y, CardType cardType)
        {
            if (CurrentPlayer.GetCardMoves(cardType, Field).Contains((x, y)))
            {
                CurrentPlayer.SetCard(x, y, cardType, Field);
                NextPlayer();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void NextPlayer()
        {
            _CurrentPlayerIndex++;
            if (_CurrentPlayerIndex >= _Players.Count)
                _CurrentPlayerIndex = 0;
        }

        private void ResetBoard()
        {
            Field = new int[Width, Height];
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    sb.Append(Field[i, j] + " ");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
