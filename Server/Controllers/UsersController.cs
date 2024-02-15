using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Authorization;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator,Moderator,User")]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _users;

        public UsersController(IUsers users)
        {
            _users = users;
        }

        /// <summary>
        /// This endpoint retrives all users.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            return await _users.GetUsers();
        }

        /// <summary>
        /// This endpoint retrives specific user by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsersById(int? id)
        {
            return await _users.GetUsersById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of users for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetUsersAsEnumList()
        {
            return _users.GetUsersAsEnumList();
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
        /// This endpoint updates specific user by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Users"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int? id, Users Users)
        {
            return await _users.PutUsers(id, Users);
        }

        /// <summary>
        /// This endpoint creates specific user by body.
        /// </summary>
        /// <param name="Users"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users Users)
        {
            return await _users.PostUsers(Users);
        }

        /// <summary>
        /// This endpoint deletes a specific user by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsers(int? id)
        {
            return await _users.DeleteUsers(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table users.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _users.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchUsers([FromQuery] QueryParams qryp)
        {
            return await _users.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table users.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _users.GetLastId();
        }
    }
}
