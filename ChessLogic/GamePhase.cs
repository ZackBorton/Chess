using System;
using System.Runtime.CompilerServices;
using Models;

namespace ChessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public class GamePhase : IGamePhase
    {
        private readonly IBoardLogic _boardLogic;
        public GamePhase(IBoardLogic boardLogic)
        {
            _boardLogic = boardLogic;
        }

        /// <summary>
        ///     A player chooses their color and is returned a game with the starting point of the game
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public Game StartGame(Player player)
        {
            Game game = new Game();
            _boardLogic.BoardSetup(game);
            game.PlayersChoice = player;
            return game;
        }
    }
}