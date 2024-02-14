using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LCPCollection.Server.Migrations.PostgreSQL
{
    /// <inheritdoc />
    public partial class InitialCreatePostgreSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CoverUrl = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    Publishers = table.Column<string>(type: "text", nullable: true),
                    Platforms = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TrailerUrl = table.Column<string>(type: "text", nullable: true),
                    Genre = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CoverUrl = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    Publishers = table.Column<string>(type: "text", nullable: true),
                    Platforms = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TrailerUrl = table.Column<string>(type: "text", nullable: true),
                    Genre = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilesData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImageBytes = table.Column<byte[]>(type: "bytea", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    FileType = table.Column<string>(type: "text", nullable: false),
                    FileFullPath = table.Column<string>(type: "text", nullable: true),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CoverUrl = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    Publishers = table.Column<string>(type: "text", nullable: true),
                    Platforms = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TrailerUrl = table.Column<string>(type: "text", nullable: true),
                    Genre = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CoverUrl = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    Publishers = table.Column<string>(type: "text", nullable: true),
                    Platforms = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TrailerUrl = table.Column<string>(type: "text", nullable: true),
                    Genre = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Version = table.Column<int>(type: "integer", nullable: true),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    Platforms = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AuthorName = table.Column<string>(type: "text", nullable: true),
                    UrlValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TVSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CoverUrl = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    Publishers = table.Column<string>(type: "text", nullable: true),
                    Platforms = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    TrailerUrl = table.Column<string>(type: "text", nullable: true),
                    Genre = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Websites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    BrowsersName = table.Column<string>(type: "text", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AuthorName = table.Column<string>(type: "text", nullable: true),
                    UrlValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Websites", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "Id", "Companies", "CoverUrl", "Description", "Genre", "ImageUrl", "Platforms", "Publishers", "Rating", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[] { 1, "Toei Animation", "covers/db.jpg", "Dragon Ball", "Animation", "images/db.jpg", "TV", "Toei Animation", 9f, new DateTime(1986, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Dragon Ball", "https://www.youtube.com/watch?v=gqIEgmqljM8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "FilesData");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "TVSeries");

            migrationBuilder.DropTable(
                name: "Websites");
        }
    }
}
