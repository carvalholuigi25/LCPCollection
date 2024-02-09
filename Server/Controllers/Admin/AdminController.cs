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
using Newtonsoft.Json;

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
            var res = new Dictionary<object, object?>();
            var lstres = new List<object>();

            using SqlConnection connection = new SqlConnection(_configuration[$"ConnectionStrings:{qryrun.DBMode}"]);
            SqlCommand cmd = new SqlCommand(qryrun.QryStr, connection);
            cmd.Connection.Open();

            if (qryrun.QryStr.Contains("SELECT", cmp))
            {
                using SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        for(var x = 0; x < reader.FieldCount; x++) {
                            res[reader.GetName(x)] = reader.GetValue(x);
                            // res.Add(reader.GetName(x), reader.GetValue(x));
                        }
                    }
                } else {
                    res.Add("status", "No rows for that table!");
                }
            } else if(qryrun.QryStr.Contains("INSERT", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Inserted data from database with success!");
                } else {
                    res.Add("status", "Error while inserting data from database!");
                }
            } else if(qryrun.QryStr.Contains("UPDATE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Updated data from database with success!");
                } else {
                    res.Add("status", "Error while updating data from database!");
                }
            } else if(qryrun.QryStr.Contains("DELETE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Deleted data from database with success!");
                } else {
                    res.Add("status", "Error while deleting data from database!");
                }
            } else {
                cmd.ExecuteNonQuery();
                res.Add(cmd.ToJson(), null);
            }

            lstres.Add(res);
            return Ok(lstres);
        }

        private IActionResult FetchDataSQLite(QryRunner qryrun, StringComparison cmp) {
            var res = new Dictionary<object, object?>();
            var lstres = new List<object>();

            using var con = new SqliteConnection(_configuration[$"ConnectionStrings:{qryrun.DBMode}"]);
            con.Open();
            using var cmd = new SqliteCommand(qryrun.QryStr, con);

            if(qryrun.QryStr.Contains("SELECT", cmp)) {
               SqliteDataReader dr = cmd.ExecuteReader();
               if(dr.HasRows) {
                    dr.Read();

                    for(var x = 0; x < dr.FieldCount; x++) {
                        res[dr.GetName(x)] = dr.GetValue(x);
                        // res.Add(reader.GetName(x), reader.GetValue(x));
                    }
                } else {
                    res.Add("status", "No rows for that table!");
                }
            } else if(qryrun.QryStr.Contains("INSERT", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Inserted data from database with success!");
                } else {
                    res.Add("status", "Error while inserting data from database!");
                }
            } else if(qryrun.QryStr.Contains("UPDATE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Updated data from database with success!");
                } else {
                    res.Add("status", "Error while updating data from database!");
                }
            } else if(qryrun.QryStr.Contains("DELETE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Deleted data from database with success!");
                } else {
                    res.Add("status", "Error while deleting data from database!");
                }
            } else {
                cmd.ExecuteNonQuery();
                res.Add(cmd.ToJson(), null);
            }

            lstres.Add(res);
            return Ok(lstres);
        }

        private IActionResult FetchDataMySQL(QryRunner qryrun, StringComparison cmp) {
            var res = new Dictionary<object, object?>();
            var lstres = new List<object>();

            using var con = new MySqlConnection(_configuration[$"ConnectionStrings:{qryrun.DBMode}"]);

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = qryrun.QryStr;

            con.Open();
            if(qryrun.QryStr.Contains("SELECT", cmp)) {
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    for(var x = 0; x < dr.FieldCount; x++) {
                        res[dr.GetName(x)] = dr.GetValue(x);
                        // res.Add(reader.GetName(x), reader.GetValue(x));
                    }
                } else {
                    res.Add("status", "No rows for that table!");
                }
            } else if(qryrun.QryStr.Contains("INSERT", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Inserted data from database with success!");
                } else {
                    res.Add("status", "Error while inserting data from database!");
                }
            } else if(qryrun.QryStr.Contains("UPDATE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Updated data from database with success!");
                } else {
                    res.Add("status", "Error while updating data from database!");
                }
            } else if(qryrun.QryStr.Contains("DELETE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Deleted data from database with success!");
                } else {
                    res.Add("status", "Error while deleting data from database!");
                }
            } else {
                cmd.ExecuteNonQuery();
                res.Add(cmd.ToJson(), null);
            }

            lstres.Add(res);
            return Ok(lstres);
        }

        private IActionResult FetchDataPostgreSQL(QryRunner qryrun, StringComparison cmp) {
            var res = new Dictionary<object, object?>();
            var lstres = new List<object>();

            using var con = new NpgsqlConnection(_configuration[$"ConnectionStrings:{qryrun.DBMode}"]);
            con.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            cmd.CommandText = qryrun.QryStr;
            
            if(qryrun.QryStr.Contains("SELECT", cmp)) {
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows) {
                    dr.Read();

                    for(var x = 0; x < dr.FieldCount; x++) {
                        res[dr.GetName(x)] = dr.GetValue(x);
                        // res.Add(reader.GetName(x), reader.GetValue(x));
                    }
                } else {
                    res.Add("status", "No rows for that table!");
                }
            } else if(qryrun.QryStr.Contains("INSERT", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Inserted data from database with success!");
                } else {
                    res.Add("status", "Error while inserting data from database!");
                }
            } else if(qryrun.QryStr.Contains("UPDATE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Updated data from database with success!");
                } else {
                    res.Add("status", "Error while updating data from database!");
                }
            } else if(qryrun.QryStr.Contains("DELETE", cmp)) {
                if(cmd.ExecuteNonQuery() >= 1) {
                    res.Add("status", "Deleted data from database with success!");
                } else {
                    res.Add("status", "Error while deleting data from database!");
                }
            } else {
                cmd.ExecuteNonQuery();
                res.Add(cmd.ToJson(), null);
            }

            lstres.Add(res);
            return Ok(lstres);
        }
    }
}
