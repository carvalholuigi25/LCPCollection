using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVSeriesController : ControllerBase
    {
        private readonly ITVSeries _tvseries;

        public TVSeriesController(ITVSeries tvseries)
        {
            _tvseries = tvseries;
        }

        /// <summary>
        /// This endpoint retrives all tvseries.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TVSeries>>> GetTVSeries()
        {
            return await _tvseries.GetTVSeries();
        }

        /// <summary>
        /// This endpoint retrives specific tvserie by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TVSeries>>> GetTVSeriesById(int? id)
        {
            return await _tvseries.GetTVSeriesById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of tvseries for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetTVSeriesAsEnumList()
        {
            return _tvseries.GetTVSeriesAsEnumList();
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
        /// This endpoint updates specific tvserie by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="TVSeries"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTVSeries(int? id, TVSeries TVSeries)
        {
            return await _tvseries.PutTVSeries(id, TVSeries);
        }

        /// <summary>
        /// This endpoint creates specific tvserie by body.
        /// </summary>
        /// <param name="TVSeries"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<TVSeries>> PostTVSeries(TVSeries TVSeries)
        {
            return await _tvseries.PostTVSeries(TVSeries);
        }

        /// <summary>
        /// This endpoint deletes a specific tvserie by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTVSeries(int? id)
        {
            return await _tvseries.DeleteTVSeries(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table tvseries.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _tvseries.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchTVSeries([FromQuery] QueryParams qryp)
        {
            return await _tvseries.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table tvseries.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _tvseries.GetLastId();
        }
    }
}
