using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data.SqlClient;
using NuGet.Protocol;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using Npgsql;

namespace LCPCollection.Server.Controllers
{
    [Route("api/admin/[controller]")]
    [ApiController]
    // [Authorize(Roles = "Administrator")]
    public class QryResBuilderController : ControllerBase
    {

        public QryResBuilderController()
        {
        }

        /// <summary>
        /// This endpoint retrives all qry build results.
        /// </summary>
        [HttpGet]
        public IActionResult GetResBuilder([FromQuery] QryResClBuilder.QryResCl qrclb)
        {
            try {
                StringComparison cmp = StringComparison.InvariantCultureIgnoreCase;

                if(qrclb.QryStr!.Contains("DROP")) {
                    return BadRequest("This command is forbidden!");
                }

                if(qrclb.DBMode!.Where(x => x.Name!.Contains("SQLServer", cmp)).Count() > 0) {
                    FetchDataSQLServer(qrclb, cmp);
                } else if (qrclb.DBMode!.Where(x => x.Name!.Contains("SQLite", cmp)).Count() > 0) {
                    FetchDataSQLite(qrclb, cmp);
                } else if (qrclb.DBMode!.Where(x => x.Name!.Contains("MySQL", cmp)).Count() > 0) {
                    FetchDataMySQL(qrclb, cmp);
                } else {
                    FetchDataPostgreSQL(qrclb, cmp);
                }

                return Ok("Done");
            } catch(Exception e) {
                return Ok("Error: " + e.Message);
            }
        }

        private bool FetchDataSQLServer(QryResClBuilder.QryResCl qrclb, StringComparison cmp = StringComparison.InvariantCultureIgnoreCase) {
            using (SqlConnection connection = new SqlConnection(qrclb.DBConStr))
            {
                SqlCommand command = new SqlCommand(qrclb.QryStr, connection);
                command.Connection.Open();

                if(qrclb.QryStr.Contains("select", cmp)) {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ok(String.Format("{0}", reader[0]));
                            return true;
                        }
                    }
                } else {
                    command.ExecuteNonQuery();
                    Ok(command.ToJson());
                    return true;
                }
            }

            return false;
        }

        private bool FetchDataSQLite(QryResClBuilder.QryResCl qrclb, StringComparison cmp = StringComparison.InvariantCultureIgnoreCase) {
            using var con = new SqliteConnection(qrclb.DBConStr);
            con.Open();
            using var cmd = new SqliteCommand(qrclb.QryStr, con);

            if(qrclb.QryStr.Contains("select", cmp)) {
                cmd.ExecuteScalar();
            } else {
                cmd.ExecuteNonQuery();
            }

            Ok(cmd.ToJson());
            return true;
        }

        private bool FetchDataMySQL(QryResClBuilder.QryResCl qrclb, StringComparison cmp = StringComparison.InvariantCultureIgnoreCase) {
            using var con = new MySqlConnection(qrclb.DBConStr);

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = qrclb.QryStr;

            con.Open();
            if(qrclb.QryStr.Contains("select", cmp)) {
                cmd.ExecuteReader();
            } else {
                cmd.ExecuteNonQuery();
            }

            Ok(cmd.ToJson());
            return true;
        }

        private bool FetchDataPostgreSQL(QryResClBuilder.QryResCl qrclb, StringComparison cmp = StringComparison.InvariantCultureIgnoreCase) {
            var con = new NpgsqlConnection(connectionString: qrclb.DBConStr);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            cmd.CommandText = qrclb.QryStr;
            
            if(qrclb.QryStr.Contains("select", cmp)) {
                cmd.ExecuteReader();
            } else {
                cmd.ExecuteNonQuery();
            }

            Ok(cmd.ToJson());
            return true;
        }
    }
}
