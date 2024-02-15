using LCPCollection.Shared.Classes;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface ITVSeries
    {
        Task<ActionResult<IEnumerable<TVSeries>>> GetTVSeries();
        Task<ActionResult<IEnumerable<TVSeries>>> GetTVSeriesById(int? id);
        IActionResult GetTVSeriesAsEnumList();
        Task<IActionResult> PutTVSeries(int? id, TVSeries TVSeries);
        Task<ActionResult<TVSeries>> PostTVSeries(TVSeries TVSeriesData);
        Task<IActionResult> DeleteTVSeries(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
