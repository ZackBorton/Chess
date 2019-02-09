using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            game.Board = new Board();
            // TODO: Store this in database
            game.Board.BoardDimension = new BoardDimension();
            game.Board.BlackPieces = new List<Piece>{
                new Piece
                {
                    ID = new Guid(),
                    PieceName = PieceName.Rook,
                    Position = new List<Tuple<int, int>>()
                    { 
                        new Tuple<int, int>(8,8)
                    }
                },
                new Piece
                {
                    ID = new Guid(),
                    PieceName = PieceName.Rook,
                    Position = new List<Tuple<int, int>>()
                    { 
                        new Tuple<int, int>(8,0)
                    }
                }
                
            };

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