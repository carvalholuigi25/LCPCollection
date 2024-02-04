using LCPCollection.Server.Context;
using LCPCollection.Shared.Classes;
using Microsoft.AspNetCore.Mvc;

namespace LCPCollection.Server.Controllers
{
    [Route("api/upload/files")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private DBContext _context;

        public FileUploadController(DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This endpoint will upload the one or many files to the server.
        /// </summary>
        /// <param name="saveFile"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UploadFiles([FromBody] SaveFile saveFile)
        {
            string projectRootPath = Directory.GetCurrentDirectory();
            string[] extFilesNotAllowed = { "exe", "iso" };
            int maxFileSize = 10 * 1024 * 1024;
            int frmMaxFileSize = maxFileSize / (1024 * 1024);

            if (!Path.Exists(Path.Combine(projectRootPath!, "Uploads")))
            {
                Directory.CreateDirectory(Path.Combine(projectRootPath!, "Uploads"));
            }

            foreach (var file in saveFile.Files)
            {
                foreach(var extf in extFilesNotAllowed)
                {
                    if (file.FileName.EndsWith($".{extf}", StringComparison.OrdinalIgnoreCase))
                    {
                        return Content($"These extensions (.{extf}) are not allowed");
                    }
                }

                if (file.FileSize >= maxFileSize)
                {
                    return Content($"The maximum file size is {maxFileSize} bytes ({frmMaxFileSize} mb)!");
                }

                string fileName = Path.Combine(projectRootPath!, "Uploads", $"{file.FileName}");
                using (var fileStream = System.IO.File.Create(fileName))
                {
                    await fileStream.WriteAsync(file.ImageBytes);
                }

                if (saveFile.Files.Count > 0)
                {
                    _context.FilesData.Add(new FileData
                    {
                        FileName = file.FileName,
                        FileSize = file.FileSize,
                        FileType = file.FileType,
                        FileFullPath = file.FileFullPath,
                        ImageBytes = []
                    });

                    await _context.SaveChangesAsync();
                }
            }

            return Ok();
        }
    }
}
