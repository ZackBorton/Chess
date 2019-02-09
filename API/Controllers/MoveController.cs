using ChessLogic;
using Microsoft.AspNetCore.Mvc;
using Models.Pieces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class MoveController: Controller
    {
        private readonly IMoveContext _moveContext;

        /// <summary>
        ///     Constructor injection
        /// </summary>
        /// <param name="sorting"></param>
        public MoveController(IMoveContext moveContext, IBoardLogic boardLogic, IGamePhase gamePhase)
        {
            _moveContext = moveContext;
        }
        
        [HttpGet]
        [Route("Move")]
        [ProducesResponseType(200)]       
        public IActionResult Move(Piece piece)
        {
            return Ok(_moveContext.Move(piece));
        }   
    }
}