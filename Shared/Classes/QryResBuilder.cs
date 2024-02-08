using System.ComponentModel.DataAnnotations;

namespace LCPCollection.Shared.Classes;
public class QryResClBuilder {
    public class QryResCl 
    {
        [Required] public List<DBModeListM> DBMode { get; set; } = GetDBModeList();
        public string? DBConStr { get; set; }
        [Required] public string QryStr { get; set; } = null!;
    }

    public class DBModeListM {
        public int? Id { get; set; }
        public string? Name { get; set; }
    } 

    public static List<DBModeListM> GetDBModeList() {
        return new List<DBModeListM>() {
            new DBModeListM() { Id = 1, Name = "SQLServer" },
            new DBModeListM() { Id = 2, Name = "SQLite" },
            new DBModeListM() { Id = 3, Name = "MySQL" },
            new DBModeListM() { Id = 4, Name = "PostgreSQL" }
        };
    }
}