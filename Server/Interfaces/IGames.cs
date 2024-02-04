using LCPCollection.Shared.Classes;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface IGames
    {
        Task<ActionResult<IEnumerable<Games>>> GetGames();
        Task<ActionResult<IEnumerable<Games>>> GetGamesById(int? id);
        IActionResult GetGamesAsEnumList();
        Task<IActionResult> PutGames(int? id, Games Games);
        Task<ActionResult<Games>> PostGames(Games GamesData);
        Task<IActionResult> DeleteGames(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
