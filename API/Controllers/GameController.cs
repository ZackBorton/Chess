using ChessLogic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class GameController: Controller
    {
        private readonly IMoveContext _moveContext;
        private readonly IBoardLogic _boardLogic;
        private readonly IGamePhase _gamePhase;
        
        /// <summary>
        ///     Constructor injection
        /// </summary>
        /// <param name="sorting"></param>
        public GameController(IMoveContext moveContext, IBoardLogic boardLogic, IGamePhase gamePhase)
        {
            _moveContext = moveContext;
            _boardLogic = boardLogic;
            _gamePhase = gamePhase;

        }
        
        [HttpGet]
        [Route("StartGame")]
        [ProducesResponseType(200)]       
        public IActionResult StartGame(Player player)
        {
            return Ok(_gamePhase.StartGame(player));
        }
    }
}