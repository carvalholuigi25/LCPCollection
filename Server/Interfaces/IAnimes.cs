using LCPCollection.Shared.Classes;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface IAnimes
    {
        Task<ActionResult<IEnumerable<Animes>>> GetAnimes();
        Task<ActionResult<IEnumerable<Animes>>> GetAnimesById(int? id);
        IActionResult GetAnimesAsEnumList();
        Task<IActionResult> PutAnimes(int? id, Animes Animes);
        Task<ActionResult<Animes>> PostAnimes(Animes AnimesData);
        Task<IActionResult> DeleteAnimes(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
