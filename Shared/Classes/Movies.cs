using System.ComponentModel.DataAnnotations;

namespace LCPCollection.Shared.Classes
{
    public class Movies
    {
        [Key]
        public int? Id { get; set; }

        [DataType("text")]
        public string? Title { get; set; }

        [DataType("text")]
        public string? Description { get; set; }

        [DataType("text")]
        public string? CoverUrl { get; set; }

        [DataType("text")]
        public string? ImageUrl { get; set; }

        [DataType("text")]
        public string? Companies { get; set; }

        [DataType("text")]
        public string? Publishers { get; set; }

        [DataType("text")]
        public string? Platforms { get; set; }

        [DataType(DataType.DateTime)] 
        public DateTime? ReleaseDate { get; set; } = DateTime.UtcNow;

        [DataType("text")]
        public string? TrailerUrl { get; set; }

        [DataType("text")]
        public string? Genre { get; set; }
        public double? Rating { get; set; }
    }
}
