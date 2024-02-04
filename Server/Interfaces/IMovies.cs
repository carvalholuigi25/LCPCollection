using LCPCollection.Shared.Classes;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface IMovies
    {
        Task<ActionResult<IEnumerable<Movies>>> GetMovies();
        Task<ActionResult<IEnumerable<Movies>>> GetMoviesById(int? id);
        IActionResult GetMoviesAsEnumList();
        Task<IActionResult> PutMovies(int? id, Movies Movies);
        Task<ActionResult<Movies>> PostMovies(Movies MoviesData);
        Task<IActionResult> DeleteMovies(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
