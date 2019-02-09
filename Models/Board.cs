using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ChessLogic;
using Models.Pieces;

namespace Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Board
    {
        public BoardDimension BoardDimesion { get; set; } 

        public List<Piece> WhitePieces { get; set; }        
        public List<Piece> BlackPieces { get; set; }
    }
}