using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGames _games;

        public GamesController(IGames games)
        {
            _games = games;
        }

        /// <summary>
        /// This endpoint retrives all games.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Games>>> GetGames()
        {
            return await _games.GetGames();
        }

        /// <summary>
        /// This endpoint retrives specific game by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Games>>> GetGamesById(int? id)
        {
            return await _games.GetGamesById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of games for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetGamesAsEnumList()
        {
            return _games.GetGamesAsEnumList();
        }

        /// <summary>
        /// This endpoint retrives list of enums of filter operation for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("fopenumslist")]
        public IActionResult GetFilterOperationEnumList()
        {
            return Ok(Enum.GetNames(typeof(FilterOperatorEnum)));
        }

        /// <summary>
        /// This endpoint updates specific game by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Games"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGames(int? id, Games Games)
        {
            return await _games.PutGames(id, Games);
        }

        /// <summary>
        /// This endpoint creates specific game by body.
        /// </summary>
        /// <param name="Games"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Games>> PostGames(Games Games)
        {
            return await _games.PostGames(Games);
        }

        /// <summary>
        /// This endpoint deletes a specific game by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGames(int? id)
        {
            return await _games.DeleteGames(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table games.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _games.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchGames([FromQuery] QueryParams qryp)
        {
            return await _games.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table games.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _games.GetLastId();
        }
    }
}
