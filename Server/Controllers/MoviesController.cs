using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovies _movies;

        public MoviesController(IMovies movies)
        {
            _movies = movies;
        }

        /// <summary>
        /// This endpoint retrives all movies.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movies>>> GetMovies()
        {
            return await _movies.GetMovies();
        }

        /// <summary>
        /// This endpoint retrives specific movie by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Movies>>> GetMoviesById(int? id)
        {
            return await _movies.GetMoviesById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of movies for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetMoviesAsEnumList()
        {
            return _movies.GetMoviesAsEnumList();
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
        /// This endpoint updates specific movie by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Movies"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovies(int? id, Movies Movies)
        {
            return await _movies.PutMovies(id, Movies);
        }

        /// <summary>
        /// This endpoint creates specific movie by body.
        /// </summary>
        /// <param name="Movies"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Movies>> PostMovies(Movies Movies)
        {
            return await _movies.PostMovies(Movies);
        }

        /// <summary>
        /// This endpoint deletes a specific movie by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovies(int? id)
        {
            return await _movies.DeleteMovies(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table movies.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _movies.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchMovies([FromQuery] QueryParams qryp)
        {
            return await _movies.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table movies.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _movies.GetLastId();
        }
    }
}
