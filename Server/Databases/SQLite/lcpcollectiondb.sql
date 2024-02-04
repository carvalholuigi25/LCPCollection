BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
	"MigrationId"	TEXT NOT NULL,
	"ProductVersion"	TEXT NOT NULL,
	CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY("MigrationId")
);
CREATE TABLE IF NOT EXISTS "Animes" (
	"Id"	INTEGER NOT NULL,
	"Title"	TEXT,
	"Description"	TEXT,
	"CoverUrl"	TEXT,
	"ImageUrl"	TEXT,
	"Companies"	TEXT,
	"Publishers"	TEXT,
	"Platforms"	TEXT,
	"ReleaseDate"	TEXT,
	"TrailerUrl"	TEXT,
	"Genre"	TEXT,
	"Rating"	REAL,
	CONSTRAINT "PK_Animes" PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Books" (
	"Id"	INTEGER NOT NULL,
	"Title"	TEXT,
	"Description"	TEXT,
	"CoverUrl"	TEXT,
	"ImageUrl"	TEXT,
	"Companies"	TEXT,
	"Publishers"	TEXT,
	"Platforms"	TEXT,
	"ReleaseDate"	TEXT,
	"TrailerUrl"	TEXT,
	"Genre"	TEXT,
	"Rating"	REAL,
	CONSTRAINT "PK_Books" PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "FilesData" (
	"Id"	INTEGER NOT NULL,
	"GId"	TEXT NOT NULL,
	"ImageBytes"	BLOB,
	"FileName"	TEXT NOT NULL,
	"FileType"	TEXT NOT NULL,
	"FileFullPath"	TEXT,
	"FileSize"	INTEGER NOT NULL,
	CONSTRAINT "PK_FilesData" PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Games" (
	"Id"	INTEGER NOT NULL,
	"Title"	TEXT,
	"Description"	TEXT,
	"CoverUrl"	TEXT,
	"ImageUrl"	TEXT,
	"Companies"	TEXT,
	"Publishers"	TEXT,
	"Platforms"	TEXT,
	"ReleaseDate"	TEXT,
	"TrailerUrl"	TEXT,
	"Genre"	TEXT,
	"Rating"	REAL,
	CONSTRAINT "PK_Games" PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Movies" (
	"Id"	INTEGER NOT NULL,
	"Title"	TEXT,
	"Description"	TEXT,
	"CoverUrl"	TEXT,
	"ImageUrl"	TEXT,
	"Companies"	TEXT,
	"Publishers"	TEXT,
	"Platforms"	TEXT,
	"ReleaseDate"	TEXT,
	"TrailerUrl"	TEXT,
	"Genre"	TEXT,
	"Rating"	REAL,
	CONSTRAINT "PK_Movies" PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "TVSeries" (
	"Id"	INTEGER NOT NULL,
	"Title"	TEXT,
	"Description"	TEXT,
	"CoverUrl"	TEXT,
	"ImageUrl"	TEXT,
	"Companies"	TEXT,
	"Publishers"	TEXT,
	"Platforms"	TEXT,
	"ReleaseDate"	TEXT,
	"TrailerUrl"	TEXT,
	"Genre"	TEXT,
	"Rating"	REAL,
	CONSTRAINT "PK_TVSeries" PRIMARY KEY("Id" AUTOINCREMENT)
);
INSERT INTO "__EFMigrationsHistory" ("MigrationId","ProductVersion") VALUES ('20240203094937_InitialCreateSQLite','8.0.1');
INSERT INTO "Animes" ("Id","Title","Description","CoverUrl","ImageUrl","Companies","Publishers","Platforms","ReleaseDate","TrailerUrl","Genre","Rating") VALUES (1,'Dragon Ball','Dragon Ball','covers/db.jpg','images/db.jpg','Toei Animation','Toei Animation','TV','1986-02-26 00:00:00','https://www.youtube.com/watch?v=gqIEgmqljM8','Animation',9.0);
COMMIT;
