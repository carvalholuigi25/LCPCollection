using LCPCollection.Shared.Classes;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface ISoftwares
    {
        Task<ActionResult<IEnumerable<Softwares>>> GetSoftwares();
        Task<ActionResult<IEnumerable<Softwares>>> GetSoftwaresById(int? id);
        IActionResult GetSoftwaresAsEnumList();
        Task<IActionResult> PutSoftwares(int? id, Softwares Softwares);
        Task<ActionResult<Softwares>> PostSoftwares(Softwares SoftwaresData);
        Task<IActionResult> DeleteSoftwares(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
