using Models;

namespace ChessLogic
{
    public interface IGamePhase
    {
        Game StartGame(Player player);
    }
}