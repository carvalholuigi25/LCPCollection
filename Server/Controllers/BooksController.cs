using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using LCPCollection.Server.Interfaces;

namespace LCPCollection.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooks _books;

        public BooksController(IBooks books)
        {
            _books = books;
        }

        /// <summary>
        /// This endpoint retrives all books.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Books>>> GetBooks()
        {
            return await _books.GetBooks();
        }

        /// <summary>
        /// This endpoint retrives specific book by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Books>>> GetBooksById(int? id)
        {
            return await _books.GetBooksById(id);
        }

        /// <summary>
        /// This endpoint retrives list of enums of books for search feature
        /// </summary>
        /// <returns></returns>
        [HttpGet("enumslist")]
        public IActionResult GetBooksAsEnumList()
        {
            return _books.GetBooksAsEnumList();
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
        /// This endpoint updates specific book by id and body.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Books"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooks(int? id, Books Books)
        {
            return await _books.PutBooks(id, Books);
        }

        /// <summary>
        /// This endpoint creates specific book by body.
        /// </summary>
        /// <param name="Books"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Books>> PostBooks(Books Books)
        {
            return await _books.PostBooks(Books);
        }

        /// <summary>
        /// This endpoint deletes a specific book by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooks(int? id)
        {
            return await _books.DeleteBooks(id);
        }

        /// <summary>
        /// This endpoint resets a auto increment seed by id for table books.
        /// </summary>
        /// <param name="rsid"></param>
        /// <returns></returns>
        [HttpPost("{rsid}")]
        public async Task<IActionResult> ResetIdSeed(int rsid = 1)
        {
            return await _books.ResetIdSeed(rsid);
        }

        /// <summary>
        /// This endpoint does the full filter operation for data.
        /// </summary>
        /// <param name="qryp"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        public async Task<IActionResult> SearchBooks([FromQuery] QueryParams qryp)
        {
            return await _books.SearchData(qryp);
        }

        /// <summary>
        /// This endpoint will return the last id for table books.
        /// </summary>
        /// <returns></returns>
        [HttpGet("lastid")]
        public async Task<IActionResult> GetLastId()
        {
            return await _books.GetLastId();
        }
    }
}
