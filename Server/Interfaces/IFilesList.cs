using LCPCollection.Shared.Classes.Files;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface IFilesList
    {
        Task<ActionResult<IEnumerable<FileData>>> GetFilesData();
        Task<ActionResult<IEnumerable<FileData>>> GetFilesDataById(int? id);
        IActionResult GetFilesDataAsEnumList();
        Task<IActionResult> PutFilesData(int? id, FileData FilesData);
        Task<ActionResult<FileData>> PostFilesData(FileData FilesData);
        Task<IActionResult> DeleteFilesData(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
    }
}
