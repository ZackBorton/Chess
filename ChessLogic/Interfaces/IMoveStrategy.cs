using Models.Pieces;

namespace ChessLogic
{
    public interface IMoveStrategy
    {
        Piece Move(Piece piece);
    }
}