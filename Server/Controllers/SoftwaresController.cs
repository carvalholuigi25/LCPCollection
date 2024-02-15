using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;
using LCPCollection.Shared.Classes.Filter;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftwaresController : ControllerBase
    {
        private readonly ISoftwares _softwares;

        public SoftwaresController(ISoftwares softwares)
        {
            _softwares = softwares;
        }

        /// <summary>
        /// This endpoint retrives all softwares.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Softwares>>> GetSoftwares()
        {
            return await _softwares.GetSoftwares();
        }

        /// <summary>
        /// This endpoint retrives specific software by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Softwares>>> GetSoftwaresById(int? id)
        {
            return await _softwares.GetSoftwaresById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of softwares for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetSoftwaresAsEnumList()
        {
            return _softwares.GetSoftwaresAsEnumList();
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
        /// This endpoint updates specific software by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Softwares"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoftwares(int? id, Softwares Softwares)
        {
            return await _softwares.PutSoftwares(id, Softwares);
        }

        /// <summary>
        /// This endpoint creates specific software by body.
        /// </summary>
        /// <param name="Softwares"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Softwares>> PostSoftwares(Softwares Softwares)
        {
            return await _softwares.PostSoftwares(Softwares);
        }

        /// <summary>
        /// This endpoint deletes a specific software by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoftwares(int? id)
        {
            return await _softwares.DeleteSoftwares(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table softwares.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _softwares.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchSoftwares([FromQuery] QueryParams qryp)
        {
            return await _softwares.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table softwares.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _softwares.GetLastId();
        }
    }
}
