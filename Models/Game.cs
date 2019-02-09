using System;

namespace Models
{
    /// <summary>
    ///     Stores information around the game
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Defaults to white for the first turn
        /// </summary>
        public Player PlayersTurn { get; set; } = Player.White;

        /// <summary>
        ///     The choice of which player the user chooses to play as
        /// </summary>
        public Player PlayersChoice { get; set; }

        /// <summary>
        ///     Defaults to next turn and will stay that until a phase of check or checkmate occurs
        /// </summary>
        public GamePhase GamePhase { get; set; } = GamePhase.NextTurn;

        /// <summary>
        ///     
        /// </summary>
        public Board Board { get; set; }
    }
}