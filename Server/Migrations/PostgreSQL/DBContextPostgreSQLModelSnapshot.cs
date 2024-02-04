﻿// <auto-generated />
using System;
using LCPCollection.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LCPCollection.Server.Migrations.PostgreSQL
{
    [DbContext(typeof(DBContextPostgreSQL))]
    partial class DBContextPostgreSQLModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LCPCollection.Shared.Classes.Animes", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Companies")
                        .HasColumnType("text");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Platforms")
                        .HasColumnType("text");

                    b.Property<string>("Publishers")
                        .HasColumnType("text");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("text");

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
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Companies")
                        .HasColumnType("text");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Platforms")
                        .HasColumnType("text");

                    b.Property<string>("Publishers")
                        .HasColumnType("text");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.FileData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FileFullPath")
                        .HasColumnType("text");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("GId")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("ImageBytes")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("FilesData");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Games", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Companies")
                        .HasColumnType("text");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Platforms")
                        .HasColumnType("text");

                    b.Property<string>("Publishers")
                        .HasColumnType("text");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.Movies", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Companies")
                        .HasColumnType("text");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Platforms")
                        .HasColumnType("text");

                    b.Property<string>("Publishers")
                        .HasColumnType("text");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("LCPCollection.Shared.Classes.TVSeries", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Companies")
                        .HasColumnType("text");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Platforms")
                        .HasColumnType("text");

                    b.Property<string>("Publishers")
                        .HasColumnType("text");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TVSeries");
                });
#pragma warning restore 612, 618
        }
    }
}
