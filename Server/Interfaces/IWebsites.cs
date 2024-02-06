using LCPCollection.Shared.Classes;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface IWebsites
    {
        Task<ActionResult<IEnumerable<Websites>>> GetWebsites();
        Task<ActionResult<IEnumerable<Websites>>> GetWebsitesById(int? id);
        IActionResult GetWebsitesAsEnumList();
        Task<IActionResult> PutWebsites(int? id, Websites Websites);
        Task<ActionResult<Websites>> PostWebsites(Websites WebsitesData);
        Task<IActionResult> DeleteWebsites(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
