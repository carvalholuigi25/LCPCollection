using Microsoft.AspNetCore.Mvc;
using LCPCollection.Shared.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data.SqlClient;
using NuGet.Protocol;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using Npgsql;
using System.Collections;

namespace LCPCollection.Server.Controllers
{
    [Route("api/admin")]
    [ApiController]
    // [Authorize(Roles = "Administrator")]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
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

                if(qryrun.DBMode.Contains(QryDBModeEnum.SQLite.ToString(), cmp)) {
                    return FetchDataSQLite(qryrun, cmp);
                } else if(qryrun.DBMode.Contains(QryDBModeEnum.MySQL.ToString(), cmp)) {
                    return FetchDataMySQL(qryrun, cmp);
                } else if(qryrun.DBMode.Contains(QryDBModeEnum.PostgreSQL.ToString(), cmp)) {
                    return FetchDataPostgreSQL(qryrun, cmp);
                } else {
                    return FetchDataSQLServer(qryrun, cmp);
                }
            } catch(Exception e) {
                return Ok("Error: " + e.Message);
            }
        }

        private IActionResult FetchDataSQLServer(QryRunner qryrun, StringComparison cmp) {
            using SqlConnection connection = new SqlConnection(_configuration[$"ConnectionStrings:{qryrun.DBMode}"]);
            SqlCommand command = new SqlCommand(qryrun.QryStr, connection);
            command.Connection.Open();

            ArrayList res = new ArrayList();

            if (qryrun.QryStr.Contains("SELECT", cmp))
            {
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(reader.HasRows) 
                    {
                        for(var x = 0; x < reader.FieldCount; x++) {
                            res.Add(new { key = reader.GetName(x), value = reader.GetValue(x) });
                        }
                    }
            }
            }
            else
            {
                command.ExecuteNonQuery();
                res.Add(command.ToJson());
            }

            return Ok(res);
        }

        private IActionResult FetchDataSQLite(QryRunner qryrun, StringComparison cmp) {
            using var con = new SqliteConnection(_configuration[$"ConnectionStrings:{qryrun.DBMode}"]);
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
            using var con = new MySqlConnection(_configuration[$"ConnectionStrings:{qryrun.DBMode}"]);

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
            var con = new NpgsqlConnection(connectionString: _configuration[$"ConnectionStrings:{qryrun.DBMode}"]);
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
