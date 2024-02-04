using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimesController : ControllerBase
    {
        private readonly IAnimes _animes;

        public AnimesController(IAnimes animes)
        {
            _animes = animes;
        }

        /// <summary>
        /// This endpoint retrives all animes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animes>>> GetAnimes()
        {
            return await _animes.GetAnimes();
        }

        /// <summary>
        /// This endpoint retrives specific anime by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Animes>>> GetAnimesById(int? id)
        {
            return await _animes.GetAnimesById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of animes for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetAnimesAsEnumList()
        {
            return _animes.GetAnimesAsEnumList();
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
        /// This endpoint updates specific anime by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Animes"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimes(int? id, Animes Animes)
        {
            return await _animes.PutAnimes(id, Animes);
        }

        /// <summary>
        /// This endpoint creates specific anime by body.
        /// </summary>
        /// <param name="Animes"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Animes>> PostAnimes(Animes Animes)
        {
            return await _animes.PostAnimes(Animes);
        }

        /// <summary>
        /// This endpoint deletes a specific anime by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimes(int? id)
        {
            return await _animes.DeleteAnimes(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table animes.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _animes.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchAnimes([FromQuery] QueryParams qryp)
        {
            return await _animes.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table animes.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _animes.GetLastId();
        }
    }
}
