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
    public class AdminController : ControllerBase
    {

        public AdminController()
        {
        }

        /// <summary>
        /// This endpoint runs the query and retrives his results
        /// </summary>
        [HttpGet("qryrunner")]
        public IActionResult DoQryRun([FromQuery] QryRunner qryrun)
        {
            try {
                StringComparison cmp = StringComparison.InvariantCultureIgnoreCase;

                if(qryrun.QryStr!.Contains("DROP", cmp)) {
                    return BadRequest("This command is forbidden!");
                }

                if(qryrun.DBMode == QryDBModeEnum.SQLite) {
                    return FetchDataSQLite(qryrun, cmp);
                } else if(qryrun.DBMode == QryDBModeEnum.MySQL) {
                    return FetchDataMySQL(qryrun, cmp);
                } else if(qryrun.DBMode == QryDBModeEnum.PostgreSQL) {
                    return FetchDataPostgreSQL(qryrun, cmp);
                } else {
                    return FetchDataSQLServer(qryrun, cmp);
                }
            } catch(Exception e) {
                return Ok("Error: " + e.Message);
            }
        }

        private IActionResult FetchDataSQLServer(QryRunner qryrun, StringComparison cmp) {
            using SqlConnection connection = new SqlConnection(qryrun.DBConStr);
            SqlCommand command = new SqlCommand(qryrun.QryStr, connection);
            command.Connection.Open();

            var res = "";

            if (qryrun.QryStr.Contains("SELECT", cmp))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    res = string.Format("{0}", reader[0]);
                }
            }
            else
            {
                command.ExecuteNonQuery();
                res = command.ToJson();
            }

            return Ok(res);
        }

        private IActionResult FetchDataSQLite(QryRunner qryrun, StringComparison cmp) {
            using var con = new SqliteConnection(qryrun.DBConStr);
            con.Open();
            using var cmd = new SqliteCommand(qryrun.QryStr, con);

            if(qryrun.QryStr.Contains("SELECT", cmp)) {
                cmd.ExecuteScalar();
            } else {
                cmd.ExecuteNonQuery();
            }

            return Ok(cmd.ToJson());
        }

        private IActionResult FetchDataMySQL(QryRunner qryrun, StringComparison cmp) {
            using var con = new MySqlConnection(qryrun.DBConStr);

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = qryrun.QryStr;

            con.Open();
            if(qryrun.QryStr.Contains("SELECT", cmp)) {
                cmd.ExecuteReader();
            } else {
                cmd.ExecuteNonQuery();
            }

            return Ok(cmd.ToJson());
        }

        private IActionResult FetchDataPostgreSQL(QryRunner qryrun, StringComparison cmp) {
            var con = new NpgsqlConnection(connectionString: qryrun.DBConStr);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            cmd.CommandText = qryrun.QryStr;
            
            if(qryrun.QryStr.Contains("SELECT", cmp)) {
                cmd.ExecuteReader();
            } else {
                cmd.ExecuteNonQuery();
            }

            return Ok(cmd.ToJson());
        }
    }
}
