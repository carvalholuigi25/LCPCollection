using System.ComponentModel.DataAnnotations;

namespace LCPCollection.Shared.Classes;

public class Websites {
    [Key]
    public int? Id { get; set; }

    [DataType("text")]
    public string? Title { get; set; }

    [DataType("text")]
    public string? Type { get; set; }

    [DataType("text")]
    public string? Description { get; set; }

    [DataType("text")]
    public string? Companies { get; set; }

    [DataType("text")]
    public string? ImageUrl { get; set; }

    [DataType("text")]
    public string? Requirements { get; set; }

    [DataType("text")]
    public string? BrowsersName { get; set; }

    public float? Rating { get; set; }

    [DataType("datetime")]
    public DateTime? DateCreated { get; set; }

    [DataType("text")]
    public string? AuthorName { get; set; }

    [DataType("text")]
    public string? UrlValue { get; set; }
}