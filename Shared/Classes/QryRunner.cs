using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LCPCollection.Shared.Classes;
public class QryRunner {
    [Required] public QryDBModeEnum DBMode { get; set; } = QryDBModeEnum.SQLServer;
    public string? DBConStr { get; set; }
    [Required] public string QryStr { get; set; } = null!;
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QryDBModeEnum
{
    [Description("SQLServer")] SQLServer,
    [Description("SQLite")] SQLite,
    [Description("MySQL")] MySQL,
    [Description("PostgreSQL")] PostgreSQL
}