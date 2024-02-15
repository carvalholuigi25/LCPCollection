using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace LCPCollection.Shared.Classes;

public class Users
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [DisplayName("Username")]
    [DataType("text")]
    public string? Username { get; set; }
    
    [DisplayName("Password")]
    [DataType("text")]
    public string? Password { get; set; }

    [DisplayName("RoleName")]
    [DataType("text")]
    public string? RoleName { get; set; } = RolesNamesEnum.User.ToString();

    [DisplayName("CurrentToken")]
    [DataType("text")]
    public string? CurrentToken { get; set; }

    [DisplayName("RefreshToken")]
    [DataType("text")]
    public string? RefreshToken { get; set; }
    
    [DisplayName("RefreshTokenExpiryTime")]
    [DataType(DataType.DateTime)]
    public DateTime? RefreshTokenExpiryTime { get; set; } = DateTime.UtcNow;

    [DisplayName("DateAccountCreated")]
    [DataType(DataType.DateTime)]
    public DateTime? DateAccountCreated { get; set; } = DateTime.UtcNow;
}

public class UsersLogin
{
    [DisplayName("Username")]
    [DataType("text")]
    public string? Username { get; set; }

    [DisplayName("Password")]
    [DataType("text")]
    public string? Password { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RolesNamesEnum
{
    [Description("Guest")] Guest,
    [Description("User")] User,
    [Description("Moderator")] Moderator,
    [Description("Administrator")] Administrator,
}
