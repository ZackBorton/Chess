using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml.Linq;
using Models;
using Models.Pieces;

namespace ChessLogic
{
    /// <summary>
    /// 
    /// </summary>
    public class BoardLogic : IBoardLogic
    {
        /// <summary>
        ///     Setup the initial state of the board
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public Game BoardSetup(Game game)
        {
            var peice = new Piece
            {
                PieceName = PieceName.Rook,
                CurrentPosition = new Tuple<int, int>(8,8),
                StartingPosition = new Tuple<int, int>(8,8)
            };
            game.Board = new Board();
            game.Board.BlackPieces = new List<Piece>{
                new Piece
                {
                    PieceName = PieceName.Rook,
                    CurrentPosition = new Tuple<int, int>(8,0),
                    StartingPosition = new Tuple<int, int>(8,0)
                },
                new Piece
                {
                    PieceName = PieceName.Rook,
                    CurrentPosition = new Tuple<int, int>(8,0),
                    StartingPosition = new Tuple<int, int>(8,0)
                }};

           /* game.Board.WhitePieces.Add(new Piece
            {
                PieceName = PieceName.Rook,
                CurrentPosition = new int[0, 0],
                StartingPosition = new int[0, 0]
            });

            game.Board.WhitePieces.Add(new Piece
            {
                PieceName = PieceName.Rook,
                CurrentPosition = new int[0, 8],
                StartingPosition = new int[0, 8]
            });*/

            return game;
        }
    }
}