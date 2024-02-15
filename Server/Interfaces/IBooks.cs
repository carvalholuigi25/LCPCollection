using LCPCollection.Shared.Classes;
using LCPCollection.Shared.Classes.Filter;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Interfaces
{
    public interface IBooks
    {
        Task<ActionResult<IEnumerable<Books>>> GetBooks();
        Task<ActionResult<IEnumerable<Books>>> GetBooksById(int? id);
        IActionResult GetBooksAsEnumList();
        Task<IActionResult> PutBooks(int? id, Books Books);
        Task<ActionResult<Books>> PostBooks(Books BooksData);
        Task<IActionResult> DeleteBooks(int? id);
        Task<IActionResult> ResetIdSeed(int rsid = 1);
        Task<IActionResult> SearchData([FromQuery] QueryParams qryp);
        Task<IActionResult> GetLastId();
    }
}
