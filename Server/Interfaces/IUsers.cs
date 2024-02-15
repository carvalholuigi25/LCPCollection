using LCPCollection.Shared.Classes;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface IUsers
    {
        Task<ActionResult<IEnumerable<Users>>> GetUsers();
        Task<ActionResult<IEnumerable<Users>>> GetUsersById(int? id);
        IActionResult GetUsersAsEnumList();
        Task<IActionResult> PutUsers(int? id, Users Users);
        Task<ActionResult<Users>> PostUsers(Users UsersData);
        Task<IActionResult> DeleteUsers(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
