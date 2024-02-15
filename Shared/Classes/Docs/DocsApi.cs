namespace LCPCollection.Shared.Classes.Docs
{
    public class DocsApi
    {
        public class ContentDocsApi
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public string? Desc { get; set; }
            public string? ClassName { get; set; }
            public string? IdName { get; set; }
            public List<SubContentDocsApi>? ListSubContent { get; set; }
            public List<LinksDocsApi>? LinksListDocsApi { get; set; }
        }

        public class SubContentDocsApi
        {
            public string? TitleEndpoint { get; set; }
            public string? DescEndpoint { get; set; }
            public string? ClassNameEndpoint { get; set; }
            public List<HttpReqsEndpointCl>? HttpReqsEndpoint { get; set; }
            public TblProps? QueryParamsEndpoint { get; set; }
            public TblProps? BodyParamsEndpoint { get; set; }
            public string? ModelValExampleEndpoint { get; set; }
            public TblProps? TblErrorsCodeEndpoint { get; set; }
        }

        public class HttpReqsEndpointCl
        {
            public int? Key { get; set; }
            public string? Value { get; set; }
            public string? Desc { get; set; }
        }

        public class TblProps
        {
            public List<TblPropsObjs>? HeaderTbl { get; set; }
            public List<TblPropsObjs>? BodyTbl { get; set; }
        }

        public class TblPropsObjs
        {
            public int? Key { get; set; }
            public string? Value { get; set; }
            public string? Desc { get; set; }
        }

        public class LinksDocsApi
        {
            public int? Id { get; set; }
            public string? Title { get; set; }
            public string? Href { get; set; }
            public bool? Subitem { get; set; }
            public List<LinksSubitemDocsApi>? SubitemList { get; set; } = new List<LinksSubitemDocsApi>();
        }

        public class LinksSubitemDocsApi
        {
            public int? Id { get; set; }
            public string? Title { get; set; }
            public string? Href { get; set; }
        }

        public static List<ContentDocsApi> GetList()
        {
            return new List<ContentDocsApi>()
            {
                new ContentDocsApi()
                {
                    Id = 1,
                    Title = "Introduction",
                    Desc = "Please feel free to view, read and/or copy and paste or write our api endpoints into your browser, software or webapp.",
                    ClassName = "apiintroduction",
                    IdName = "introduction",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Welcome to LCP Collection Api Docs (Documents)!",
                            DescEndpoint = "",
                            ClassNameEndpoint = "intro",
                            HttpReqsEndpoint = null,
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = "",
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 1,
                            Title = "Introduction",
                            Href = "introduction",
                            Subitem = false,
                            SubitemList = null
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 2,
                    Title = "Authentication / Authorization",
                    Desc = "<p class='desc'>LCPCollection uses API keys to allow access to the API.</p><p class='desc'>LCPCollection expects for the API key to be included in all API requests to the server in a header that looks like the following: <br /><code class='code'>Authorization: <span class='bold'>[API_TOKEN_KEY]</span></code></p><p class='desc'><p>Request urls: </p><code class='code'>For CURL: <br /># With shell, you can just pass the correct header with each request <br /> curl 'https://localhost:5000/api' \\ -H 'Authorization: <span class='bold'>[TYPE_AUTH]</span> <span class='bold'>[API_TOKEN_KEY]</span>' <br /> or <br /> curl 'http://localhost:5001/api' \\ -H 'Authorization: <span class='bold'>[TYPE_AUTH]</span> <span class='bold'>[API_TOKEN_KEY]</span>' <br /> For HTTPS / HTTP: <br /><span class='bold'>[TYPE_METHOD]</span> https://localhost:5000/api/<span class='bold'>[QUERY_PARAMETERS]</span> <br /> <span class='bold'>[TYPE_METHOD]</span> http://localhost:5000/api/<span class='bold'>[QUERY_PARAMETERS]</span></code></p><p class='desc'>Note: Replace <span class='bold'>[API_TOKEN_KEY]</span> to your api personal token key!</p><p class='desc'>Note 2: Replace <span class='bold'>[TYPE_METHOD]</span> to one of these options: GET, PUT, PATCH, POST, DELETE and OPTIONS.</p><p class='desc'>Note 3: Replace <span class='bold'>[QUERY_PARAMETERS]</span> to your any query parameters as you wish (like ?id=id or /id) (optional).</p><p class='desc'>Note 4: Replace <span class='bold'>[TYPE_AUTH]</span> to one of these options: BASIC, BEARER or nothing (optional).</p>",
                    ClassName = "apiauth",
                    IdName = "auth",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Authentication / Authorization",
                            DescEndpoint = "",
                            ClassNameEndpoint = "auth",
                            HttpReqsEndpoint = null,
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = "",
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 2,
                            Title = "Authentication / Authorization",
                            Href = "auth",
                            Subitem = false,
                            SubitemList = null
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 3,
                    Title = "Animes",
                    Desc = "",
                    ClassName = "apianimes",
                    IdName = "animes",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get all animes",
                            DescEndpoint = "This endpoint fetches all animes infos.",
                            ClassNameEndpoint = "animesget",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/animes"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/animes"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get animes by id",
                            DescEndpoint = "This endpoint fetches a animes info by id.",
                            ClassNameEndpoint = "animesgetbyid",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/animes/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/animes/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the animes to get it" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Create animes",
                            DescEndpoint = "This endpoint creates a new animes.",
                            ClassNameEndpoint = "animespost",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST https://localhost:5000/api/animes"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST http://localhost:5001/api/animes"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the animes" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Update animes",
                            DescEndpoint = "This endpoint updates the current animes by id and body.",
                            ClassNameEndpoint = "animesupdate",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT https://localhost:5000/api/animes/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT http://localhost:5001/api/animes/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the animes to update" }
                                },
                            },
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the animes" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Delete animes By Id",
                            DescEndpoint = "This endpoint deletes a specific book by id.",
                            ClassNameEndpoint = "animesdelete",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE https://localhost:5000/api/animes/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE http://localhost:5001/api/animes/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the animes to delete" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 3,
                            Title = "Animes",
                            Href = "animes",
                            Subitem = true,
                            SubitemList = GetSubitemListLinks()
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 4,
                    Title = "Games",
                    Desc = "",
                    ClassName = "apigames",
                    IdName = "games",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get all games",
                            DescEndpoint = "This endpoint fetches all games infos.",
                            ClassNameEndpoint = "gamesget",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/games"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/games"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get games by id",
                            DescEndpoint = "This endpoint fetches a games info by id.",
                            ClassNameEndpoint = "gamesgetbyid",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/games/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/games/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the games to get it" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Create games",
                            DescEndpoint = "This endpoint creates a new games.",
                            ClassNameEndpoint = "gamespost",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST https://localhost:5000/api/games"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST http://localhost:5001/api/games"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the games" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Update games",
                            DescEndpoint = "This endpoint updates the current games by id and body.",
                            ClassNameEndpoint = "gamesupdate",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT https://localhost:5000/api/games/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT http://localhost:5001/api/games/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the games to update" }
                                },
                            },
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the games" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Delete games By Id",
                            DescEndpoint = "This endpoint deletes a specific book by id.",
                            ClassNameEndpoint = "gamesdelete",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE https://localhost:5000/api/games/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE http://localhost:5001/api/games/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the games to delete" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 4,
                            Title = "Games",
                            Href = "games",
                            Subitem = true,
                            SubitemList = GetSubitemListLinks()
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 5,
                    Title = "Movies",
                    Desc = "",
                    ClassName = "apimovies",
                    IdName = "movies",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get all movies",
                            DescEndpoint = "This endpoint fetches all movies infos.",
                            ClassNameEndpoint = "moviesget",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/movies"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/movies"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get movies by id",
                            DescEndpoint = "This endpoint fetches a movies info by id.",
                            ClassNameEndpoint = "moviesgetbyid",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/movies/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/movies/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the movies to get it" },
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Create movies",
                            DescEndpoint = "This endpoint creates a new movies.",
                            ClassNameEndpoint = "moviespost",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST https://localhost:5000/api/movies"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST http://localhost:5001/api/movies"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the movies" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Update movies",
                            DescEndpoint = "This endpoint updates the current movies by id and body.",
                            ClassNameEndpoint = "moviesupdate",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT https://localhost:5000/api/movies/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT http://localhost:5001/api/movies/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the movies to update" }
                                },
                            },
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the movies" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Delete movies By Id",
                            DescEndpoint = "This endpoint deletes a specific book by id.",
                            ClassNameEndpoint = "moviesdelete",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE https://localhost:5000/api/movies/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE http://localhost:5001/api/movies/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the movies to delete" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 5,
                            Title = "Movies",
                            Href = "movies",
                            Subitem = true,
                            SubitemList = GetSubitemListLinks()
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 6,
                    Title = "Books",
                    Desc = "",
                    ClassName = "apibooks",
                    IdName = "books",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get all Books",
                            DescEndpoint = "This endpoint fetches all Books infos.",
                            ClassNameEndpoint = "booksget",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/books"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/books"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get Books by id",
                            DescEndpoint = "This endpoint fetches a Books info by id.",
                            ClassNameEndpoint = "booksgetbyid",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/books/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/books/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the books to get it" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Create Books",
                            DescEndpoint = "This endpoint creates a new Books.",
                            ClassNameEndpoint = "bookspost",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST https://localhost:5000/api/books"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST http://localhost:5001/api/books"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the books" },
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Update Books",
                            DescEndpoint = "This endpoint updates the current Books by id and body.",
                            ClassNameEndpoint = "booksupdate",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT https://localhost:5000/api/books/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT http://localhost:5001/api/books/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the books to update" },
                                },
                            },
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the books" },
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Delete books By Id",
                            DescEndpoint = "This endpoint deletes a specific book by id.",
                            ClassNameEndpoint = "booksdelete",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE https://localhost:5000/api/books/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE http://localhost:5001/api/books/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the books to delete" },
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 6,
                            Title = "Books",
                            Href = "books",
                            Subitem = true,
                            SubitemList = GetSubitemListLinks()
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 7,
                    Title = "TV Series",
                    Desc = "",
                    ClassName = "apitvseries",
                    IdName = "tvseries",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get all TV Series",
                            DescEndpoint = "This endpoint fetches all TV Series infos.",
                            ClassNameEndpoint = "tvseriesget",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/tvseries"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/tvseries"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get TV Series by id",
                            DescEndpoint = "This endpoint fetches a TV Series info by id.",
                            ClassNameEndpoint = "tvseriesgetbyid",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/tvseries/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/tvseries/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" }
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the tvseries to get it" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Create TV Series",
                            DescEndpoint = "This endpoint creates a new TV Series.",
                            ClassNameEndpoint = "tvseriespost",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST https://localhost:5000/api/tvseries"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST http://localhost:5001/api/tvseries"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the tvseries" },
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Update TV Series",
                            DescEndpoint = "This endpoint updates the current TV Series by id and body.",
                            ClassNameEndpoint = "tvseriesupdate",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT https://localhost:5000/api/tvseries/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT http://localhost:5001/api/tvseries/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the tvseries to update" },
                                },
                            },
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the tvseries" },
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Delete tvseries By Id",
                            DescEndpoint = "This endpoint deletes a specific tvserie by id.",
                            ClassNameEndpoint = "tvseriesdelete",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE https://localhost:5000/api/tvseries/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE http://localhost:5001/api/tvseries/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the tvseries to delete" },
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"description\": \"string\",\r\n    \"coverUrl\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"publishers\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"releaseDate\": \"2024-01-29T15:01:20.737Z\",\r\n    \"trailerUrl\": \"string\",\r\n    \"genre\": \"string\",\r\n    \"rating\": 0\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 7,
                            Title = "TV Series",
                            Href = "tvseries",
                            Subitem = true,
                            SubitemList = GetSubitemListLinks()
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 8,
                    Title = "Softwares",
                    Desc = "",
                    ClassName = "apisoftwares",
                    IdName = "softwares",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get all softwares",
                            DescEndpoint = "This endpoint fetches all softwares infos.",
                            ClassNameEndpoint = "softwaresget",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/softwares"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/softwares"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"version\": 0,\r\n    \"requirements\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:44:49.927Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get softwares by id",
                            DescEndpoint = "This endpoint fetches a softwares info by id.",
                            ClassNameEndpoint = "softwaresgetbyid",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/softwares/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/softwares/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the softwares to get it" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"version\": 0,\r\n    \"requirements\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:44:49.927Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Create softwares",
                            DescEndpoint = "This endpoint creates a new softwares.",
                            ClassNameEndpoint = "softwarespost",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST https://localhost:5000/api/softwares"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST http://localhost:5001/api/softwares"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the softwares" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"version\": 0,\r\n    \"requirements\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:44:49.927Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Update softwares",
                            DescEndpoint = "This endpoint updates the current softwares by id and body.",
                            ClassNameEndpoint = "softwaresupdate",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT https://localhost:5000/api/softwares/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT http://localhost:5001/api/softwares/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the softwares to update" }
                                },
                            },
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the softwares" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"version\": 0,\r\n    \"requirements\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:44:49.927Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Delete softwares By Id",
                            DescEndpoint = "This endpoint deletes a specific book by id.",
                            ClassNameEndpoint = "softwaresdelete",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE https://localhost:5000/api/softwares/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE http://localhost:5001/api/softwares/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the softwares to delete" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"version\": 0,\r\n    \"requirements\": \"string\",\r\n    \"platforms\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:44:49.927Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 8,
                            Title = "Softwares",
                            Href = "softwares",
                            Subitem = true,
                            SubitemList = GetSubitemListLinks()
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 9,
                    Title = "Websites",
                    Desc = "",
                    ClassName = "apiwebsites",
                    IdName = "websites",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get all websites",
                            DescEndpoint = "This endpoint fetches all websites infos.",
                            ClassNameEndpoint = "websitesget",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/websites"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/websites"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"requirements\": \"string\",\r\n    \"browsersName\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:45:02.526Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Get websites by id",
                            DescEndpoint = "This endpoint fetches a websites info by id.",
                            ClassNameEndpoint = "websitesgetbyid",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET https://localhost:5000/api/websites/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "GET http://localhost:5001/api/websites/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the websites to get it" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"requirements\": \"string\",\r\n    \"browsersName\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:45:02.526Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Create websites",
                            DescEndpoint = "This endpoint creates a new websites.",
                            ClassNameEndpoint = "websitespost",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST https://localhost:5000/api/websites"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "POST http://localhost:5001/api/websites"
                                }
                            },
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the websites" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"requirements\": \"string\",\r\n    \"browsersName\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:45:02.526Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Update websites",
                            DescEndpoint = "This endpoint updates the current websites by id and body.",
                            ClassNameEndpoint = "websitesupdate",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT https://localhost:5000/api/websites/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "PUT http://localhost:5001/api/websites/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the websites to update" }
                                },
                            },
                            BodyParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the websites" }
                                },
                            },
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"requirements\": \"string\",\r\n    \"browsersName\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:45:02.526Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        },
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Delete websites By Id",
                            DescEndpoint = "This endpoint deletes a specific book by id.",
                            ClassNameEndpoint = "websitesdelete",
                            HttpReqsEndpoint = new List<HttpReqsEndpointCl>()
                            {
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE https://localhost:5000/api/websites/id"
                                },
                                new HttpReqsEndpointCl()
                                {
                                    Desc = "DELETE http://localhost:5001/api/websites/id"
                                }
                            },
                            QueryParamsEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Parameter", Desc = "Description" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Id", Desc = "The ID of the websites to delete" }
                                },
                            },
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = Newtonsoft.Json.JsonConvert.SerializeObject(Newtonsoft.Json.JsonConvert.DeserializeObject("[\r\n  {\r\n    \"id\": 0,\r\n    \"title\": \"string\",\r\n    \"type\": \"string\",\r\n    \"description\": \"string\",\r\n    \"companies\": \"string\",\r\n    \"imageUrl\": \"string\",\r\n    \"requirements\": \"string\",\r\n    \"browsersName\": \"string\",\r\n    \"rating\": 0,\r\n    \"dateCreated\": \"2024-02-06T14:45:02.526Z\",\r\n    \"authorName\": \"string\"\r\n,\r\n    \"urlValue\": \"string\"\r\n  }\r\n]"), Newtonsoft.Json.Formatting.Indented),
                            TblErrorsCodeEndpoint = null
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 9,
                            Title = "Websites",
                            Href = "websites",
                            Subitem = true,
                            SubitemList = GetSubitemListLinks()
                        }
                    }
                },
                new ContentDocsApi()
                {
                    Id = 10,
                    Title = "Errors",
                    Desc = "",
                    ClassName = "apierrors",
                    IdName = "errors",
                    ListSubContent = new List<SubContentDocsApi>()
                    {
                        new SubContentDocsApi()
                        {
                            TitleEndpoint = "Errors",
                            DescEndpoint = "The LCPCollection API uses the following error codes:",
                            ClassNameEndpoint = "",
                            HttpReqsEndpoint = null,
                            QueryParamsEndpoint = null,
                            BodyParamsEndpoint = null,
                            ModelValExampleEndpoint = "",
                            TblErrorsCodeEndpoint = new TblProps()
                            {
                                HeaderTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "Error Code", Desc = "Meaning" },
                                },
                                BodyTbl = new List<TblPropsObjs>()
                                {
                                    new TblPropsObjs() { Key = 1, Value = "403", Desc = "Forbidden - The data requested is hidden for staff only." },
                                    new TblPropsObjs() { Key = 2, Value = "404", Desc = "Not Found - The specified data could not be found."},
                                    new TblPropsObjs() { Key = 3, Value = "405", Desc = "Method Not Allowed - You tried to access a data with an invalid method."},
                                    new TblPropsObjs() { Key = 4, Value = "406", Desc = "Not Acceptable - You requested a format that isn't json."},
                                    new TblPropsObjs() { Key = 5, Value = "410", Desc = "Gone - The data requested has been removed from our servers."},
                                    new TblPropsObjs() { Key = 6, Value = "418", Desc = "I'm a teapot."},
                                    new TblPropsObjs() { Key = 7, Value = "429", Desc = "Too Many Requests - You're requesting too many datas! Slow down!"},
                                    new TblPropsObjs() { Key = 8, Value = "500", Desc = "Internal Server Error - We had a problem with our server. Try again later."},
                                    new TblPropsObjs() { Key = 9, Value = "503", Desc = "Service Unavailable - We're temporarily offline for maintenance. Please try again later."},
                                }
                            }
                        }
                    },
                    LinksListDocsApi = new List<LinksDocsApi>()
                    {
                        new LinksDocsApi()
                        {
                            Id = 8,
                            Title = "Errors",
                            Href = "errors",
                            Subitem = false,
                            SubitemList = null
                        }
                    }
                }
            };
        }

        public static List<LinksSubitemDocsApi> GetSubitemListLinks()
        {
            return new List<LinksSubitemDocsApi>()
            {
                new LinksSubitemDocsApi()
                {
                    Id = 1,
                    Title = "Get",
                    Href = "get"
                },
                new LinksSubitemDocsApi()
                {
                    Id = 2,
                    Title = "Get by Id",
                    Href = "getbyid"
                },
                new LinksSubitemDocsApi()
                {
                    Id = 3,
                    Title = "Post",
                    Href = "post"
                },
                new LinksSubitemDocsApi()
                {
                    Id = 4,
                    Title = "Update",
                    Href = "update"
                },
                new LinksSubitemDocsApi()
                {
                    Id = 5,
                    Title = "Delete",
                    Href = "delete"
                }
            };
        }
    }
}
