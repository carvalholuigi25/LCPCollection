using System.ComponentModel.DataAnnotations;

namespace LCPCollection.Shared.Classes;

public class DBSyncRunner
{
    [Required] public string DBMode { get; set; } = QryDBSModeEnum.SQLite.ToString();
}

public enum QryDBSModeEnum
{
    SQLServer,
    SQLite,
    MySQL,
    PostgreSQL
}
