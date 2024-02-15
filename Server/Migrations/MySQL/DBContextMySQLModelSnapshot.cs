﻿// <auto-generated />
using System;
using LCPCollection.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LCPCollection.Server.Migrations.MySQL
{
    [DbContext(typeof(DBContextMySQL))]
    partial class DBContextMySQLModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LCPCollection.Shared.Classes.Animes", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companies")
                        .HasColumnType("longtext");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Platforms")
                        .HasColumnType("longtext");

                    b.Property<string>("Publishers")
                        .HasColumnType("longtext");

                    b.Property<float?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Animes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Companies = "Toei Animation",
                            CoverUrl = "covers/db.jpg",
                            Description = "Dragon Ball",
                            Genre = "Animation",
                            ImageUrl = "images/db.jpg",
                            Platforms = "TV",
                            Publishers = "Toei Animation",
                            Rating = 9f,
                            ReleaseDate = new DateTime(1986, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Dragon Ball",
                            TrailerUrl = "https://www.youtube.com/embed/gqIEgmqljM8"
                        });
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Books", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companies")
                        .HasColumnType("longtext");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Platforms")
                        .HasColumnType("longtext");

                    b.Property<string>("Publishers")
                        .HasColumnType("longtext");

                    b.Property<float?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Files.FileData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FileFullPath")
                        .HasColumnType("longtext");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("GId")
                        .HasColumnType("char(36)");

                    b.Property<byte[]>("ImageBytes")
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.ToTable("FilesData");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Games", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companies")
                        .HasColumnType("longtext");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Platforms")
                        .HasColumnType("longtext");

                    b.Property<string>("Publishers")
                        .HasColumnType("longtext");

                    b.Property<float?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Movies", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companies")
                        .HasColumnType("longtext");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Platforms")
                        .HasColumnType("longtext");

                    b.Property<string>("Publishers")
                        .HasColumnType("longtext");

                    b.Property<float?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Softwares", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .HasColumnType("longtext");

                    b.Property<string>("Companies")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Platforms")
                        .HasColumnType("longtext");

                    b.Property<float?>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Requirements")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<string>("UrlValue")
                        .HasColumnType("longtext");

                    b.Property<int?>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.TVSeries", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Companies")
                        .HasColumnType("longtext");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Platforms")
                        .HasColumnType("longtext");

                    b.Property<string>("Publishers")
                        .HasColumnType("longtext");

                    b.Property<float?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TVSeries");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CurrentToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DateAccountCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RoleName")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAccountCreated = new DateTime(2024, 2, 15, 17, 50, 50, 55, DateTimeKind.Utc).AddTicks(808),
                            Password = "$2a$12$PjfItbWyppOBdY87eO3Tju7Ot7wULsVT1yYPXR.baZNftpJYXsvMO",
                            RefreshTokenExpiryTime = new DateTime(2024, 2, 15, 17, 50, 50, 55, DateTimeKind.Utc).AddTicks(817),
                            RoleName = "Administrator",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Websites", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .HasColumnType("longtext");

                    b.Property<string>("BrowsersName")
                        .HasColumnType("longtext");

                    b.Property<string>("Companies")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<float?>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Requirements")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<string>("UrlValue")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Websites");
                });
#pragma warning restore 612, 618
        }
    }
}
