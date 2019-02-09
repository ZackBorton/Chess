using System;
using System.Collections.Generic;

namespace Models.Pieces
{
    public class Piece
    {
        public Guid ID { get; set; }
        public PieceName PieceName { get; set; }

        public List<Tuple<int,int>> Position { get; set; }
    }
}