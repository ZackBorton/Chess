using System.Collections.Generic;
using ChessLogic.Strategies;
using Models;
using Models.Pieces;

namespace ChessLogic
{
    /// <summary>
    ///     Uses the strategy pattern to determine how a piece should move
    ///     different pieces can have unique movements properties etc
    /// </summary>
    public class MoveContext : IMoveContext
    {
        public Piece Move(Piece piece)
        {  
            Dictionary<PieceName, IMoveStrategy> strategies = new Dictionary<PieceName, IMoveStrategy>() {
                { PieceName.King , new KingStrategy() },
                { PieceName.Rook , new RookStrategy() }
            };

            IMoveStrategy selectedStrategy = strategies[piece.PieceName];
            return selectedStrategy.Move(piece);
        }
    }
}