using Models;
using Models.Pieces;

namespace ChessLogic
{
    public interface IMoveContext
    {
        Piece Move(Piece piece);
    }
}