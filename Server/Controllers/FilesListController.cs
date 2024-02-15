using LCPCollection.Server.Interfaces;
using LCPCollection.Shared.Classes.Files;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Controllers
{
    [Route("api/list/files")]
    [ApiController]
    public class FilesListController : ControllerBase
    {
        private readonly IFilesList _filesdata;

        public FilesListController(IFilesList filesdata)
        {
           _filesdata = filesdata;
        }

        /// <summary>
        /// This endpoint retrives all files list.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FileData>>> GetFilesData()
        {
            return await _filesdata.GetFilesData();
        }

        /// <summary>
        /// This endpoint retrives specific a file list by id.
        /// </summary>
        /// <returns param="id"></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<FileData>>> GetFilesDataById(int? id)
        {
            return await _filesdata.GetFilesDataById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of files list for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetFilesDataAsEnumList()
        {
            return _filesdata.GetFilesDataAsEnumList();
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
        /// This endpoint updates specific file by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="FilesData"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilesData(int? id, FileData FilesData)
        {
            return await _filesdata.PutFilesData(id, FilesData);
        }

        /// <summary>
        /// This endpoint creates specific file by body.
        /// </summary>
        /// <param name="FilesData"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<FileData>> PostFilesData(FileData FilesData)
        {
            return await _filesdata.PostFilesData(FilesData);
        }

        /// <summary>
        /// This endpoint deletes a specific file by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilesData(int? id)
        {
            return await _filesdata.DeleteFilesData(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table files list.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _filesdata.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchFilesData([FromQuery] QueryParams qryp)
        {
            return await _filesdata.SearchData(qryp);
        }
    }
}
