using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;
using LCPCollection.Shared.Classes.Filter;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsitesController : ControllerBase
    {
        private readonly IWebsites _websites;

        public WebsitesController(IWebsites websites)
        {
            _websites = websites;
        }

        /// <summary>
        /// This endpoint retrives all websites.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Websites>>> GetWebsites()
        {
            return await _websites.GetWebsites();
        }

        /// <summary>
        /// This endpoint retrives specific website by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Websites>>> GetWebsitesById(int? id)
        {
            return await _websites.GetWebsitesById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of websites for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetWebsitesAsEnumList()
        {
            return _websites.GetWebsitesAsEnumList();
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
        /// This endpoint updates specific website by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Websites"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebsites(int? id, Websites Websites)
        {
            return await _websites.PutWebsites(id, Websites);
        }

        /// <summary>
        /// This endpoint creates specific website by body.
        /// </summary>
        /// <param name="Websites"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Websites>> PostWebsites(Websites Websites)
        {
            return await _websites.PostWebsites(Websites);
        }

        /// <summary>
        /// This endpoint deletes a specific website by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebsites(int? id)
        {
            return await _websites.DeleteWebsites(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table websites.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _websites.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchWebsites([FromQuery] QueryParams qryp)
        {
            return await _websites.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table websites.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _websites.GetLastId();
        }
    }
}
