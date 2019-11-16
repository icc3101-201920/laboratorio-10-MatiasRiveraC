using Laboratorio_9_OOP_201920.Cards;
using System;

namespace Laboratorio_9_OOP_201920
{
    public class PlayerEventArgs:EventArgs
    {
        public Card Card { get; set; }
        public Player Player { get; set; }
    }
}
