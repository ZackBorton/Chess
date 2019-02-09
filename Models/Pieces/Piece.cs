using System;

namespace Models.Pieces
{
    public class Piece
    {
        public PieceName PieceName { get; set; }
        public Tuple<int,int> StartingPosition { get; set; }
        public Tuple<int,int> CurrentPosition { get; set; }
    }
}