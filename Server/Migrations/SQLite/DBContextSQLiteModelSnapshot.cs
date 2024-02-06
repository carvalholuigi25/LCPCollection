﻿// <auto-generated />
using System;
using LCPCollection.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LCPCollection.Server.Migrations.SQLite
{
    [DbContext(typeof(DBContextSQLite))]
    partial class DBContextSQLiteModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("LCPCollection.Shared.Classes.Animes", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Companies")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platforms")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publishers")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("TEXT");

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
                            Rating = 9.0,
                            ReleaseDate = new DateTime(1986, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Dragon Ball",
                            TrailerUrl = "https://www.youtube.com/watch?v=gqIEgmqljM8"
                        });
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Books", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Companies")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platforms")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publishers")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.FileData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileFullPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("FileSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("GId")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ImageBytes")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("FilesData");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Games", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Companies")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platforms")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publishers")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Movies", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Companies")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platforms")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publishers")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Softwares", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Companies")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platforms")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Requirements")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.TVSeries", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Companies")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Platforms")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publishers")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TVSeries");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Websites", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BrowsersName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Companies")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Requirements")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Websites");
                });
#pragma warning restore 612, 618
        }
    }
}
