using System.ComponentModel.DataAnnotations;

namespace LCPCollection.Shared.Classes;
public class QryRunner {
    [Required] public string DBMode { get; set; } = QryDBModeEnum.SQLServer.ToString();
    [Required] public string QryStr { get; set; } = null!;
}

public class DBSyncRunner
{
    [Required] public string DBMode { get; set; } = QryDBModeEnum.SQLServer.ToString();
}

public enum QryDBModeEnum
{
    SQLServer,
    SQLite,
    MySQL,
    PostgreSQL
}