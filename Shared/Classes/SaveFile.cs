using System.ComponentModel.DataAnnotations;

namespace LCPCollection.Shared.Classes
{
    public class SaveFile
    {
        public SaveFile()
        {
            Files = new List<FileData>();
        }
        public List<FileData> Files { get; set; } = null!;
    }

    public class FileData
    {
        [Key]
        public int Id { get; set; }
        public Guid GId { get; set; } = Guid.NewGuid();
        public byte[]? ImageBytes { get; set; }
        [DataType("text")]
        public string FileName { get; set; } = null!;
        [DataType("text")]
        public string FileType { get; set; } = null!;
        [DataType("text")]
        public string? FileFullPath { get; set; }
        public long FileSize { get; set; }
    }
}
